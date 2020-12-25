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
            string key = textBox_query.Text;
            
            SqlClass sqlClass = new SqlClass();
            if (radioButton_name.Checked)
            {
                DataSet ds = sqlClass.QueryByTitle(key);
                if (sqlClass.IsNull(ds))
                {
                    MessageBox.Show("该图书不存在！！！");
                }
                else
                {
                    groupBox1.Show();
                    label_book_name.Text =ds.Tables[0].Rows[0][1]+"";
                    label_author.Text = ds.Tables[0].Rows[0][3] + "";
                    label_publish.Text = ds.Tables[0].Rows[0][2] + "";
                    label_words.Text = ds.Tables[0].Rows[0][4] + "";
                    label_price.Text = ds.Tables[0].Rows[0][5] + "";
                    textBox_jianjie.Text = ds.Tables[0].Rows[0][7] + "";
                    pictureBox_book_pic.ImageLocation = ds.Tables[0].Rows[0][8] + "";
                    pictureBox_book_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    /*foreach (DataRow mDr in ds.Tables[0].Rows)
                    {
                        label_book_name.Text = (string)mDr[1];
                        label_author.Text = mDr[3] + "";
                        label_publish.Text = mDr[2] + "";
                        label_words.Text = mDr[4] + "";
                        label_price.Text = mDr[5] + "";
                        textBox_jianjie.Text = mDr[7] + "";
                        pictureBox_book_pic.ImageLocation = mDr[8] + "";
                        pictureBox_book_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    }*/
                }
            }else if (radioButton_id.Checked)
            {
                DataSet ds  = sqlClass.QueryById(key);
                if (sqlClass.IsNull(ds))
                {
                    MessageBox.Show("该图书不存在！！！");
                }
                else
                {
                    groupBox1.Show();
                    label_book_name.Text = ds.Tables[0].Rows[0][1] + "";
                    label_author.Text = ds.Tables[0].Rows[0][3] + "";
                    label_publish.Text = ds.Tables[0].Rows[0][2] + "";
                    label_words.Text = ds.Tables[0].Rows[0][4] + "";
                    label_price.Text = ds.Tables[0].Rows[0][5] + "";
                    textBox_jianjie.Text = ds.Tables[0].Rows[0][7] + "";
                    pictureBox_book_pic.ImageLocation = ds.Tables[0].Rows[0][8] + "";
                    pictureBox_book_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                }

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
