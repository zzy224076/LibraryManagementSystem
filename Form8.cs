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
    public partial class Form8 : Form
    {
        public Form8()
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
                if (sqlClass.trueState(cert_id))
                {
                    
                    if (sqlClass.IsInventory(book_id))
                    {
                        if (sqlClass.IsRepeatLoan(cert_id, book_id))
                        {
                            MessageBox.Show("该用户正在借阅该图书，请归还后再次借阅");
                        }
                        else
                        {
                        sqlClass.kucunjian(book_id);
                        sqlClass.timesjian(cert_id);
                        sqlClass.ExecuteLoan(cert_id, book_id);
                            MessageBox.Show("借书成功！！！");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("该图书没有库存");
                    }
                }
                else
                {
                    MessageBox.Show("该借阅卡不存在或处于挂失状态或无借书次数！！！");
                }
            }
            else
            {
                MessageBox.Show("请填写完整！！！");
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            string bookId = textBox_book_id.Text;
            string certId = textBox_cert_id.Text;
            SqlClass sqlClass = new SqlClass();
            if (sqlClass.IsGua(certId))
            {
                MessageBox.Show("该借阅卡为挂失状态或已注销不可进行归还操作操作");
            }
            else
            {
                if (sqlClass.IsRepeatLoan(certId,bookId))
                {
                    sqlClass.kucunjia(bookId);
                    sqlClass.timesjia(certId);
                    sqlClass.ExecuteReturn(certId,bookId);
                    MessageBox.Show("归还成功！！！");
                }
                else
                {
                    MessageBox.Show("该图书未被借阅或已归还！");
                }
            }
        }
    }
}
