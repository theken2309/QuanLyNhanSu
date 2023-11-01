using QUAN_LY_NHAN_SU.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_NHAN_SU.BLL
{
    internal class bllDANGNHAP
    {
        DAL.dalDANGNHAP dalDangNhap;
        frm_DangNhap DN;
        int dem = 0;
        public bllDANGNHAP(frm_DangNhap fDN) {
            dalDangNhap = new DAL.dalDANGNHAP();
            DN = fDN;
        }
        public void bllDangNhap()
        {
            int kq = dalDangNhap.dalDN(DN.txt_tenDN.Text, DN.txt_MK.Text);
            if (kq > 0)
            {
                MessageBox.Show("Đăng Nhập thành công");
               DN.Hide();
                frm_TrangChu frm_TrangChu = new frm_TrangChu();
                frm_TrangChu.Show();
                dem = 0;
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                dem++;
            }
            if (dem == 3)
            {
                MessageBox.Show("Nhập sai 3 lần, hệ thống thoát");
                DN.Close();
            }
        }
    }
}
