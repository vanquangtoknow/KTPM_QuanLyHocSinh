using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DAO;
using QLHSC3.DTO;

namespace QLHSC3.BUS
{
    class BangDiemMonBUS
    {
        private BangDiemMonDAO adapterDAO = new BangDiemMonDAO();
        public bool InsertMarkTable_BUS(int maHS, int maDiem, int maMH, int maHK)
        {
            return adapterDAO.InsertMarkTable(maHS,maDiem,maMH,maHK);
        }
    }
}
