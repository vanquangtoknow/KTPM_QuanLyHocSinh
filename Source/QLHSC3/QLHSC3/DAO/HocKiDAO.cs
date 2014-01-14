﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLHSC3.DTO;
using System.Data;
using QLHSC3.Common;

namespace QLHSC3.DAO
{
    class HocKiDAO: DaoSupport
    {
        protected override object createObjectFromDatarow(DataRow row)
        {
            return new HocKi()
            {
                MaHocKi= Convert.ToInt32(row["maHocKi"].ToString()),
                TenHocKi = row["tenHocKi"].ToString()
            };
        }

        //private HocKi GetDataFromDataRow(DataTable dt, int i)
        //{
        //    HocKi HK = new HocKi();
        //    HK.MaHocKi = Convert.ToInt32(dt.Rows[i]["maHocKi"].ToString());
        //    HK.TenHocKi = dt.Rows[i]["tenHocKi"].ToString();
        //    return HK;
        //}

        public HocKi[] getAllHK()
        {
            string strSql = "SELECT * FROM HocKi";
            DataTable dt = DataProvider.executeQuery(strSql);
            return getListFromDataTable<HocKi>(dt);
            //int n = dt.Rows.Count;
            //HocKi[] allClass = new HocKi[n];
            //for (int i = 0; i < n; i++)
            //{
            //    //HocKi TK = GetDataFromDataRow(dt, i);
            //    HocKi TK = getListFromDataTable<TempCusDTO>(dt);(
            //    allClass[i] = TK;
            //}
            //return allClass;
        }
    }
}
