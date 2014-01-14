using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHSC3.DAO;
using QLHSC3.DTO;

namespace QLHSC3.GUI
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        ThongBao[] listThongBao;
        public frmMain()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbGioiThieu.Text = " Trường THPT Hai Bà Trưng (thành phố Huế) là một trong những\n"
                + " ngôi trường lớn ở miền Trung và trên toàn quốc. Được thành lập\n"
                + " ngày 15 tháng 7 năm 1917, lúc đó trường mang tên Đồng Khánh.\n"
                + " Trải qua bao thăng trầm của lịch sử, trường được mang nhiều tên \n"
                + " gọi khác nhau. Từ 1919 đến 1954, trường mang tên Cao đẳng\n"
                + " tiểu học Đồng Khánh. Từ 1955 đến 1975, trường mang tên\n"
                + " trường Nữ trung học Đồng Khánh gồm hai cấp: Đệ Nhất cấp  \n"
                + " và Đệ Nhị cấp. Sau ngày thống nhất đất nước, trường được mang tên  \n"
                + " Trường cấp III Trưng Trắc. Từ năm 1981 đến nay, trường được \n"
                + " đổi tên thành Trường THPT Hai Bà Trưng.  \n";

            lbGioiThieu2.Text = "Trong suốt khoảng thời gian từ khi thành lập đến 1975, đây là ngôi trường nữ duy nhất ở miền \n"
                + "Trung dạy đủ các môn: Văn, thể, mỹ và lao động kỹ thuật. Ngoài việc học văn hóa và nữ công \n"
                + "gia chánh (may vá, thêu thùa, làm bánh, làm mứt...), nữ sinh Đồng Khánh còn được học cách \n"
                + "nuôi con, cách quản lý gia đình, được rèn luyện phong cách người con gái có học thức,  \n"
                + "có giáo dục, giản dị, trang nhã, lịch sự, khiêm tốn, tế nhị trong giao tiếp và một số  \n  "
                + "môn học cơ bản về cứu thương.";

            lbGioiThieu3.Text = "- Những phần thưởng cao quý được đón nhận:\n"
                + "+ Chủ tịch nước CHXHCN Việt Nam tặng Huân chương lao động hạng III.\n"
                + "+ Bộ giáo dục tặng bằng khen đơn vị xuất sắc trong phong trào thi đua yêu nước \n"
                + "ngành Giáo dục (Trong Hội nghị tổng kết thi đua 5 năm của ngành, từ 2001 đến 2005).\n"
                + "+ UBND Tỉnh Thừa Thiên Huế tặng cờ 'Đơn vị thi đua xuất sắc'.\n"
                + "+ Chi bộ Đảng nhà trường được Đảng bộ Thành phố Huế tặng giấy khen và công \n"
                + "nhận 'Chi bộ trong sạch vững mạnh'.\n"
                + "Liên tục các năm, từ 2000 - 2001 đến 2004 - 2005, trường đạt danh hiệu Trường \n"
                + "tiên tiến xuất sắc cấp Tỉnh.";

            ribAo.Visible = false;
            switch (BienToanCuc.loai_nguoi_dung)
            {
                case 1:// giao vu
                    ribbonHS.Visible = false;
                    ribbonBGH.Visible = false;
                    ribbonGV.Visible = false;
                    ribbonGVu.Visible = true;
                    break;
                case 2:// giao vien
                    ribbonHS.Visible = false;
                    ribbonBGH.Visible = false;
                    ribbonGV.Visible = true;
                    ribbonGVu.Visible = false;
                    break;
                case 3: // hoc sinh
                    ribbonHS.Visible = true;
                    ribbonBGH.Visible = false;
                    ribbonGV.Visible = false;
                    ribbonGVu.Visible = false;
                    break;
                case 4:// ban giam hieu
                    ribbonHS.Visible = false;
                    ribbonBGH.Visible = true;
                    ribbonGV.Visible = false;
                    ribbonGVu.Visible = false;
                    break;
            }
           
        }
        #region Các chức năng của giáo vụ
        private void btnThayDHSHS_GV_Click(object sender, EventArgs e)
        {
            frmTiepNhanHocSinh frmtiepnhanhocsinh_gv = new frmTiepNhanHocSinh();
            frmtiepnhanhocsinh_gv.ShowDialog();
        }

        private void btnThayDDSL_GVu_Click_1(object sender, EventArgs e)
        {
            frmLapDanhSachLop frmlapdanhsachlop = new frmLapDanhSachLop();
            frmlapdanhsachlop.ShowDialog();
        }
        private void btnThayDBD_GVu_Click(object sender, EventArgs e)
        {
            frmThayDoiBangDiem frmThayDoiBangDiem = new frmThayDoiBangDiem();
            frmThayDoiBangDiem.ShowDialog();
        }
        private void btnLapTB_GVu_Click(object sender, EventArgs e)
        {
            frmLapThongBao frmlapthongbao = new frmLapThongBao();
            frmlapthongbao.ShowDialog();
        }
        private void btnXemTB_GVu_Click(object sender, EventArgs e)
        {
            frmXemThongBao frmxemthongbao = new frmXemThongBao();
            frmxemthongbao.ShowDialog();
        }
        private void btnLapBCTKM_GVu_Click(object sender, EventArgs e)
        {
            frmBaoCaoTongKetMon frm = new frmBaoCaoTongKetMon();
            frm.ShowDialog();
        }
        private void btnLapBCTKHK_GVu_Click(object sender, EventArgs e)
        {
            frmBaoCaoTongKetHocKi frm = new frmBaoCaoTongKetHocKi();
            frm.ShowDialog();
        }
        private void btnLapTKB_GVu_Click(object sender, EventArgs e)
        {
            frmLapThoiKhoaBieu frmlapthoikhoabieu = new frmLapThoiKhoaBieu();
            frmlapthoikhoabieu.ShowDialog();
        }
        private void btnXemTKB_GVu_Click(object sender, EventArgs e)
        {
            frmXemThoiKhoaBieu frmxemthoikhoabieu = new frmXemThoiKhoaBieu();
            frmxemthoikhoabieu.ShowDialog();
        }
        private void btbTraCHS_GVu_Click(object sender, EventArgs e)
        {
            frmTraCuuHocSinh frmtracuu_hs = new frmTraCuuHocSinh();
            frmtracuu_hs.ShowDialog();
        }
        private void btnXemBD_GVu_Click(object sender, EventArgs e)
        {

        }
#endregion
        #region Các chức năng của học sinh
        private void btnXemD_HSinh_Click(object sender, EventArgs e)
        {
            frmXemBangDiemCaNhan frm = new frmXemBangDiemCaNhan();
            frm.ShowDialog();
        }
        private void btnXemTTCN_HSinh_Click(object sender, EventArgs e)
        {
            frmXemThongTinCaNhan frm = new frmXemThongTinCaNhan();
            frm.ShowDialog();
        }
        private void btnXemTB_HSinh_Click(object sender, EventArgs e)
        {
            frmXemThongBao frmxemthongbao_hs = new frmXemThongBao();
            frmxemthongbao_hs.ShowDialog();
        }
        private void btnXemTKB_HSinh_Click(object sender, EventArgs e)
        {
            frmXemThoiKhoaBieu frmxemthoikhoabieu_hs = new frmXemThoiKhoaBieu();
            frmxemthoikhoabieu_hs.ShowDialog();
        }
        #endregion
        #region Các chức năng của giáo viên
        private void btnThayDBD_GVien_Click(object sender, EventArgs e)
        {
            frmThayDoiBangDiem frmThayDoiBangDiem = new frmThayDoiBangDiem();
            frmThayDoiBangDiem.ShowDialog();
        }
        private void btnTraCuu_GVien_Click(object sender, EventArgs e)
        {
            frmTraCuuHocSinh frmtracuu_hs = new frmTraCuuHocSinh();
            frmtracuu_hs.ShowDialog();
        }
        
        #endregion
        #region Các chức năng của ban giám hiệu
        private void btnXemBCTKHK_BGHieu_Click(object sender, EventArgs e)
        {
            frmBaoCaoTongKetHocKi frm = new frmBaoCaoTongKetHocKi();
            frm.ShowDialog();
        }
        private void btnXemBCTKM_BGHieu_Click(object sender, EventArgs e)
        {
            frmBaoCaoTongKetMon frm = new frmBaoCaoTongKetMon();
            frm.ShowDialog();
        }
        #endregion

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            frmThayDoiQuyDinh frm = new frmThayDoiQuyDinh();
            frm.ShowDialog();
        }


    }
}
