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
    public partial class QUENMK : Form
    {
        public QUENMK()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bllQuenMatKhau = new BLL.bllQuenMatKhau(this);
        }
        LopDungChung lopchung;
        BLL.bllQuenMatKhau bllQuenMatKhau;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QUENMK_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            bllQuenMatKhau.bllQMK();
        }

        private void txt_tenDNQMK_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_XacNhan;
        }

        private void txt_DLMK_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_XacNhan;

        }
    }
}
