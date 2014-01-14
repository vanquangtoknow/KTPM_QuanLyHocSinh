using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DAO;
using QLHSC3.DTO;

namespace QLHSC3.BUS
{
    class MonHocBUS
    {
        private MonHocDAO adapterDAO = new MonHocDAO();
        public MonHoc[] getAllMH_BUS()
        {
            return adapterDAO.getAllMH();
        }
    }
}
