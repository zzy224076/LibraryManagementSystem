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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str_id = textBox_cert_ID.Text;
            string cert_name = comboBox_cert_name.Text;
            string cert_type = comboBox_type.Text;
            string cert_value = textBox_cert_value.Text;
            string name = textBox_name.Text;
            string depart = comboBox_depart.Text;
            
            SqlClass sqlClass = new SqlClass();

            if (str_id!=""&& name != "" && cert_name != "" && cert_value != "" && cert_type != ""&&depart!="")
            {
                
                int cert_id = int.Parse(textBox_cert_ID.Text);
                string sql = "insert into CertificateInfo values(" + cert_id + ",'" + cert_name + "','" + cert_value + "','" + name + "','" + depart + "',0,'学生')";
                if (cert_id != 0 && sqlClass.IsRepeat("CertificateInfo", "Cert_id", cert_id))
                {
                    MessageBox.Show("id已存在请重新输入！");
                }
                else
                {
                            sqlClass.NonQuery("insert into CertificateInfo values(" + cert_id + ",'" + cert_name + "','" + cert_value + "','" + name + "','" + depart + "',0,'"+cert_type+"')");
                            MessageBox.Show("办理成功！");
                }
            }
            else
            {
                MessageBox.Show("请将信息填写完整！");
            }
            
            

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_cert_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_cert_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_cert_value_KeyPress(object sender, KeyPressEventArgs e)
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
