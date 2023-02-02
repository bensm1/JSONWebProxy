using Fiddler;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebDebugger.HttpsProxy {
    class Proxy {
        private readonly string[] _acceptedHostnames = new string[2];

        private Form _activeForm;

        private bool _autoScroll;
        private bool _autoLogJSON;
        private bool _beautifyJSON;

        public Proxy(string[] acceptedHostnames) {
            Array.Copy(acceptedHostnames, _acceptedHostnames, _acceptedHostnames.Length);
        }

        public void Start() {
            _activeForm = MainForm.ActiveForm;

            if (!FiddlerApplication.IsStarted()) {
                InstallCert();

                FiddlerApplication.BeforeRequest            += OnBeforeRequest;
                FiddlerApplication.BeforeResponse           += OnBeforeResponse;
                FiddlerApplication.ResponseHeadersAvailable += OnResponseHeadersAvailable;
                FiddlerApplication.Startup(8888, true, true, true);

                Log("Proxy running" + Environment.NewLine);
            }
        }

        public void Stop() {
            UninstallCert();

            FiddlerApplication.Shutdown();

            if (FiddlerApplication.oProxy != null) {
                if (FiddlerApplication.oProxy.IsAttached) {
                    FiddlerApplication.oProxy.Detach();
                }
            }

            Log("Proxy stopped");
        }

        private void InstallCert() {
            if (!CertMaker.rootCertExists()) {
                CertMaker.createRootCert();
                CertMaker.trustRootCert();

                Log("Certificate installed");
            }
        }

        private void UninstallCert() {
            if (CertMaker.rootCertExists()) {
                CertMaker.removeFiddlerGeneratedCerts();

                Log("Certificate uninstalled");
            }
        }

        /// <summary>
        /// Thread safe way of logging messages to the MainForm's log text box.
        /// </summary>
        /// <param name="message"></param>
        private void Log(string message) {
            if (string.IsNullOrWhiteSpace(message) || _activeForm == null) {
                return;
            }

            string newMessage = message + Environment.NewLine;

            if (_activeForm.InvokeRequired) {
                _activeForm.Invoke(new Action<string>(Log), new object[] { newMessage });
                return;
            }

            RichTextBox txtLog = GetControl<RichTextBox>("TxtProxyLog");
            txtLog.AppendText(newMessage);

            if (_autoScroll) {
                txtLog.ScrollToCaret();
            }
        }

        /// <summary>
        /// Scuffed way of getting the checked state of checkboxes. Everything here has to be thread safe.
        /// </summary>
        private void GetOptions() {
            if (_activeForm.InvokeRequired) {
                _activeForm.Invoke(new Action(GetOptions), null);
            }

            CheckBox checkScroll       = GetControl<CheckBox>("CheckAutoScroll");
            CheckBox checkLogJSON      = GetControl<CheckBox>("CheckAutoLogJSON");
            CheckBox checkBeautifyJSON = GetControl<CheckBox>("CheckBeautifyJSON");

            _autoScroll   = checkScroll.Checked;
            _autoLogJSON  = checkLogJSON.Checked;
            _beautifyJSON = checkBeautifyJSON.Checked;
        }

        private void OnBeforeResponse(Session oSession) {
            if (!_acceptedHostnames.Contains(oSession.hostname)) {
                return;
            }

            GetOptions();

            // Decompress the response
            oSession.utilDecodeResponse();
            string body = oSession.GetResponseBodyAsString();

            if (_autoLogJSON && IsValidJson(body)) {
                if (_beautifyJSON) {
                    var tempJsonObj = JsonConvert.DeserializeObject(body);
                    Log(JsonConvert.SerializeObject(tempJsonObj, Formatting.Indented));
                } else {
                    Log(body);
                }
            }
        }

        private void OnBeforeRequest(Session oSession) {
            // Accept gzipped responses
            oSession.oRequest["Accept-Encoding"] = "gzip";
        }

        private void OnResponseHeadersAvailable(Session oSession) {
            if (_acceptedHostnames.Contains(oSession.hostname)) {
                // Allow response editing
                oSession.bBufferResponse = true;
            }
        }

        // TODO: move to a utils class
        private T GetControl<T>(string controlName) where T : Control {
            return (T)_activeForm.Controls.Find(controlName, true)[0];
        }

        // TODO: move to a utils class
        private bool IsValidJson(string strInput) {
            if (string.IsNullOrWhiteSpace(strInput)) { 
                return false; 
            }

            strInput = strInput.Trim();

            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || // For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) { // For array
                    try {
                        var obj = JToken.Parse(strInput);
                        return true;
                    }
                    catch (JsonReaderException jex) {
                        Log($"ERROR parsing JSON: {jex.Message}");
                        return false;
                    }
                    catch (Exception ex) {
                        Log($"ERROR parsing JSON: {ex}");
                        return false;
                    }
            }
            else {
                return false;
            }
        }

        public ProxyPacket[] PacketBacklog {
            get;
            set;
        } = new ProxyPacket[10];
    }
}
