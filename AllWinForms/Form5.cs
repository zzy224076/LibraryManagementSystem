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
            int cert_id = int.Parse(textBox_cert_ID.Text);
            string cert_name = comboBox_cert_name.Text;
            string cert_type = comboBox_type.Text;
            string cert_value = textBox_cert_value.Text;
            string name = textBox_name.Text;
            string depart = comboBox_depart.Text;
            string sql = "insert into CertificateInfo values(" + cert_id + ",'" + cert_name + "','" + cert_value + "','" + name + "','" + depart + "',0,3,'学生')";
            SqlClass sqlClass = new SqlClass();
           
            
            if (cert_id!=0&&sqlClass.IsRepeat("CertificateInfo","Cert_id",cert_id))
            {
                MessageBox.Show("id已存在请重新输入！");
            }
            else
            {
                
                if (name!=""&& cert_name!="" && cert_value != "")
                {
                    if (cert_type == "教师")
                    {
                        sqlClass.NonQuery("insert into CertificateInfo values(" + cert_id + ",'" + cert_name + "','" + cert_value + "','" + name + "','" + depart + "',0,5,'教师')");
                        MessageBox.Show("办理成功！");
                    }
                    else
                    {
                        MessageBox.Show(sql);
                    sqlClass.NonQuery(sql);
                    MessageBox.Show("办理成功！");
                }
                    
                }
                else
                {
                    MessageBox.Show("请把信息填写完整！");
                }
            }
            

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
    }
}
