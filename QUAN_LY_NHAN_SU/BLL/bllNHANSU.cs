using QUAN_LY_NHAN_SU.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_NHAN_SU.BLL
{
    internal class bllNHANSU
    {
        dalNHANSU DalNhanSu;
        frm_NhanSu NS;
        public bllNHANSU(frm_NhanSu fNS) {
            DalNhanSu = new DAL.dalNHANSU();
            NS = fNS;
        }
        public void BllLoadData()
        {
            NS.dataGridView1.DataSource = DalNhanSu.DalLoadData();
        }
        public void BllLoadCB()
        {
            NS.cb_boPhan.DataSource = DalNhanSu.DalLoadComBo();
            NS.cb_boPhan.DisplayMember = "TenBoPhan";
            NS.cb_boPhan.ValueMember = "MaBoPhan";
        }
        public void BllThem(frm_NhanSu NS)
        {
            DalNhanSu.DalThem(NS.txt_maVN.Text, NS.txt_hoTen.Text, NS.dateTimePicker1.Value, NS.cb_boPhan.SelectedValue.ToString(), NS.txt_hinhAnh.Text);
        }
        public void BllSua(frm_NhanSu NS)
        {
            DalNhanSu.DalSua(NS.txt_hoTen.Text, NS.dateTimePicker1.Value, NS.cb_boPhan.SelectedValue.ToString(), NS.txt_hinhAnh.Text, NS.txt_maVN.Text);
        }
        public void BllXoa(frm_NhanSu NS)
        {
            DalNhanSu.DalXoa(NS.txt_maVN.Text);
        }
        public void BllTim(frm_NhanSu NS)
        {
            NS.dataGridView1.DataSource = DalNhanSu.DalTim(NS.txt_timKiem.Text);
        }
    }
}
