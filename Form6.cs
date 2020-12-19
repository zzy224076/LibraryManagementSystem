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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id=textBox_guaID.Text;
            string name = textBox2_name.Text;
            SqlClass sqlClass = new SqlClass();
            if (radioButton_cert_id.Checked)
            {
                int i = sqlClass.NonQuery("update CertificateInfo set flag=1 where Cert_id =" + id + " and Name='" + name + "'");
                if (i>= 1)
                {
                    MessageBox.Show("挂失成功！！！");
                }
                else
                {
                    MessageBox.Show("请检查信息是否正确！！！");
                }
            }else if (radioButton_xue_id.Checked)
            {
                int i = sqlClass.NonQuery("update CertificateInfo set flag=1 where Cert_value ='" + id+ "' and Name='" + name + "'");
                if (i >= 1)
                {
                    MessageBox.Show("挂失成功！！！");
                }
                else
                {
                    MessageBox.Show("请检查信息是否正确！！！");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox_guaID.Text;
            string name = textBox2_name.Text;
            SqlClass sqlClass = new SqlClass();
            if (radioButton_cert_id.Checked)
            {
                int i = sqlClass.NonQuery("update CertificateInfo set flag=0 where Cert_id =" + id + " and Name='" + name + "'");
                if (i >= 1)
                {
                    MessageBox.Show("补办成功！！！");
                }
                else
                {
                    MessageBox.Show("请检查信息是否正确！！！");
                }
            }
            else if (radioButton_xue_id.Checked)
            {
                int i = sqlClass.NonQuery("update CertificateInfo set flag=0 where Cert_value ='" + id + "' and Name='" + name + "'");
                if (i >= 1)
                {
                    MessageBox.Show("补办成功！！！");
                }
                else
                {
                    MessageBox.Show("请检查信息是否正确！！！");
                }
            }
        }
    }
}
