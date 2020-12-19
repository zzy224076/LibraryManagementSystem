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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox_guaID.Text;
            string name = textBox2_name.Text;
            SqlClass sqlClass = new SqlClass();
            DialogResult dr = MessageBox.Show("确实要注销吗？", "注销借阅证（此操作不可更改）", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (id!=""&&name!="")
            {
                if (dr == DialogResult.OK)
                {
                    if (radioButton_cert_id.Checked)
                    {
                        int i = sqlClass.NonQuery("delete from CertificateInfo where Cert_id =" + id + " and Name='" + name + "'");
                        if (i >= 1)
                        {
                            MessageBox.Show("注销成功！！！");
                        }
                        else
                        {
                            MessageBox.Show("请检查信息是否正确！！！");

                        }
                    }
                    else if (radioButton_xue_id.Checked)
                    {
                        int i = sqlClass.NonQuery("delete from CertificateInfo set where Cert_value ='" + id + "' and Name='" + name + "'");
                        if (i >= 1)
                        {
                            MessageBox.Show("注销成功！！！");
                        }
                        else
                        {
                            MessageBox.Show("请检查信息是否正确！！！");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请把信息填写完整！");
            }
            
           
        }
    }
}
