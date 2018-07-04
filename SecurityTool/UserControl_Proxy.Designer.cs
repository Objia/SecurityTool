namespace SecurityTool
{
    partial class UserControl_proxy
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_proxy));
            this.radioButton_noProxy = new System.Windows.Forms.RadioButton();
            this.radioButton_systemProxy = new System.Windows.Forms.RadioButton();
            this.radioButton_customProxy = new System.Windows.Forms.RadioButton();
            this.panel_customProxy = new System.Windows.Forms.Panel();
            this.textBox_domain = new System.Windows.Forms.TextBox();
            this.label_domain = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_server = new System.Windows.Forms.TextBox();
            this.label_server = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.panel_customProxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_noProxy
            // 
            resources.ApplyResources(this.radioButton_noProxy, "radioButton_noProxy");
            this.radioButton_noProxy.Name = "radioButton_noProxy";
            this.radioButton_noProxy.TabStop = true;
            this.radioButton_noProxy.UseVisualStyleBackColor = true;
            this.radioButton_noProxy.CheckedChanged += new System.EventHandler(this.radioButton_noProxy_CheckedChanged);
            // 
            // radioButton_systemProxy
            // 
            resources.ApplyResources(this.radioButton_systemProxy, "radioButton_systemProxy");
            this.radioButton_systemProxy.Name = "radioButton_systemProxy";
            this.radioButton_systemProxy.TabStop = true;
            this.radioButton_systemProxy.UseVisualStyleBackColor = true;
            // 
            // radioButton_customProxy
            // 
            resources.ApplyResources(this.radioButton_customProxy, "radioButton_customProxy");
            this.radioButton_customProxy.Name = "radioButton_customProxy";
            this.radioButton_customProxy.TabStop = true;
            this.radioButton_customProxy.UseVisualStyleBackColor = true;
            // 
            // panel_customProxy
            // 
            resources.ApplyResources(this.panel_customProxy, "panel_customProxy");
            this.panel_customProxy.Controls.Add(this.textBox_domain);
            this.panel_customProxy.Controls.Add(this.label_domain);
            this.panel_customProxy.Controls.Add(this.textBox_password);
            this.panel_customProxy.Controls.Add(this.label_password);
            this.panel_customProxy.Controls.Add(this.textBox_user);
            this.panel_customProxy.Controls.Add(this.label_user);
            this.panel_customProxy.Controls.Add(this.label_port);
            this.panel_customProxy.Controls.Add(this.textBox_server);
            this.panel_customProxy.Controls.Add(this.label_server);
            this.panel_customProxy.Name = "panel_customProxy";
            this.panel_customProxy.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_customProxy_Paint);
            // 
            // textBox_domain
            // 
            resources.ApplyResources(this.textBox_domain, "textBox_domain");
            this.textBox_domain.Name = "textBox_domain";
            // 
            // label_domain
            // 
            resources.ApplyResources(this.label_domain, "label_domain");
            this.label_domain.Name = "label_domain";
            // 
            // textBox_password
            // 
            resources.ApplyResources(this.textBox_password, "textBox_password");
            this.textBox_password.Name = "textBox_password";
            // 
            // label_password
            // 
            resources.ApplyResources(this.label_password, "label_password");
            this.label_password.Name = "label_password";
            this.label_password.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_user
            // 
            resources.ApplyResources(this.textBox_user, "textBox_user");
            this.textBox_user.Name = "textBox_user";
            // 
            // label_user
            // 
            resources.ApplyResources(this.label_user, "label_user");
            this.label_user.Name = "label_user";
            // 
            // label_port
            // 
            resources.ApplyResources(this.label_port, "label_port");
            this.label_port.Name = "label_port";
            // 
            // textBox_server
            // 
            resources.ApplyResources(this.textBox_server, "textBox_server");
            this.textBox_server.Name = "textBox_server";
            this.textBox_server.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_server
            // 
            resources.ApplyResources(this.label_server, "label_server");
            this.label_server.Name = "label_server";
            // 
            // textBox_port
            // 
            resources.ApplyResources(this.textBox_port, "textBox_port");
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UserControl_Proxy
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.panel_customProxy);
            this.Controls.Add(this.radioButton_customProxy);
            this.Controls.Add(this.radioButton_systemProxy);
            this.Controls.Add(this.radioButton_noProxy);
            this.Name = "UserControl_Proxy";
            this.Load += new System.EventHandler(this.UserControl_Proxy_Load);
            this.panel_customProxy.ResumeLayout(false);
            this.panel_customProxy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_noProxy;
        private System.Windows.Forms.RadioButton radioButton_systemProxy;
        private System.Windows.Forms.RadioButton radioButton_customProxy;
        private System.Windows.Forms.Panel panel_customProxy;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox_server;
        private System.Windows.Forms.Label label_server;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_domain;
        private System.Windows.Forms.Label label_domain;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Label label_user;
    }
}
