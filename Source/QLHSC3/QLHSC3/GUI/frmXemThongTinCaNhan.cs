using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHSC3.BUS;
using QLHSC3.DTO;

namespace QLHSC3.GUI
{
    public partial class frmXemThongTinCaNhan : DevComponents.DotNetBar.Office2007Form
    {
        public frmXemThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void frmXemThongTinCaNhan_Load(object sender, EventArgs e)
        {
            HocSinhBUS adater = new HocSinhBUS();
            HocSinh HS = new HocSinh();
             HS = adater.getStudentIf_BUS2(BienToanCuc.CurrentUser.MaTaiKhoan);
            lbDiaChi.Text = HS.Diachi;
            lbEmail.Text = HS.Email;
            if (HS.GioiTinh == true)
            {
                lbGioiTinh.Text = "Nam";
            }
            else
            {
                lbGioiTinh.Text = "Nữ";
            }
            lbHoTen.Text = HS.HoTen;
            lbMaHS.Text = HS.MaHocSinh.ToString();
            lbNgaySinh.Text = HS.NgaySinh.Day.ToString() + "/" + HS.NgaySinh.Month.ToString() + "/" + HS.NgaySinh.Year.ToString();
        }
    }
}
