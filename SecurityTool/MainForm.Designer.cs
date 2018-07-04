namespace SecurityTool
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadShellTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_ShowMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_blank = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_productVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_index = new System.Windows.Forms.TabPage();
            this.label_disclaimer = new System.Windows.Forms.Label();
            this.label_logo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainer_DeveloperMode = new System.Windows.Forms.SplitContainer();
            this.treeView_func = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_index.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_DeveloperMode)).BeginInit();
            this.splitContainer_DeveloperMode.Panel1.SuspendLayout();
            this.splitContainer_DeveloperMode.Panel2.SuspendLayout();
            this.splitContainer_DeveloperMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.pluginsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadShellTypeToolStripMenuItem,
            this.reloadSettingToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // reloadShellTypeToolStripMenuItem
            // 
            this.reloadShellTypeToolStripMenuItem.Name = "reloadShellTypeToolStripMenuItem";
            this.reloadShellTypeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.reloadShellTypeToolStripMenuItem.Text = "Reload ShellType";
            // 
            // reloadSettingToolStripMenuItem
            // 
            this.reloadSettingToolStripMenuItem.Name = "reloadSettingToolStripMenuItem";
            this.reloadSettingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.reloadSettingToolStripMenuItem.Text = "Reload Setting";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developerModeToolStripMenuItem,
            this.documentToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // developerModeToolStripMenuItem
            // 
            this.developerModeToolStripMenuItem.Name = "developerModeToolStripMenuItem";
            this.developerModeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.developerModeToolStripMenuItem.Text = "Developer Mode";
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.documentToolStripMenuItem.Text = "Document";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_ShowMsg,
            this.toolStripStatusLabel_blank,
            this.toolStripStatusLabel_productVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(835, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_ShowMsg
            // 
            this.toolStripStatusLabel_ShowMsg.Name = "toolStripStatusLabel_ShowMsg";
            this.toolStripStatusLabel_ShowMsg.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel_ShowMsg.Text = "ShowMsg";
            // 
            // toolStripStatusLabel_blank
            // 
            this.toolStripStatusLabel_blank.Name = "toolStripStatusLabel_blank";
            this.toolStripStatusLabel_blank.Size = new System.Drawing.Size(673, 17);
            this.toolStripStatusLabel_blank.Spring = true;
            // 
            // toolStripStatusLabel_productVersion
            // 
            this.toolStripStatusLabel_productVersion.Name = "toolStripStatusLabel_productVersion";
            this.toolStripStatusLabel_productVersion.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel_productVersion.Text = "productVersion";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_index);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 481);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_index
            // 
            this.tabPage_index.Controls.Add(this.label_disclaimer);
            this.tabPage_index.Controls.Add(this.label_logo);
            this.tabPage_index.Location = new System.Drawing.Point(4, 22);
            this.tabPage_index.Name = "tabPage_index";
            this.tabPage_index.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_index.Size = new System.Drawing.Size(692, 455);
            this.tabPage_index.TabIndex = 0;
            this.tabPage_index.Text = "Index";
            this.tabPage_index.UseVisualStyleBackColor = true;
            this.tabPage_index.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label_disclaimer
            // 
            this.label_disclaimer.AutoSize = true;
            this.label_disclaimer.Font = new System.Drawing.Font("宋体", 16F);
            this.label_disclaimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_disclaimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_disclaimer.Location = new System.Drawing.Point(35, 43);
            this.label_disclaimer.Name = "label_disclaimer";
            this.label_disclaimer.Size = new System.Drawing.Size(714, 66);
            this.label_disclaimer.TabIndex = 2;
            this.label_disclaimer.Text = "Disclaimer: \nThis program is for learning and research! \nPlease users to comply w" +
    "ith relevant state laws and regulations!";
            // 
            // label_logo
            // 
            this.label_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.label_logo.ForeColor = System.Drawing.Color.DarkGray;
            this.label_logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_logo.Location = new System.Drawing.Point(308, 335);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(384, 120);
            this.label_logo.TabIndex = 1;
            this.label_logo.Text = "Altman";
            this.label_logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainer_DeveloperMode
            // 
            this.splitContainer_DeveloperMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_DeveloperMode.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_DeveloperMode.Name = "splitContainer_DeveloperMode";
            // 
            // splitContainer_DeveloperMode.Panel1
            // 
            this.splitContainer_DeveloperMode.Panel1.Controls.Add(this.treeView_func);
            // 
            // splitContainer_DeveloperMode.Panel2
            // 
            this.splitContainer_DeveloperMode.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer_DeveloperMode.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer_DeveloperMode.Size = new System.Drawing.Size(835, 505);
            this.splitContainer_DeveloperMode.SplitterDistance = 133;
            this.splitContainer_DeveloperMode.SplitterWidth = 2;
            this.splitContainer_DeveloperMode.TabIndex = 3;
            // 
            // treeView_func
            // 
            this.treeView_func.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_func.Location = new System.Drawing.Point(0, 0);
            this.treeView_func.Name = "treeView_func";
            this.treeView_func.Size = new System.Drawing.Size(133, 505);
            this.treeView_func.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 527);
            this.Controls.Add(this.splitContainer_DeveloperMode);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SecurityTool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_index.ResumeLayout(false);
            this.tabPage_index.PerformLayout();
            this.splitContainer_DeveloperMode.Panel1.ResumeLayout(false);
            this.splitContainer_DeveloperMode.Panel2.ResumeLayout(false);
            this.splitContainer_DeveloperMode.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_DeveloperMode)).EndInit();
            this.splitContainer_DeveloperMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ShowMsg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_blank;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_productVersion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_index;
        private System.Windows.Forms.ToolStripMenuItem reloadShellTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label_disclaimer;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer_DeveloperMode;
        private System.Windows.Forms.TreeView treeView_func;
    }
}

