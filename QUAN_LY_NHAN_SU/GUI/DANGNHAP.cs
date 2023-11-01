using QUAN_LY_NHAN_SU.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_NHAN_SU
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            lopchung = new LopDungChung();
            bllDN = new BLL.bllDANGNHAP(this);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
        BLL.bllDANGNHAP bllDN;
        LopDungChung lopchung;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            bllDN.bllDangNhap();
        }

        private void txt_tenDN_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_dangNhap;
        }

        private void txt_MK_TextChanged(object sender, EventArgs e)
        {
            AcceptButton=btn_dangNhap;
        }

        private void btn_dangKi_Click(object sender, EventArgs e)
        {
            frm_DANGKY dk = new frm_DANGKY();
            dk.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QUENMK qmk = new QUENMK();
            qmk.ShowDialog();
        }
    }
}
