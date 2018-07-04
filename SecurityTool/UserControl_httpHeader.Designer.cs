namespace SecurityTool
{
    partial class UserControl_httpHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_httpHeader));
            this.listView_httpHeader = new System.Windows.Forms.ListView();
            this.columnHeader_key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_httpHeader
            // 
            resources.ApplyResources(this.listView_httpHeader, "listView_httpHeader");
            this.listView_httpHeader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_key,
            this.columnHeader_value});
            this.listView_httpHeader.GridLines = true;
            this.listView_httpHeader.Name = "listView_httpHeader";
            this.listView_httpHeader.UseCompatibleStateImageBehavior = false;
            this.listView_httpHeader.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_key
            // 
            resources.ApplyResources(this.columnHeader_key, "columnHeader_key");
            // 
            // columnHeader_value
            // 
            resources.ApplyResources(this.columnHeader_value, "columnHeader_value");
            // 
            // UserControl_httpHeader
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_httpHeader);
            this.Name = "UserControl_httpHeader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_httpHeader;
        private System.Windows.Forms.ColumnHeader columnHeader_key;
        private System.Windows.Forms.ColumnHeader columnHeader_value;
    }
}
