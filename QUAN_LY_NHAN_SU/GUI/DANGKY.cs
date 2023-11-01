using QUAN_LY_NHAN_SU.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_NHAN_SU.GUI
{
    public partial class frm_DANGKY : Form
    {
        public frm_DANGKY()
        {
             lopchung = new LopDungChung();
            InitializeComponent();
            bllDANGKY = new BLL.bllDANGKY(this);
        }
        LopDungChung lopchung;
        bllDANGKY bllDANGKY;

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {

            bllDANGKY.bllDangKy();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_MKDK_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_DangKy;
        }

        private void txt_NLMK_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_DangKy;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
            frm_DangNhap dn = new frm_DangNhap();
        }
    }
}
