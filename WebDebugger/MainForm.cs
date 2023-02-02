using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDebugger.HttpsProxy;

namespace WebDebugger {
    public partial class MainForm : Form {
        private Proxy _proxy;

        public MainForm() {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e) {
            if (_proxy == null) {
                _proxy = new Proxy(Hostnames);
            }

            _proxy.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e) {
            if (_proxy == null) {
                _proxy = new Proxy(Hostnames);
            }

            _proxy.Stop();
            _proxy = null;
        }

        private void BtnClearLog_Click(object sender, EventArgs e) {
            TxtProxyLog.Text = "";
        }

        private void BtnSendToEditor_Click(object sender, EventArgs e) {

        }

        private void BtnImportJSON_Click(object sender, EventArgs e) {

        }

        private string[] Hostnames {
            get {
                return new string[] {
                    TxtHost1.Text,
                    TxtHost2.Text
                };
            }
        }
    }
}
