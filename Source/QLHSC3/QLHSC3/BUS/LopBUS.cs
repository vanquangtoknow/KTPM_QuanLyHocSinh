using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DAO;
using QLHSC3.DTO;

namespace QLHSC3.BUS
{
    public class LopBUS
    {
        private LopDAO lopDAO = new LopDAO();
        public Lop[] layDanhSachLop_BUS()
        {
            return lopDAO.layDanhSachLop_DAO();
        }
        public string layTenGiaoVien_Tu_MaLop_BUS(int maLop)
        {
            return lopDAO.layTenGiaoVien_Tu_MaLop_DAO(maLop);
        }
        public string layTenLop_Tu_MaLop_BUS(int maLop)
        {
            return lopDAO.layTenLop_Tu_MaLop_DAO(maLop);
        }

        public Lop[] getAllClass_BUS()
        {
            return lopDAO.getAllClass();
        }
         public int soLuongDat(int maMonHoc, int maHocKi, int maLop)
         {
             return lopDAO.soLuongDat(maMonHoc,maHocKi,maLop);
         }
         public int soLuongDatHocKi(int maHocKi, int maLop)
         {
             return lopDAO.soLuongDatHocKi(maHocKi, maLop);
         }
    }
}
