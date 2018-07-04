namespace SecurityTool
{
    partial class UserControl_userAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_userAgent));
            this.checkBox_userAgent = new System.Windows.Forms.CheckBox();
            this.label_userAgentList = new System.Windows.Forms.Label();
            this.comboBox_userAgentList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBox_userAgent
            // 
            resources.ApplyResources(this.checkBox_userAgent, "checkBox_userAgent");
            this.checkBox_userAgent.Name = "checkBox_userAgent";
            this.checkBox_userAgent.UseVisualStyleBackColor = true;
            // 
            // label_userAgentList
            // 
            resources.ApplyResources(this.label_userAgentList, "label_userAgentList");
            this.label_userAgentList.Name = "label_userAgentList";
            // 
            // comboBox_userAgentList
            // 
            resources.ApplyResources(this.comboBox_userAgentList, "comboBox_userAgentList");
            this.comboBox_userAgentList.FormattingEnabled = true;
            this.comboBox_userAgentList.Name = "comboBox_userAgentList";
            // 
            // UserControl_userAgent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_userAgentList);
            this.Controls.Add(this.label_userAgentList);
            this.Controls.Add(this.checkBox_userAgent);
            this.Name = "UserControl_userAgent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_userAgent;
        private System.Windows.Forms.Label label_userAgentList;
        private System.Windows.Forms.ComboBox comboBox_userAgentList;
    }
}
