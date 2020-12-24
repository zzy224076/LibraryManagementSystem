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
            
            sqlClass.ExecuteReturn( bookId);
            MessageBox.Show("归还成功！！！");
        }
    }
}
