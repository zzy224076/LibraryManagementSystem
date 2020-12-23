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
    
    public partial class Form1 : Form
    {
        static int IS_LOGIN = 0;
        static string CURRENT_USER = null;
        public Form1()
        {
            InitializeComponent();
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\Calmness.ssk";
        }
        private void OpenFrom(Form objFrm)
        {
            //将当前子窗体设置成非顶级控件
            objFrm.TopLevel = false;
            //设置窗体最大化
            objFrm.WindowState = FormWindowState.Maximized;
            //去掉窗体边框
            objFrm.FormBorderStyle = FormBorderStyle.None;
            //指定当前子窗体显示的容器
            objFrm.Parent = this.groupBox_son;
            groupBox_son.Text = objFrm.Text;
            //显示窗体
            objFrm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox_son.Hide();
            label_username.Visible=false;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_addBooks form_AddBooks = new Form_addBooks();
            form_AddBooks.Show();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 添加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_addBooks form_AddBooks = new Form_addBooks();
            form_AddBooks.Show();
        }

        private void 借书证ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void 新增图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            SqlClass sqlClass = new SqlClass();
            
            if (sqlClass.Login(username, password))
            {
                MessageBox.Show("登录成功！！！");
                IS_LOGIN = 1;
                CURRENT_USER = username;
                label_username.Visible = true;
                label_username.Text = CURRENT_USER+",欢迎您！";
                Form2 form2 = new Form2();
                this.OpenFrom(form2);
                panel_login.Hide();
                groupBox_son.Show();

            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 录入图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IS_LOGIN == 0)
            {
                MessageBox.Show("请您先登录！");
            }
            else
            {
                Form_addBooks form_AddBooks = new Form_addBooks();
                this.OpenFrom(form_AddBooks);
                groupBox_son.Show();
            }
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IS_LOGIN = 0;
            CURRENT_USER = null;
            label_username.Text = null;
            
            panel_login.Show();
            groupBox_son.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查询图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IS_LOGIN == 0)
            {
                MessageBox.Show("请您先登录！");
            }
            else
            {
                Query query = new Query();
                this.OpenFrom(query);
                groupBox_son.Show();
            }
        }

        private void 下架图书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IS_LOGIN == 0)
            {
                MessageBox.Show("请您先登录！");
            }
            else
            {
                Form_xiajia form_Xiajia =new Form_xiajia();
                this.OpenFrom(form_Xiajia);
                groupBox_son.Show();
            }
        }

        private void groupBox_son_Enter(object sender, EventArgs e)
        {

        }

        private void 办理借阅证ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IS_LOGIN == 0)
            {
                MessageBox.Show("请您先登录！");
            }
            else
            {
                Form5 form5 = new Form5();
                this.OpenFrom(form5);
                groupBox_son.Show();
            }
        }

        private void 挂失借阅证ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IS_LOGIN == 0)
            {
                MessageBox.Show("请您先登录！");
            }
            else
            {
                Form6 form6 = new Form6();
                this.OpenFrom(form6);
                groupBox_son.Show();
            }
        }

        private void 注销借阅证ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IS_LOGIN == 0)
            {
                MessageBox.Show("请您先登录！");
            }
            else
            {
                Form7 form7 = new Form7();
                this.OpenFrom(form7);
                groupBox_son.Show();
            }
        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IS_LOGIN == 0)
            {
                MessageBox.Show("请您先登录！");
            }
            else
            {
                Form8 form8 = new Form8();
                this.OpenFrom(form8);
                groupBox_son.Show();
            }
        }

        private void 热门书统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IS_LOGIN == 0)
            {
                MessageBox.Show("请您先登录！");
            }
            else
            {
                Form9 form9 = new Form9();
                this.OpenFrom(form9);
                groupBox_son.Show();
            }
        }

        private void 阅读摘要ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IS_LOGIN == 0)
            {
                MessageBox.Show("请您先登录！");
            }
            else
            {
                Form10 form10 = new Form10();
                this.OpenFrom(form10);
                groupBox_son.Show();
            }
        }
    }
    }

