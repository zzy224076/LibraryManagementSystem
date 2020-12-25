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
    public partial class Form_addBooks : Form
    {
        public Form_addBooks()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookId = textBox_Book_ID.Text;
            string title = textBox_Title.Text;
            DateTime dateValue = dateTimePicker_publish.Value;
            string publish= dateValue.ToString();
            string author= textBox_author.Text;
            int words = (int)numericUpDown_words.Value;
            
            
            string price = textBox_price.Text;
            string url = textBox_picUrl.Text;
            string readingSummary = textBox_readingSummary.Text;
            SqlClass sqlClass = new SqlClass();
          
                if (sqlClass.IsNull(sqlClass.QueryById(bookId))){
                    
                    string sql = "insert into BookInfo  values('" + bookId+ "','" + title + "','" + publish + "','"+author+"',"+words+",'"+price+"',0,'"+readingSummary+"','"+url+"')";
                    
                    sqlClass.NonQuery(sql);
                    
                    
                }
                else
                {
                    MessageBox.Show("id已存在，请重新输入！");
                    
                }
          
            
            
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
