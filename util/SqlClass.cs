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
        //按id查询图书
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
        //通用查询
        public DataSet Query(string sql)
        {

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
        //判断是否有库存查询到了返回true
        public bool IsInventory(string bookId)
        {
            string sql = "select * from BookInfo where BookID="+bookId+"and Number >0";
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
        //借阅卡是否可用
        public bool trueState(string certId)
        {
            string sql = "select * from CertificateInfo where Cert_id=" +certId+ "and flag=0 and times>0";
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
        //借阅卡是否为挂失状态
        public bool IsGua(string certId)
        {
            string sql = "select * from CertificateInfo where Cert_id=" + certId + "and flag=0";
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
        //借阅次数减一
        public int timesjian(string certId)
        {
            string sql = "UPDATE CertificateInfo set times = times-1 where Cert_ID=" + certId;
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
        //借阅次数加1
       
        public int timesjia(string certId)
        {
            string sql = "UPDATE CertificateInfo set times = times+1 where Cert_ID=" + certId;
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
        //库存减一被借阅次数加一
        public int kucunjian(string bookID)
        {
            string sql = "UPDATE BookInfo set Number = Number-1,Loantimes =Loantimes+1 WHERE BookID="+bookID;
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
        //库存加1
        public int kucunjia(string bookID)
        {
            string sql = "UPDATE BookInfo set Number = Number+1 WHERE BookID=" + bookID;
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
        //插入借书表中
        public int ExecuteLoan(string cert_id,string book_id)
        {
              string time= System.DateTime.Now.ToString("G");
           
            string sql = "insert into Loan(BookID,Cert_id,Loandates,flag)  values('"+book_id+"','"+cert_id+"','"+time+"',0)";
            
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
        //执行还书操作
        public int ExecuteReturn(string cert_id, string book_id)
        {
            string time = System.DateTime.Now.ToString("G");
            string sql = "UPDATE Loan set [Return]='" + time + "',flag=1 where BookID=" + book_id + " and Cert_id=" + cert_id + " and flag=0";
            
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
        //判断一个人是否重复借阅同一本数（注意：归还了之后可以再次借阅）
        public bool IsRepeatLoan(string certId,string bookId)
        {
            string sql = "select * from loan where BookID="+bookId+" and Cert_id="+certId+" and flag=0";
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
        //判断是否查询到了值
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
       
    }
   
   
}
