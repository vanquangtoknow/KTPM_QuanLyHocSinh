using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHSC3.DTO;
using QLHSC3.BUS;

namespace QLHSC3.GUI
{
    public partial class frmXemBangDiemCaNhan : DevComponents.DotNetBar.Office2007Form
    {
        bool flag = false;
        Diem[] diem;
        public frmXemBangDiemCaNhan()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXemBangDiemCaNhan_Load(object sender, EventArgs e)
        {
            HocKiBUS adapterHK = new HocKiBUS();

            if (flag == false)
            {
                combHocKi.DataSource = adapterHK.getAllHK_BUS();
                combHocKi.DisplayMember = "tenHocKi";
                combHocKi.Tag = adapterHK.getAllHK_BUS();               
                flag = true;
            }
            XL_Chon();
        }

        void XL_Chon()
        {
            if (flag == true)
            {
                DiemBUS adapterDiem = new DiemBUS();
                MonHocBUS adapterMH = new MonHocBUS();
                if (combHocKi.Text != "" && combHocKi.SelectedIndex >= 0)
                {
                    int chi_soHK = combHocKi.SelectedIndex;
                    HocKi KQHK;
                    if (chi_soHK >= 0 )
                    {
                        HocKi[] HK = (HocKi[])combHocKi.Tag;
                        KQHK = HK[chi_soHK];

                        MonHoc []Danh_sach_MH = adapterMH.getAllMH_BUS();
                        HocSinhBUS adater = new HocSinhBUS();
                        HocSinh HS = new HocSinh();
                        HS = adater.getStudentIf_BUS2(BienToanCuc.CurrentUser.MaTaiKhoan);
                        diem = adapterDiem.getMarkIf_BUS(HS.MaHocSinh,KQHK.MaHocKi);

                        DataTable dt = new DataTable();

                        dt.Columns.Add("tenMonHoc");
                        dt.Columns.Add("diem15Phut");
                        dt.Columns.Add("diem1Tiet");
                        dt.Columns.Add("diemHocKi");

                        for (int i = 0; i < Danh_sach_MH.Length; i++)
                        {
                            DataRow Dong = dt.NewRow();
                            dt.Rows.Add(Dong);
                            Dong["tenMonHoc"] = Danh_sach_MH[i].TenMonHoc;
                            Dong["diem15Phut"] = diem[i].Diem15Phut;
                            Dong["diem1Tiet"] = diem[i].Diem1Tiet;
                            Dong["diemHocKi"] = diem[i].DiemHocKi;
                        }
                        dgvBangDiem.DataSource = dt;
                    }

                }
            }
        }

        private void combHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            XL_Chon();
        }
    }
}
