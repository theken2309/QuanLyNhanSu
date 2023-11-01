using QUAN_LY_NHAN_SU.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_NHAN_SU.BLL
{
    internal class bllDANGKY
    {
        LopDungChung lopchung;

        DAL.DalDANGKY dalDangKy;
        frm_DANGKY DK;
        public bllDANGKY(frm_DANGKY fDK)
        {   lopchung = new LopDungChung();
            dalDangKy = new DAL.DalDANGKY();
            DK = fDK;
        }
        public void bllDangKy()
        {
            int kq = dalDangKy.DalDangKy(DK.txt_TenDNDK.Text);
            if (kq > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
            }
            else
            {
                if (DK.txt_MKDK.Text == DK.txt_NLMK.Text)
                {
                    string sqlDK = "INSERT INTO TAIKHOAN (TenDangNhap, MatKhau) VALUES ('" + DK.txt_TenDNDK.Text + "','" + DK.txt_MKDK.Text + "')";
                    lopchung.Nonquery(sqlDK);
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không trùng khớp!");
                }
            }
        }
    }
}
