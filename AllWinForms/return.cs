using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.AllWinForms
{
    public partial class Form_return : Form
    {
        public Form_return()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {   

            string bookId = textBox_book_id.Text;
            SqlClass sqlClass = new SqlClass();
            //获取借该图书的借阅证类型
            DataSet ds = sqlClass.Query("SELECT type from loan,CertificateInfo where Loan.Cert_id = CertificateInfo.Cert_id and Loan.BookID="+bookId+"and Loan.flag=0");
            String type=(string) ds.Tables[0].Rows[0][0];
            
            if (type=="教师")
            {
                DataSet dataSet = sqlClass.Query("select maxDate_tea from settings");
                int maxDate_tea= (int) dataSet.Tables[0].Rows[0][0];
                DataSet dataSet1= sqlClass.Query("SELECT DATEDIFF(DAY, Loandates, GETDATE()) from Loan WHERE BookID =" + bookId+"and flag =0");
                int loanDays = (int)dataSet1.Tables[0].Rows[0][0];
                int date = maxDate_tea - loanDays;
                
                if (date>=0)
                {
                    sqlClass.ExecuteReturn( bookId);
                    MessageBox.Show("归还成功！！！");
                    this.Form_return_Load(null, null);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("该用户已逾期" + -date + "天，应收取" + -date + "元罚款！（用户交过罚款再点击确定）", "罚款（1元/天）", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        sqlClass.ExecuteReturn(bookId);
                        MessageBox.Show("归还成功！！！");
                        this.Form_return_Load(null, null);
                    }

                }
            }else if (type == "学生")
            {
                DataSet dataSet = sqlClass.Query("select maxDate_stu from settings");
                int maxDate_tea = (int)dataSet.Tables[0].Rows[0][0];
                DataSet dataSet1 = sqlClass.Query("SELECT DATEDIFF(DAY, Loandates, GETDATE()) from Loan WHERE BookID =" + bookId+"and flag=0");
                int loanDays = (int)dataSet1.Tables[0].Rows[0][0];
                
                int date = maxDate_tea - loanDays;
                if (date >= 0)
                {
                    sqlClass.ExecuteReturn(bookId);
                    MessageBox.Show("归还成功！！！");
                    this.Form_return_Load(null, null);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("该用户已逾期" + -date + "天，应收取" + -date + "元罚款！（用户交过罚款再点击确定）", "罚款（1元/天）", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        sqlClass.ExecuteReturn(bookId);
                        MessageBox.Show("归还成功！！！");
                        this.Form_return_Load(null, null);
                    }

                }
            }
           
        }

        private void Form_return_Load(object sender, EventArgs e)
        {
            SqlClass sqlClass = new SqlClass();
            DataSet ds =sqlClass.Query("select * from Loan where flag=0");
            dataGridView1.Rows.Clear();
            foreach (DataRow mDr in ds.Tables[0].Rows)
            {
                
                //获取该借阅证的类型
                DataSet ds1 = sqlClass.Query("SELECT type from loan,CertificateInfo where Loan.Cert_id = CertificateInfo.Cert_id and Loan.BookID=" + mDr[0] + "and Loan.flag=0");
                String type = (string)ds1.Tables[0].Rows[0][0];
                if (type == "教师")
                {
                    DataSet dataSet = sqlClass.Query("select maxDate_tea from settings");
                    int maxDate_tea = (int)dataSet.Tables[0].Rows[0][0];
                    DataSet dataSet1 = sqlClass.Query("SELECT DATEDIFF(DAY, Loandates, GETDATE()) from Loan WHERE BookID =" + mDr[0] + "and flag=0");
                    int loanDays = (int)dataSet1.Tables[0].Rows[0][0];

                    int date = maxDate_tea - loanDays;
                    if (date >= 0)
                    {
                        dataGridView1.Rows.Add(mDr[0], mDr[1], mDr[2],"否");


                    }
                    else
                    {
                        dataGridView1.Rows.Add(mDr[0], mDr[1], mDr[2], "是",-date);

                    }
                }
                else if (type == "学生")
                {
                    DataSet dataSet = sqlClass.Query("select maxDate_stu from settings");
                    int maxDate_tea = (int)dataSet.Tables[0].Rows[0][0];
                    DataSet dataSet1 = sqlClass.Query("SELECT DATEDIFF(DAY, Loandates, GETDATE()) from Loan WHERE BookID =" + mDr[0] + "and flag=0");
                    int loanDays = (int)dataSet1.Tables[0].Rows[0][0];

                    int date = maxDate_tea - loanDays;
                    if (date >= 0)
                    {
                        dataGridView1.Rows.Add(mDr[0], mDr[1], mDr[2], "否");
                    }
                    else
                    {
                        dataGridView1.Rows.Add(mDr[0], mDr[1], mDr[2], "是",-date);

                    }
                }

            }
        }
    }
}
