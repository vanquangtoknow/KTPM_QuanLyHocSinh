using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DAO;
using QLHSC3.DTO;

namespace QLHSC3.BUS
{
    class TaiKhoanBUS
    {
        private TaiKhoanDAO adapterDAO = new TaiKhoanDAO();
        public TaiKhoanDangNhap[] getAllUser_BUS()
        {
            return adapterDAO.getAllUser();
        }
    }
}
