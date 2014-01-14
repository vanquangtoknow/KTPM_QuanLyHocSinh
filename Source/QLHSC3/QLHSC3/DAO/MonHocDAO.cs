using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DTO;
using System.Data;
using QLHSC3.Common;

namespace QLHSC3.DAO
{
    class MonHocDAO: DaoSupport
    {
        //private MonHoc GetDataFromDataRow(DataTable dt, int i)
        //{
        //    MonHoc HK = new MonHoc();
        //    HK.MaMonHoc=Convert.ToInt32(dt.Rows[i]["maMonHoc"].ToString());
        //    HK.TenMonHoc = dt.Rows[i]["tenMonHoc"].ToString();
        //    return HK;
        //}
        protected override object createObjectFromDatarow(DataRow row)
        {
            //throw new NotImplementedException();
            MonHoc HK = new MonHoc();
            HK.MaMonHoc = Convert.ToInt32(row["maMonHoc"].ToString());
            HK.TenMonHoc = row["tenMonHoc"].ToString();
            return HK;
        }
        public MonHoc[] getAllMH()
        {
            string strSql = "SELECT * FROM MonHoc";
            DataTable dt = DataProvider.executeQuery(strSql);
            return getListFromDataTable<MonHoc>(dt);
            //int n = dt.Rows.Count;
            //MonHoc[] allClass = new MonHoc[n];
            //for (int i = 0; i < n; i++)
            //{
            //    MonHoc TK = GetDataFromDataRow(dt, i);
            //    allClass[i] = TK;
            //}
            //return allClass;
        }
    }
}
