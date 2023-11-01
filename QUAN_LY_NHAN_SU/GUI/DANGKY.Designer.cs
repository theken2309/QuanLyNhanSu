namespace QUAN_LY_NHAN_SU.GUI
{
    partial class frm_DANGKY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DANGKY));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenDNDK = new System.Windows.Forms.TextBox();
            this.txt_MKDK = new System.Windows.Forms.TextBox();
            this.txt_NLMK = new System.Windows.Forms.TextBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Lại Mật Khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_TenDNDK
            // 
            this.txt_TenDNDK.Location = new System.Drawing.Point(410, 138);
            this.txt_TenDNDK.Name = "txt_TenDNDK";
            this.txt_TenDNDK.Size = new System.Drawing.Size(205, 22);
            this.txt_TenDNDK.TabIndex = 1;
            // 
            // txt_MKDK
            // 
            this.txt_MKDK.Location = new System.Drawing.Point(410, 191);
            this.txt_MKDK.Name = "txt_MKDK";
            this.txt_MKDK.Size = new System.Drawing.Size(205, 22);
            this.txt_MKDK.TabIndex = 1;
            this.txt_MKDK.TextChanged += new System.EventHandler(this.txt_MKDK_TextChanged);
            // 
            // txt_NLMK
            // 
            this.txt_NLMK.Location = new System.Drawing.Point(410, 248);
            this.txt_NLMK.Name = "txt_NLMK";
            this.txt_NLMK.Size = new System.Drawing.Size(205, 22);
            this.txt_NLMK.TabIndex = 1;
            this.txt_NLMK.TextChanged += new System.EventHandler(this.txt_NLMK_TextChanged);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_DangKy.Location = new System.Drawing.Point(193, 346);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(120, 51);
            this.btn_DangKy.TabIndex = 2;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(479, 346);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(122, 51);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_DANGKY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.txt_NLMK);
            this.Controls.Add(this.txt_MKDK);
            this.Controls.Add(this.txt_TenDNDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DANGKY";
            this.Text = "Đăng Ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_TenDNDK;
        public System.Windows.Forms.TextBox txt_MKDK;
        public System.Windows.Forms.TextBox txt_NLMK;
        public System.Windows.Forms.Button btn_DangKy;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Thoat;
    }
}