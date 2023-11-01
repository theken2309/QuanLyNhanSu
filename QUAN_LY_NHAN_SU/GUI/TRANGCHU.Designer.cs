namespace QUAN_LY_NHAN_SU.GUI
{
    partial class frm_TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TrangChu));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher3 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝNHÂNSỰToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỆTHỐNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHÔNGTINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHOÁTHỆTHỐNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đĂNGXUẤTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // fileSystemWatcher3
            // 
            this.fileSystemWatcher3.EnableRaisingEvents = true;
            this.fileSystemWatcher3.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.hỆTHỐNGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(726, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Snow;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUẢNLÝNHÂNSỰToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 29);
            this.toolStripMenuItem1.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // qUẢNLÝNHÂNSỰToolStripMenuItem
            // 
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.Name = "qUẢNLÝNHÂNSỰToolStripMenuItem";
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.Text = "QUẢN LÝ NHÂN SỰ";
            this.qUẢNLÝNHÂNSỰToolStripMenuItem.Click += new System.EventHandler(this.qUẢNLÝNHÂNSỰToolStripMenuItem_Click);
            // 
            // hỆTHỐNGToolStripMenuItem
            // 
            this.hỆTHỐNGToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.hỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHÔNGTINToolStripMenuItem,
            this.tHOÁTHỆTHỐNGToolStripMenuItem,
            this.đĂNGXUẤTToolStripMenuItem});
            this.hỆTHỐNGToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hỆTHỐNGToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hỆTHỐNGToolStripMenuItem.Name = "hỆTHỐNGToolStripMenuItem";
            this.hỆTHỐNGToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.hỆTHỐNGToolStripMenuItem.Text = "HỆ THỐNG";
            // 
            // tHÔNGTINToolStripMenuItem
            // 
            this.tHÔNGTINToolStripMenuItem.Name = "tHÔNGTINToolStripMenuItem";
            this.tHÔNGTINToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.tHÔNGTINToolStripMenuItem.Text = "THÔNG TIN";
            this.tHÔNGTINToolStripMenuItem.Click += new System.EventHandler(this.tHÔNGTINToolStripMenuItem_Click);
            // 
            // tHOÁTHỆTHỐNGToolStripMenuItem
            // 
            this.tHOÁTHỆTHỐNGToolStripMenuItem.Name = "tHOÁTHỆTHỐNGToolStripMenuItem";
            this.tHOÁTHỆTHỐNGToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.tHOÁTHỆTHỐNGToolStripMenuItem.Text = "THOÁT HỆ THỐNG";
            this.tHOÁTHỆTHỐNGToolStripMenuItem.Click += new System.EventHandler(this.tHOÁTHỆTHỐNGToolStripMenuItem_Click);
            // 
            // đĂNGXUẤTToolStripMenuItem
            // 
            this.đĂNGXUẤTToolStripMenuItem.Name = "đĂNGXUẤTToolStripMenuItem";
            this.đĂNGXUẤTToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.đĂNGXUẤTToolStripMenuItem.Text = "ĐĂNG XUẤT";
            this.đĂNGXUẤTToolStripMenuItem.Click += new System.EventHandler(this.đĂNGXUẤTToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(272, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(726, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_TrangChu";
            this.Text = "Trang Chủ";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.IO.FileSystemWatcher fileSystemWatcher3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hỆTHỐNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHÔNGTINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHOÁTHỆTHỐNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝNHÂNSỰToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đĂNGXUẤTToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}