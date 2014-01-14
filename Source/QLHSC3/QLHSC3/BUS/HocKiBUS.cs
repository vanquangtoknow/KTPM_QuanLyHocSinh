using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DTO;
using QLHSC3.DAO;

namespace QLHSC3.BUS
{
    class HocKiBUS
    {
        private HocKiDAO adapterDAO = new HocKiDAO();
        public HocKi[] getAllHK_BUS()
        {
            return adapterDAO.getAllHK();
        }
    }
}
