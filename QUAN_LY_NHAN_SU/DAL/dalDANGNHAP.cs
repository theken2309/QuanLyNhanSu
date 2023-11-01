using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_NHAN_SU.DAL
{
    internal class dalDANGNHAP
    {
        LopDungChung lopcdunghung;
        public dalDANGNHAP()
        {
            lopcdunghung = new LopDungChung();
        }
        public int dalDN(string tenDN, string MatKhau)
        {
            string sqlDN = "select count (*) from TAIKHOAN where TenDangNhap = '" + tenDN + "' and MatKhau = '" + MatKhau + "'";
            return (int)lopcdunghung.Scalar(sqlDN);
        }
    }
}
