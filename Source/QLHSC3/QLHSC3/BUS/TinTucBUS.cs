using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DTO;
using QLHSC3.DAO;

namespace QLHSC3.BUS
{
    class TinTucBUS
    {
        private TinTucDAO adapterDAO = new TinTucDAO();
        public ThongBao[] getAllNews_BUS()
        {
            return adapterDAO.getAllNews();
        }
    }
}
