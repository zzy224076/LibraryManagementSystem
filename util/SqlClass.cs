using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    class SqlClass
    {
        //创建连接对象的变量
        public SqlConnection conn;
        SqlDao sqlDao = new SqlDao();
        //执行对数据表中数据的增加、删除、修改操作
        public int NonQuery(String sql)
        {
            conn = sqlDao.getConn();
            int a = -1;
            try
            {
                conn.Open(); //打开数据库
                SqlCommand cmd = new SqlCommand(sql, conn);
                a = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();//关闭数据库                    
                }
            }

            return a;
        }
        public DataSet QueryById(string bookID)
        {
            string sql = "select * from BookInfo where BookID=" + bookID;
            conn = sqlDao.getConn();
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return ds;
        }
        //管理员登录
        public bool Login(string username,string password)
        {
            string sql = "select * from admin where username='" +username+"'and password='"+password+"'";
            conn = sqlDao.getConn();
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return !IsNull(ds);
        }
        //按书名查询
        public DataSet QueryByTitle(string title)
        {
            string sql = "select * from BookInfo where Title='"+title+"'";
            conn = sqlDao.getConn();
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return ds;
        }

        public Boolean IsNull(DataSet dataSet)
        {
            foreach (DataRow mDr in dataSet.Tables[0].Rows)
            {
                foreach (DataColumn mDc in dataSet.Tables[0].Columns)
                {

                    if (mDr[mDc].ToString() != null)
                    {
                        return false;
                    }
                    break;
                }
            }
            return true;
        }
        //判断主键是否重复

        public bool IsRepeat(string tableName,string keyName, int id)
        {
            string sql = "select * from "+tableName+" where "+keyName+"="+id;
            
            conn = sqlDao.getConn();
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return !IsNull(ds);
        }
        //判断是否已被借出
        public bool IsLoan(string id)
        {
            string sql = "select * from BookInfo where BookID ="+id+" and flag=1";

            conn = sqlDao.getConn();
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return IsNull(ds);
        }
    }
   
   
}
