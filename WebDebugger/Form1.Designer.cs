
namespace WebDebugger {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabProxy = new System.Windows.Forms.TabPage();
            this.BtnClearLog = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckAutoScroll = new System.Windows.Forms.CheckBox();
            this.CheckBeautifyJSON = new System.Windows.Forms.CheckBox();
            this.CheckAutoLogJSON = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtHost1 = new System.Windows.Forms.TextBox();
            this.TxtHost2 = new System.Windows.Forms.TextBox();
            this.TxtProxyLog = new System.Windows.Forms.RichTextBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TabJSONEditor = new System.Windows.Forms.TabPage();
            this.LinkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.BtnImportJSON = new System.Windows.Forms.Button();
            this.BtnExportJSON = new System.Windows.Forms.Button();
            this.BtnSendToEditor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtJSONKey = new System.Windows.Forms.TextBox();
            this.TxtJSONValue = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabProxy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabJSONEditor.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabProxy);
            this.tabControl1.Controls.Add(this.TabJSONEditor);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1216, 593);
            this.tabControl1.TabIndex = 0;
            // 
            // TabProxy
            // 
            this.TabProxy.Controls.Add(this.BtnSendToEditor);
            this.TabProxy.Controls.Add(this.BtnClearLog);
            this.TabProxy.Controls.Add(this.groupBox2);
            this.TabProxy.Controls.Add(this.groupBox1);
            this.TabProxy.Controls.Add(this.TxtProxyLog);
            this.TabProxy.Controls.Add(this.BtnStop);
            this.TabProxy.Controls.Add(this.BtnStart);
            this.TabProxy.Location = new System.Drawing.Point(4, 22);
            this.TabProxy.Name = "TabProxy";
            this.TabProxy.Padding = new System.Windows.Forms.Padding(3);
            this.TabProxy.Size = new System.Drawing.Size(1208, 567);
            this.TabProxy.TabIndex = 0;
            this.TabProxy.Text = "Proxy";
            this.TabProxy.UseVisualStyleBackColor = true;
            // 
            // BtnClearLog
            // 
            this.BtnClearLog.Location = new System.Drawing.Point(168, 99);
            this.BtnClearLog.Name = "BtnClearLog";
            this.BtnClearLog.Size = new System.Drawing.Size(75, 23);
            this.BtnClearLog.TabIndex = 7;
            this.BtnClearLog.Text = "Clear Log";
            this.BtnClearLog.UseVisualStyleBackColor = true;
            this.BtnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckAutoScroll);
            this.groupBox2.Controls.Add(this.CheckBeautifyJSON);
            this.groupBox2.Controls.Add(this.CheckAutoLogJSON);
            this.groupBox2.Location = new System.Drawing.Point(317, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 87);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LOGGER";
            // 
            // CheckAutoScroll
            // 
            this.CheckAutoScroll.AutoSize = true;
            this.CheckAutoScroll.Checked = true;
            this.CheckAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckAutoScroll.Location = new System.Drawing.Point(10, 54);
            this.CheckAutoScroll.Name = "CheckAutoScroll";
            this.CheckAutoScroll.Size = new System.Drawing.Size(72, 17);
            this.CheckAutoScroll.TabIndex = 2;
            this.CheckAutoScroll.Text = "Autoscroll";
            this.CheckAutoScroll.UseVisualStyleBackColor = true;
            // 
            // CheckBeautifyJSON
            // 
            this.CheckBeautifyJSON.AutoSize = true;
            this.CheckBeautifyJSON.Checked = true;
            this.CheckBeautifyJSON.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBeautifyJSON.Location = new System.Drawing.Point(10, 35);
            this.CheckBeautifyJSON.Name = "CheckBeautifyJSON";
            this.CheckBeautifyJSON.Size = new System.Drawing.Size(95, 17);
            this.CheckBeautifyJSON.TabIndex = 1;
            this.CheckBeautifyJSON.Text = "Beautify JSON";
            this.CheckBeautifyJSON.UseVisualStyleBackColor = true;
            // 
            // CheckAutoLogJSON
            // 
            this.CheckAutoLogJSON.AutoSize = true;
            this.CheckAutoLogJSON.Checked = true;
            this.CheckAutoLogJSON.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckAutoLogJSON.Location = new System.Drawing.Point(10, 16);
            this.CheckAutoLogJSON.Name = "CheckAutoLogJSON";
            this.CheckAutoLogJSON.Size = new System.Drawing.Size(100, 17);
            this.CheckAutoLogJSON.TabIndex = 0;
            this.CheckAutoLogJSON.Text = "Auto-Log JSON";
            this.CheckAutoLogJSON.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtHost1);
            this.groupBox1.Controls.Add(this.TxtHost2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HOSTNAMES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hostname filters. Leave empty to capture all traffic.";
            // 
            // TxtHost1
            // 
            this.TxtHost1.Location = new System.Drawing.Point(9, 32);
            this.TxtHost1.Name = "TxtHost1";
            this.TxtHost1.Size = new System.Drawing.Size(286, 20);
            this.TxtHost1.TabIndex = 3;
            // 
            // TxtHost2
            // 
            this.TxtHost2.Location = new System.Drawing.Point(9, 58);
            this.TxtHost2.Name = "TxtHost2";
            this.TxtHost2.Size = new System.Drawing.Size(286, 20);
            this.TxtHost2.TabIndex = 4;
            // 
            // TxtProxyLog
            // 
            this.TxtProxyLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProxyLog.Location = new System.Drawing.Point(6, 128);
            this.TxtProxyLog.Name = "TxtProxyLog";
            this.TxtProxyLog.Size = new System.Drawing.Size(1196, 433);
            this.TxtProxyLog.TabIndex = 2;
            this.TxtProxyLog.Text = "";
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(87, 99);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(6, 99);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TabJSONEditor
            // 
            this.TabJSONEditor.Controls.Add(this.groupBox3);
            this.TabJSONEditor.Controls.Add(this.BtnExportJSON);
            this.TabJSONEditor.Controls.Add(this.BtnImportJSON);
            this.TabJSONEditor.Location = new System.Drawing.Point(4, 22);
            this.TabJSONEditor.Name = "TabJSONEditor";
            this.TabJSONEditor.Padding = new System.Windows.Forms.Padding(3);
            this.TabJSONEditor.Size = new System.Drawing.Size(1208, 567);
            this.TabJSONEditor.TabIndex = 1;
            this.TabJSONEditor.Text = "JSON Editor";
            this.TabJSONEditor.UseVisualStyleBackColor = true;
            // 
            // LinkLabelGithub
            // 
            this.LinkLabelGithub.AutoSize = true;
            this.LinkLabelGithub.Location = new System.Drawing.Point(1144, 604);
            this.LinkLabelGithub.Name = "LinkLabelGithub";
            this.LinkLabelGithub.Size = new System.Drawing.Size(80, 13);
            this.LinkLabelGithub.TabIndex = 1;
            this.LinkLabelGithub.TabStop = true;
            this.LinkLabelGithub.Text = "Github/bensm1";
            // 
            // BtnImportJSON
            // 
            this.BtnImportJSON.Location = new System.Drawing.Point(6, 3);
            this.BtnImportJSON.Name = "BtnImportJSON";
            this.BtnImportJSON.Size = new System.Drawing.Size(75, 23);
            this.BtnImportJSON.TabIndex = 0;
            this.BtnImportJSON.Text = "Import";
            this.BtnImportJSON.UseVisualStyleBackColor = true;
            this.BtnImportJSON.Click += new System.EventHandler(this.BtnImportJSON_Click);
            // 
            // BtnExportJSON
            // 
            this.BtnExportJSON.Location = new System.Drawing.Point(87, 3);
            this.BtnExportJSON.Name = "BtnExportJSON";
            this.BtnExportJSON.Size = new System.Drawing.Size(75, 23);
            this.BtnExportJSON.TabIndex = 1;
            this.BtnExportJSON.Text = "Export";
            this.BtnExportJSON.UseVisualStyleBackColor = true;
            // 
            // BtnSendToEditor
            // 
            this.BtnSendToEditor.Location = new System.Drawing.Point(249, 99);
            this.BtnSendToEditor.Name = "BtnSendToEditor";
            this.BtnSendToEditor.Size = new System.Drawing.Size(75, 23);
            this.BtnSendToEditor.TabIndex = 8;
            this.BtnSendToEditor.Text = "Edit JSON";
            this.BtnSendToEditor.UseVisualStyleBackColor = true;
            this.BtnSendToEditor.Click += new System.EventHandler(this.BtnSendToEditor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtJSONValue);
            this.groupBox3.Controls.Add(this.TxtJSONKey);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(860, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 538);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Value";
            // 
            // TxtJSONKey
            // 
            this.TxtJSONKey.Location = new System.Drawing.Point(27, 47);
            this.TxtJSONKey.Name = "TxtJSONKey";
            this.TxtJSONKey.Size = new System.Drawing.Size(283, 20);
            this.TxtJSONKey.TabIndex = 2;
            // 
            // TxtJSONValue
            // 
            this.TxtJSONValue.Location = new System.Drawing.Point(27, 133);
            this.TxtJSONValue.Name = "TxtJSONValue";
            this.TxtJSONValue.Size = new System.Drawing.Size(283, 20);
            this.TxtJSONValue.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 622);
            this.Controls.Add(this.LinkLabelGithub);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Web Debugger";
            this.tabControl1.ResumeLayout(false);
            this.TabProxy.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabJSONEditor.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabProxy;
        private System.Windows.Forms.RichTextBox TxtProxyLog;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TabPage TabJSONEditor;
        private System.Windows.Forms.LinkLabel LinkLabelGithub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtHost1;
        private System.Windows.Forms.TextBox TxtHost2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CheckBeautifyJSON;
        private System.Windows.Forms.CheckBox CheckAutoLogJSON;
        private System.Windows.Forms.CheckBox CheckAutoScroll;
        private System.Windows.Forms.Button BtnClearLog;
        private System.Windows.Forms.Button BtnSendToEditor;
        private System.Windows.Forms.Button BtnExportJSON;
        private System.Windows.Forms.Button BtnImportJSON;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtJSONValue;
        private System.Windows.Forms.TextBox TxtJSONKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

