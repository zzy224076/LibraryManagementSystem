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
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Query_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox_query_bookName.Text;
            SqlClass sqlClass = new SqlClass();
            DataSet ds = sqlClass.QueryByTitle(title);
            groupBox1.Show();
            foreach (DataRow mDr in ds.Tables[0].Rows)
            {


                label_book_name.Text = (string)mDr[1];
                label_author.Text = mDr[3]+"";
                label_publish.Text = mDr[2]+"";
                label_words.Text = mDr[4]+"";
                label_number.Text = mDr[5]+"";
                label_price.Text = mDr[6]+"";
                textBox_jianjie.Text =mDr[8]+"";
                
                pictureBox_book_pic.ImageLocation =mDr[9]+"";
                pictureBox_book_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label_words_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_book_pic_Click(object sender, EventArgs e)
        {

        }
    }
}
