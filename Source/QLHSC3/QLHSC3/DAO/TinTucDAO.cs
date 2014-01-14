using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DTO;
using System.Data;
using QLHSC3.Common;

namespace QLHSC3.DAO
{
    class TinTucDAO:DaoSupport
    {
        ////private ThongBao GetDataFromDataRow(DataTable dt, int i)
        ////{
        ////    ThongBao TB = new ThongBao();
        ////    TB.MaThongBao = Convert.ToInt32(dt.Rows[i]["maThongBao"].ToString());
        ////    TB.TenThongBao = dt.Rows[i]["tenThongBao"].ToString();
        ////    TB.NoiDungThongBao = dt.Rows[i]["noiDungThongBao"].ToString();
        ////    return TB;
        ////}
        protected override object createObjectFromDatarow(DataRow row)
        {
            ThongBao TB = new ThongBao();
            TB.MaThongBao = Convert.ToInt32(row["maThongBao"].ToString());
            TB.TenThongBao = row["tenThongBao"].ToString();
            TB.NoiDungThongBao = row["noiDungThongBao"].ToString();
            return TB;
        }

        public ThongBao[] getAllNews()
        {
            string strSql = "SELECT * FROM ThongBao";
            DataTable dt = DataProvider.executeQuery(strSql);
            return getListFromDataTable<ThongBao>(dt);
            //int n = dt.Rows.Count;
            //ThongBao[] allNews = new ThongBao[n];
            //for (int i = 0; i < n; i++)
            //{
            //    ThongBao TB = GetDataFromDataRow(dt, i);
            //    allNews[i] = TB;
            //}
            //return allNews;
        }
    }
}
