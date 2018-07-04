namespace SecurityTool
{
    partial class Form_aboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_aboutBox));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_productName = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.textBox_discription = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.61616F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.38384F));
            this.tableLayoutPanel.Controls.Add(this.pictureBox_logo, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label_productName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label_version, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label_copyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBox_discription, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.button_ok, 1, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(396, 264);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.tableLayoutPanel.SetRowSpan(this.pictureBox_logo, 5);
            this.pictureBox_logo.Size = new System.Drawing.Size(138, 258);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_productName.Location = new System.Drawing.Point(147, 0);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(246, 29);
            this.label_productName.TabIndex = 1;
            this.label_productName.Text = "产品名称";
            this.label_productName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_version.Location = new System.Drawing.Point(147, 29);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(246, 29);
            this.label_version.TabIndex = 2;
            this.label_version.Text = "版本";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_copyright.Location = new System.Drawing.Point(147, 58);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(246, 29);
            this.label_copyright.TabIndex = 3;
            this.label_copyright.Text = "版权";
            this.label_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_discription
            // 
            this.textBox_discription.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_discription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_discription.Location = new System.Drawing.Point(147, 90);
            this.textBox_discription.Multiline = true;
            this.textBox_discription.Name = "textBox_discription";
            this.textBox_discription.Size = new System.Drawing.Size(246, 140);
            this.textBox_discription.TabIndex = 4;
            this.textBox_discription.Text = "说明";
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.Location = new System.Drawing.Point(318, 236);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // Form_aboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 264);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_aboutBox";
            this.Text = "AboutBox";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.TextBox textBox_discription;
        private System.Windows.Forms.Button button_ok;
    }
}