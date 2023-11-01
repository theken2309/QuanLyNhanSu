using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_NHAN_SU.DAL
{
    internal class DalQuenMatKhau
    {
        LopDungChung lopcdung;
        public DalQuenMatKhau()
        {
            lopcdung = new LopDungChung();
        }

        public int dalQMK(string tenDNQMK,string MKQ)
        {
        
        string check = "select count (TenDangNhap) from TAIKHOAN where TenDangNhap = '" + tenDNQMK + "'";
        return  (int)lopcdung.Scalar(check);
        }
    }
}
