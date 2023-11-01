using QUAN_LY_NHAN_SU.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_NHAN_SU.BLL
{
    internal class bllQuenMatKhau
    {
        DAL.DalQuenMatKhau dakQMK;
        QUENMK Qmk;
        LopDungChung lopchung;
        public bllQuenMatKhau(QUENMK fQmk)
        {
            dakQMK = new DAL.DalQuenMatKhau();
            lopchung = new LopDungChung();
            Qmk = fQmk;
        }
        public void bllQMK()
        {
            string sqlXacNhap = "update TAIKHOAN set MatKhau = '" + Qmk.txt_DLMK.Text + "' where TenDangNhap='" + Qmk.txt_tenDNQMK.Text + "' ";
            int kq = dakQMK.dalQMK(Qmk.txt_tenDNQMK.Text, Qmk.txt_DLMK.Text);
            if (kq == 0)
            {
                MessageBox.Show("Tên Tài Khoản Không Tồn Tại ! ");
            }
            else
            {
                lopchung.Nonquery(sqlXacNhap);
                
            }
        }
    }
}
