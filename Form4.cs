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
    public partial class Form_xiajia : Form
    {
        public Form_xiajia()
        {
            InitializeComponent();
        }

        private void button_xiajia_Click(object sender, EventArgs e)
        {
            string bookName = textBox_xiajia.Text;
            string sql = "delete from BookInfo where Title='"+bookName+"'";
            SqlClass sqlClass = new SqlClass();
            int i= sqlClass.NonQuery(sql);
            if (i == 0)
            {
                MessageBox.Show("该图书不存在！");
            }
            else
            {
                MessageBox.Show("下架成功！");
            }
        }
    }
}
