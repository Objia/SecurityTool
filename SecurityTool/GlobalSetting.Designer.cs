namespace SecurityTool
{
    partial class Form_globalSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_userAgent = new System.Windows.Forms.TabPage();
            this.tabPage_httpHeader = new System.Windows.Forms.TabPage();
            this.tabPage_policy = new System.Windows.Forms.TabPage();
            this.tabPage_proxy = new System.Windows.Forms.TabPage();
            this.tabPage_language = new System.Windows.Forms.TabPage();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.userControl_userAgent1 = new SecurityTool.UserControl_userAgent();
            this.userControl_httpHeader1 = new SecurityTool.UserControl_httpHeader();
            this.userControl_Policy1 = new SecurityTool.UserControl_policy();
            this.userControl_Proxy1 = new SecurityTool.UserControl_proxy();
            this.userControl_language1 = new SecurityTool.UserControl_language();
            this.tabControl.SuspendLayout();
            this.tabPage_userAgent.SuspendLayout();
            this.tabPage_httpHeader.SuspendLayout();
            this.tabPage_policy.SuspendLayout();
            this.tabPage_proxy.SuspendLayout();
            this.tabPage_language.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_userAgent);
            this.tabControl.Controls.Add(this.tabPage_httpHeader);
            this.tabControl.Controls.Add(this.tabPage_policy);
            this.tabControl.Controls.Add(this.tabPage_proxy);
            this.tabControl.Controls.Add(this.tabPage_language);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(374, 354);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_userAgent
            // 
            this.tabPage_userAgent.Controls.Add(this.userControl_userAgent1);
            this.tabPage_userAgent.Location = new System.Drawing.Point(4, 22);
            this.tabPage_userAgent.Name = "tabPage_userAgent";
            this.tabPage_userAgent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_userAgent.Size = new System.Drawing.Size(366, 328);
            this.tabPage_userAgent.TabIndex = 0;
            this.tabPage_userAgent.Text = "UserAgent";
            this.tabPage_userAgent.UseVisualStyleBackColor = true;
            // 
            // tabPage_httpHeader
            // 
            this.tabPage_httpHeader.Controls.Add(this.userControl_httpHeader1);
            this.tabPage_httpHeader.Location = new System.Drawing.Point(4, 22);
            this.tabPage_httpHeader.Name = "tabPage_httpHeader";
            this.tabPage_httpHeader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_httpHeader.Size = new System.Drawing.Size(366, 328);
            this.tabPage_httpHeader.TabIndex = 1;
            this.tabPage_httpHeader.Text = "HttpHeader";
            this.tabPage_httpHeader.UseVisualStyleBackColor = true;
            // 
            // tabPage_policy
            // 
            this.tabPage_policy.Controls.Add(this.userControl_Policy1);
            this.tabPage_policy.Location = new System.Drawing.Point(4, 22);
            this.tabPage_policy.Name = "tabPage_policy";
            this.tabPage_policy.Size = new System.Drawing.Size(366, 328);
            this.tabPage_policy.TabIndex = 2;
            this.tabPage_policy.Text = "Policy";
            this.tabPage_policy.UseVisualStyleBackColor = true;
            // 
            // tabPage_proxy
            // 
            this.tabPage_proxy.Controls.Add(this.userControl_Proxy1);
            this.tabPage_proxy.Location = new System.Drawing.Point(4, 22);
            this.tabPage_proxy.Name = "tabPage_proxy";
            this.tabPage_proxy.Size = new System.Drawing.Size(366, 328);
            this.tabPage_proxy.TabIndex = 3;
            this.tabPage_proxy.Text = "Proxy";
            this.tabPage_proxy.UseVisualStyleBackColor = true;
            // 
            // tabPage_language
            // 
            this.tabPage_language.Controls.Add(this.userControl_language1);
            this.tabPage_language.Location = new System.Drawing.Point(4, 22);
            this.tabPage_language.Name = "tabPage_language";
            this.tabPage_language.Size = new System.Drawing.Size(366, 328);
            this.tabPage_language.TabIndex = 4;
            this.tabPage_language.Text = "Language";
            this.tabPage_language.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(306, 371);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(214, 372);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // userControl_userAgent1
            // 
            this.userControl_userAgent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_userAgent1.Location = new System.Drawing.Point(3, 3);
            this.userControl_userAgent1.Name = "userControl_userAgent1";
            this.userControl_userAgent1.Size = new System.Drawing.Size(360, 322);
            this.userControl_userAgent1.TabIndex = 0;
            // 
            // userControl_httpHeader1
            // 
            this.userControl_httpHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_httpHeader1.Location = new System.Drawing.Point(3, 3);
            this.userControl_httpHeader1.Name = "userControl_httpHeader1";
            this.userControl_httpHeader1.Size = new System.Drawing.Size(360, 322);
            this.userControl_httpHeader1.TabIndex = 0;
            this.userControl_httpHeader1.Load += new System.EventHandler(this.userControl_httpHeader1_Load);
            // 
            // userControl_Policy1
            // 
            this.userControl_Policy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Policy1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Policy1.Name = "userControl_Policy1";
            this.userControl_Policy1.Size = new System.Drawing.Size(366, 328);
            this.userControl_Policy1.TabIndex = 0;
            // 
            // userControl_Proxy1
            // 
            this.userControl_Proxy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Proxy1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Proxy1.Name = "userControl_Proxy1";
            this.userControl_Proxy1.Size = new System.Drawing.Size(366, 328);
            this.userControl_Proxy1.TabIndex = 0;
            // 
            // userControl_language1
            // 
            this.userControl_language1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_language1.Location = new System.Drawing.Point(0, 0);
            this.userControl_language1.Name = "userControl_language1";
            this.userControl_language1.Size = new System.Drawing.Size(366, 328);
            this.userControl_language1.TabIndex = 0;
            // 
            // Form_globalSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 406);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_globalSetting";
            this.Text = "GlobalSetting";
            this.tabControl.ResumeLayout(false);
            this.tabPage_userAgent.ResumeLayout(false);
            this.tabPage_httpHeader.ResumeLayout(false);
            this.tabPage_policy.ResumeLayout(false);
            this.tabPage_proxy.ResumeLayout(false);
            this.tabPage_language.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_userAgent;
        private System.Windows.Forms.TabPage tabPage_httpHeader;
        private System.Windows.Forms.TabPage tabPage_policy;
        private System.Windows.Forms.TabPage tabPage_proxy;
        private System.Windows.Forms.TabPage tabPage_language;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private UserControl_userAgent userControl_userAgent1;
        private UserControl_httpHeader userControl_httpHeader1;
        private UserControl_policy userControl_Policy1;
        private UserControl_proxy userControl_Proxy1;
        private UserControl_language userControl_language1;
    }
}