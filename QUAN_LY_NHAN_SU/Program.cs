using QUAN_LY_NHAN_SU.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_NHAN_SU
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_NhanSu());
            Application.Run(new frm_DangNhap());
            //Application.Run(new QUANLY());
            //Application.Run(new frm_TrangChu());
            //Application.Run(new QUENMK());/

        }
    }
}
