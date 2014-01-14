using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QLHSC3.DAO
{
    public abstract class DaoSupport
    {
        protected abstract object createObjectFromDatarow(DataRow row);

        //protected List<T> getListFromDataTable<T>(DataTable dt)
        //{
        //    List<T> list = new List<T>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        T t = (T)createObjectFromDatarow(dt.Rows[i]);
        //        list.Add(t);
        //    }
        //    return list;
        //}
        protected T[] getListFromDataTable<T>(DataTable dt)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                T t = (T)createObjectFromDatarow(dt.Rows[i]);
                list.Add(t);
            }
            return list.ToArray();
        }
        //protected abstract object[] getAll();

    }
}
