﻿namespace SecurityTool
{
    partial class UserControl_policy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_policy));
            this.checkBox_randomChars = new System.Windows.Forms.CheckBox();
            this.checkBox_disclaimer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_randomChars
            // 
            resources.ApplyResources(this.checkBox_randomChars, "checkBox_randomChars");
            this.checkBox_randomChars.Name = "checkBox_randomChars";
            this.checkBox_randomChars.UseVisualStyleBackColor = true;
            // 
            // checkBox_disclaimer
            // 
            resources.ApplyResources(this.checkBox_disclaimer, "checkBox_disclaimer");
            this.checkBox_disclaimer.Name = "checkBox_disclaimer";
            this.checkBox_disclaimer.UseVisualStyleBackColor = true;
            // 
            // UserControl_Policy
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_disclaimer);
            this.Controls.Add(this.checkBox_randomChars);
            this.Name = "UserControl_Policy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_randomChars;
        private System.Windows.Forms.CheckBox checkBox_disclaimer;
    }
}
