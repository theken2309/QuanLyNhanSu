using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_NHAN_SU.DAL
{
    internal class dalNHANSU
    {
        LopDungChung lopchung;
        public dalNHANSU() { 
        lopchung = new LopDungChung();
        }
        public DataTable DalLoadData()
        {
            String sqlData = " select * from NHANSU ";
            return lopchung.LoadData(sqlData);
        }
        public DataTable DalLoadComBo() {

            string sqlLoadcombo = "select * from BOPHAN";
            return lopchung.LoadData(sqlLoadcombo); ;
        }
        public void DalThem(String maNv,String hoTen,DateTime ngayVaoLam ,string maBoPhan,string tenHinhAnh)
        {//string SqlThem = " insert into NHANSU values ( '"+txt_maVN.Text+"','"+txt_hoTen.Text+ "'" +
            //    ",Convert(Datetime ,'" + dateTimePicker1.Text + "',103)" +
            //    ",'"+ cb_boPhan.SelectedValue+ "','"+txt_hinhAnh.Text+"' )";
            string SqlThem = " insert into NHANSU values ( '" + maNv + "',N'" + hoTen + "'" +
                ",Convert(DATETIME ,'" + ngayVaoLam + "',101)" +
                ",'" + maBoPhan + "','" + tenHinhAnh + "' )";
            lopchung.Nonquery(SqlThem);
        }
        public void DalSua(String hoTen, DateTime ngayVaoLam, String maBoPhan,String tenHinhAnh,String MaNV)
        {
            //string sqlSua = "Update NHANSU set HoTen=N'" + txt_hoTen.Text + "', NgayVaoLam =Convert(Datetime,'" + dateTimePicker1.Text + "', 103), MaBoPhan ='" + cb_boPhan.SelectedValue + "',HinhAnh ='" + txt_hinhAnh.Text + "' where MaNV = '" + txt_maVN.Text + "'";
            //lopchung.Nonquery(sqlSua);
        string sqlSua = "Update NHANSU set HoTen=N'" + hoTen + "', NgayVaoLam =Convert(DATETIME,'" 
                + ngayVaoLam + "', 101), MaBoPhan ='" +maBoPhan + "', HinhAnh ='"+tenHinhAnh+"' where MaNV = '" + MaNV + "'";
        lopchung.Nonquery(sqlSua); 
        }
        public void DalXoa(String maNV)
        {
            string SqlXoa = " delete NHANSU where MaNV ='" + maNV + "' ";
            lopchung.Nonquery(SqlXoa);
        }
        public DataTable DalTim(String timKiem)
        {
            string SqlTim = "select * from NHANSU where MaNV LIKE'%" + timKiem + "%' OR HoTen Like N'%" + timKiem + "%'";
           return  lopchung.LoadData(SqlTim);
        }
    }
}
