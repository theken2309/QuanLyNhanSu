using QUAN_LY_NHAN_SU.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_NHAN_SU
{
    public partial class frm_NhanSu : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            loadGrid();
            loadcomboBoPhan();
        }
        BLL.bllNHANSU BllNhanSu;
        LopDungChung lopchung;
        public frm_NhanSu()
        {
            lopchung = new LopDungChung();
            InitializeComponent();
            BllNhanSu = new bllNHANSU(this);

        }
        public void loadGrid()
        {
            BllNhanSu.BllLoadData();
        }
        public void loadcomboBoPhan()
        {
           BllNhanSu.BllLoadCB();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            BllNhanSu.BllThem(this);
            //string SqlThem = " insert into NHANSU values ( '"+txt_maVN.Text+"','"+txt_hoTen.Text+ "'" +
            //    ",Convert(Datetime ,'" + dateTimePicker1.Text + "',103)" +
            //    ",'"+ cb_boPhan.SelectedValue+ "','"+txt_hinhAnh.Text+"' )";
            pictureBox1.Image.Save(duongdan + txt_hinhAnh.Text);
            //lopchung.Nonquery(SqlThem);
            loadGrid();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //string sqlSua = "Update NHANSU set HoTen=N'" + txt_hoTen.Text + "', NgayVaoLam =Convert(Datetime,'" + dateTimePicker1.Text + "', 103), MaBoPhan ='" + cb_boPhan.SelectedValue + "',HinhAnh ='"+txt_hinhAnh.Text+"' where MaNV = '" + txt_maVN.Text + "'";
            //lopchung.Nonquery(sqlSua); 
            BllNhanSu.BllSua(this);
            pictureBox1.Image.Save(duongdan + txt_hinhAnh.Text);
            loadGrid();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //string SqlXoa = " delete NHANSU where MaNV ='" + txt_maVN.Text + "' ";
            //lopchung.Nonquery(SqlXoa);
            BllNhanSu.BllXoa(this);
            File.Delete(duongdan + txt_hinhAnh.Text);
            loadGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maVN.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_hoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgayVaoLam"].Value.ToString();
            txt_hinhAnh.Text = dataGridView1.CurrentRow.Cells["HinhAnh"].Value.ToString();
            cb_boPhan.SelectedValue = dataGridView1.CurrentRow.Cells["MaBoPhan"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_hinhAnh.Text;
            loadGrid();

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            //string SqlTim = "select * from NHANSU where MaNV LIKE'%" + txt_timKiem.Text + "%' OR HoTen Like N'%" + txt_timKiem.Text + "%'";
            //dataGridView1.DataSource = lopchung.LoadData(SqlTim);
            BllNhanSu.BllTim(this);
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANHNHANVIEN\\";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "chon anh di ";
            OFD.Filter = "Tat ca duoi|*.*|JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }

        private void cb_boPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql_cbBoPhan = "select * from NHANSU where MaBoPhan='" + cb_boPhan.SelectedValue + "'";
            dataGridView1.DataSource = lopchung.LoadData(sql_cbBoPhan);
        }

        private void btn_taiLai_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
