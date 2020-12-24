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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void settings_Load(object sender, EventArgs e)
        {
            SqlClass sqlClass = new SqlClass();
            DataSet ds =sqlClass.Query("select * from settings");
            numericUpDown_stu_loanDate.Value = (int)ds.Tables[0].Rows[0][2];
            numericUpDown_stu_loanNum.Value = (int)ds.Tables[0].Rows[0][0];
            numericUpDown_tea_loanDate.Value= (int)ds.Tables[0].Rows[0][3];
            numericUpDown_tea_loanNum.Value = (int)ds.Tables[0].Rows[0][1];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlClass sqlClass = new SqlClass();
            int loanNum_stu = (int)numericUpDown_stu_loanNum.Value;
            int loanDate_stu = (int)numericUpDown_stu_loanDate.Value;
            int loanNum_tea = (int)numericUpDown_tea_loanNum.Value;
            int loanDate_tea = (int)numericUpDown_tea_loanDate.Value;
            sqlClass.NonQuery("update settings set loanNum_stu="+loanNum_stu+",loanNum_tea="+loanNum_tea+",maxDate_stu="+loanDate_stu+",maxDate_tea="+loanDate_tea);
            MessageBox.Show("修改成功");
        }
    }
}
