using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class loan : Form
    {
        
       
      
        public loan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cert_id = textBox_cert_id.Text;
            string book_id = textBox_book_id.Text;
            SqlClass sqlClass = new SqlClass();
            if (cert_id!=""&&book_id!="")
            {
                 DataSet ds1=sqlClass.Query("select * from CertificateInfo where Cert_id="+cert_id);
                 DataSet ds2 = sqlClass.Query("select * from BookInfo where BookID=" + book_id);
                if (!sqlClass.IsNull(ds1))
                {
                    if (!sqlClass.IsNull(ds2))
                    {
                        if (sqlClass.IsStuCert(cert_id))
                        {
                            DataSet ds = sqlClass.Query("select count(*) from Loan where flag=0 and cert_id=" + cert_id);
                            int loanNum = (int)ds.Tables[0].Rows[0][0];
                            DataSet ds3 = sqlClass.Query("select loanNum_stu from settings");
                            int loanNum_tea = (int)ds3.Tables[0].Rows[0][0];
                            if (loanNum < loanNum_tea)
                            {
                                sqlClass.ExecuteLoan(cert_id, book_id);
                                sqlClass.timejia(book_id);
                                MessageBox.Show("借书成功!");
                            }
                            else
                            {
                                MessageBox.Show("该用户可借本数不足，借书失败！");
                            }
                        }
                        else
                        {
                            DataSet ds = sqlClass.Query("select count(*) from Loan where flag=0 and cert_id=" + cert_id);
                            int loanNum = (int)ds.Tables[0].Rows[0][0];
                            DataSet ds4 = sqlClass.Query("select loanNum_tea from settings");
                            int loanNum_tea = (int)ds4.Tables[0].Rows[0][0];
                            if (loanNum < loanNum_tea)
                            {
                                sqlClass.ExecuteLoan(cert_id, book_id);
                                sqlClass.timejia(book_id);
                                MessageBox.Show("借书成功!");
                            }
                            else
                            {
                                MessageBox.Show("该用户可借本数不足，借书失败！");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("该图书不存在，请重新输入！");
                    }
                    
                }
                else
                {
                    MessageBox.Show("该借阅卡不存在，请重新输入！");
                }
                
            }
            else
            {
                MessageBox.Show("请将信息填写完整！");
            }
            


        }

        private void textBox_book_id_TextChanged(object sender, EventArgs e)
        {

           
            
        }

        private void textBox_book_id_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cert_id_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }
    }
}
