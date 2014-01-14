using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DAO;
using QLHSC3.DTO;

namespace QLHSC3.BUS
{
    class QuyDinhBUS
    {
        private QuyDinhDAO adapterDAO = new QuyDinhDAO();
        public bool ThemQuyDinh_BUS(string tenQD, string noiDungQD)
        {
            return adapterDAO.ThemQuyDinh(tenQD, noiDungQD);
        }
        public bool ThayDoiQuyDinh_BUS(QuyDinh quyDinh)
        {
            return adapterDAO.ThayDoiQuyDinh(quyDinh);
        }
        public QuyDinh[] getAllQuyDinh_BUS()
        {
            return adapterDAO.getAllQuyDinh();
        }

        public bool XoaQuyDinh_BUS(QuyDinh quyDinh)
        {
            return adapterDAO.XoaQuyDinh(quyDinh);
        }
    }
}
