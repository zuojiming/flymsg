using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.flymsg.com.context;
using System.Linq.Expressions;
using www.flymsg.com.Model;
using System.Data.SqlClient;
using System.Data;

namespace www.flymsg.com.bll
{
    public static class SampleCURDBLL<T> where T : class, new()
    {

        public static T Add(T m)
        {
            using (SiteGameEntities db = new SiteGameEntities())
            {
                m = db.Set<T>().Add(m); ;
                return m;
            }
        }

        public static int Update(T m, bool igoneEmpty = true)
        {
            var m_ = new T();
            int result = 0;
            foreach (var item in m_.GetType().GetProperties())
            {
                var cv = item.GetValue(m, null);
                if (cv != null && igoneEmpty && string.IsNullOrEmpty(cv.ToString()))
                    continue;
                if (item.PropertyType == typeof(DateTime) && Convert.ToDateTime(cv) == DateTime.MinValue)
                    cv = DateTime.Parse("2000-01-01");
                item.SetValue(m_, cv);
            }

            using (SiteGameEntities db = new SiteGameEntities())
            {
                db.Set<T>().Add(m);
                db.Entry<T>(m).State = System.Data.Entity.EntityState.Modified;
                db.Entry<T>(m).Reload();
                foreach (var item in m.GetType().GetProperties())
                {
                    item.SetValue(m, item.GetValue(m_), null);
                }
                result = db.SaveChanges();
            }
            return result;
        }

        public static int Delete(T m)
        {
            int result = 0;
            using (SiteGameEntities db = new SiteGameEntities())
            {
                db.Set<T>().Add(m);
                db.Entry<T>(m).State = System.Data.Entity.EntityState.Modified;
                db.Entry<T>(m).Reload();
                db.Set<T>().Remove(m);
                result = db.SaveChanges();
            }
            return result;
        }

        public static List<T> QueryByExp(Expression<Func<T, bool>> exp)
        {
            List<T> result = new List<T>();
            using (SiteGameEntities db = new SiteGameEntities())
            {
                result = db.Set<T>().Where(exp).ToList();
            }
            return result;
        }

        public static List<T> QueryByModel(PageSearcher seacher)
        {
            DataTable dt = GetSqlDataTable(seacher);
            List<T> result = new List<T>();
            foreach (var item in typeof(T).GetType().GetProperties())
            {
                if (!dt.Columns.Contains(item.Name))
                    continue;
                T im = new T();
                foreach (DataRow rowitem in dt.Rows)
                {
                    try
                    {
                        im.GetType().GetProperty(item.Name).SetValue(im, rowitem[item.Name]);
                    }
                    catch (Exception)
                    { }
                }
                result.Add(im);
            }

            return result;
        }

        public static T Find(Expression<Func<T, bool>> exp)
        {
            T m = new T();
            using (SiteGameEntities db = new SiteGameEntities())
            {
                m = db.Set<T>().FirstOrDefault<T>(exp);
            }
            return m;
        }

        public static T FindById(int Id)
        {
            T m = new T();
            using (SiteGameEntities db = new SiteGameEntities())
            {
                m = db.Set<T>().Find(Id);
            }
            return m;
        }

        public static T GetSqlModel<T1>(T1 m) where T1 : class, T, new()
        {
            T m1 = new T();
            foreach (var item in typeof(T).GetProperties())
            {
                item.SetValue(m, item.GetValue(m1));
            }
            return m1;
        }

        public static T1 GetPageModel<T1>(T m1) where T1 : class, T, new()
        {
            T1 m = new T1();
            foreach (var item in typeof(T).GetProperties())
            {
                item.SetValue(m1, item.GetValue(m));
            }
            return m;
        }

        private static DataTable GetSqlDataTable(PageSearcher searcher)
        {
            DataTable dt = new DataTable();
            string sqlstr = "select {0} from " + typeof(T).Name;
            string sqlcolumn = "row_number() over(order by id) sqlrowNum,*";
            string wherestr = "";
            foreach (var item in searcher.GetType().GetProperties().Where(w => w.Name.ToString() != "pagesize" && w.Name.ToString() != "pageindex"))
            {
                if (typeof(T).GetType().GetProperty(item.Name) == null)
                    continue;
                if (!string.IsNullOrEmpty(wherestr))
                    wherestr += " and ";
                wherestr += string.Format(" {0}='{1}' ", item.Name, item.GetValue(searcher));
            }
            using (SiteGameEntities db = new SiteGameEntities())
            {

                SqlConnection conn = new SqlConnection(db.Database.Connection.ConnectionString);
                SqlCommand command = conn.CreateCommand();
                command.CommandText = string.Format(sqlstr, "count(1)") + " where " + wherestr;
                command.CommandType = System.Data.CommandType.Text;
                searcher.RecordCount = Convert.ToInt32(command.ExecuteScalar());

                if (searcher.PageSize != 0)
                {
                    sqlstr = string.Format("select top {0} * from (" + string.Format(sqlstr, sqlcolumn) + "where" + wherestr + ") d where sqlrowNum>{1}", searcher.PageSize, (searcher.PageIndex - 1) * searcher.PageSize);
                }
                else
                {
                    sqlstr = string.Format(sqlstr, sqlcolumn) + "where" + wherestr;
                }

                command.CommandText = sqlstr;
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(dt);
            }
            return dt;
        }
    }
}
