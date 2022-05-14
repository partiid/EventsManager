using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventsManager
{
    internal static class Utils
    {
        
        public static void SetProperty(this object obj, string propertyName, object value)
        {
            var propertyInfo = obj.GetType().GetProperty(propertyName);
            if (propertyInfo == null) return;
            
            propertyInfo.SetValue(obj, value);

        }

        public static T CastObject<T>(object input)
        {
            return (T)input; 
        }
       
      

        public static List<T> ToList<T>(this DataTable dt)
        {
            List<T> list = Activator.CreateInstance<List<T>>();
            T instance = Activator.CreateInstance<T>();
            var prop = instance.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            foreach (DataRow dr in dt.Rows)
            {
                T ins = Activator.CreateInstance<T>();
                foreach (var p in prop)
                {
                    try
                    {
                        p.SetValue(ins, dr[p.Name], null);
                    }
                    catch { }
                }
                list.Add(ins);
            }
            return list;
        }
        public static Object ToObject<T>(this DataTable dt)
        {
            T instance = Activator.CreateInstance<T>();
            var prop = instance.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
            foreach (DataRow dr in dt.Rows)
            { 
                foreach (var p in prop)
                {
                    try
                    {
                        p.SetValue(instance, dr[p.Name], null);
                    }
                    catch { }
                }
            }
            return instance; 
        }

        public static DataTable ToDataTable(object o)
        {
            DataTable dt = new DataTable("OutputData");

            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);

            o.GetType().GetProperties().ToList().ForEach(f =>
            {
                try
                {
                    f.GetValue(o, null);
                    dt.Columns.Add(f.Name, f.PropertyType);
                    dt.Rows[0][f.Name] = f.GetValue(o, null);
                }
                catch { }
            });
            return dt;
        }
    }
}
