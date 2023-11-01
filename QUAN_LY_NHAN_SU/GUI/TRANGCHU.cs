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
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        { 
            InitializeComponent();
        }
        private void tHÔNGTINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frm_THONGTIN thontin = new frm_THONGTIN();
            thontin.ShowDialog();
            Show();
        }
        private void tHOÁTHỆTHỐNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void qUẢNLÝNHÂNSỰToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frm_NhanSu NV = new frm_NhanSu();
            NV.ShowDialog();
            Show();
        }
        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frm_DangNhap dn = new frm_DangNhap();
            dn.ShowDialog(); 
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
       

        
    }
}
