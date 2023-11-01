using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_NHAN_SU
{
    internal class LopDungChung
    {
        string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\laptrinhungdung_cs464\QuanLyNhanSu\QUAN_LY_NHAN_SU\SQL_QLNS.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(ketnoi);
        }
        public DataTable LoadData(String SqlLoadData)
        {
            SqlCommand comm = new SqlCommand(SqlLoadData, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Nonquery(String sqlNon)
        {
            SqlConnection conn = new SqlConnection(ketnoi);
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            try
            {
                int kq;
                kq = comm.ExecuteNonQuery();
                if (kq >= 1)
                    MessageBox.Show(" Thành Công");
                else MessageBox.Show(" Thất Bại ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Mã hoặc lỗi SQL");
            }
            //comm.ExecuteNonQuery();
            conn.Close();
        }
        public object Scalar(String sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int ketqua;
            ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }

    }
}
