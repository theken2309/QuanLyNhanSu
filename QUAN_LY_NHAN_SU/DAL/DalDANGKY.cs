using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_NHAN_SU.DAL
{
    internal class DalDANGKY
    {
        LopDungChung lopcdunghung;
        public DalDANGKY()
        {
            lopcdunghung = new LopDungChung();
        }
        public int DalDangKy(String tenDangNhap)
        {
            string sqlKiemTra = "SELECT COUNT(*) FROM TAIKHOAN WHERE TenDangNhap = '" + tenDangNhap + "'";
            return (int)lopcdunghung.Scalar(sqlKiemTra);
        }
    }
}
