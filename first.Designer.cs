
namespace LibraryManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label_username = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_son = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新增图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下架图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下架图书ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书证ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.办理借阅证ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.挂失借阅证ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销借阅证ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.热门书统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.阅读摘要ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新书浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel_login.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(483, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书馆管理系统";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label_username);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel_login);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox_son);
            this.toolStripContainer1.ContentPanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(982, 625);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(982, 653);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(818, 14);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(119, 15);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "label_username";
            this.label_username.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.textBox_password);
            this.panel_login.Controls.Add(this.label5);
            this.panel_login.Controls.Add(this.textBox_username);
            this.panel_login.Controls.Add(this.label4);
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Location = new System.Drawing.Point(100, 56);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(786, 464);
            this.panel_login.TabIndex = 1;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(293, 324);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(168, 60);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.AcceptsTab = true;
            this.textBox_password.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_password.Location = new System.Drawing.Point(334, 220);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(192, 25);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(181, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "密码";
            // 
            // textBox_username
            // 
            this.textBox_username.AcceptsTab = true;
            this.textBox_username.Location = new System.Drawing.Point(334, 148);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(192, 25);
            this.textBox_username.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(181, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(286, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "管理员登录";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1203, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 0;
            // 
            // groupBox_son
            // 
            this.groupBox_son.Location = new System.Drawing.Point(0, 42);
            this.groupBox_son.Name = "groupBox_son";
            this.groupBox_son.Size = new System.Drawing.Size(976, 580);
            this.groupBox_son.TabIndex = 4;
            this.groupBox_son.TabStop = false;
            this.groupBox_son.Text = "groupBox1";
            this.groupBox_son.Enter += new System.EventHandler(this.groupBox_son_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.编辑ToolStripMenuItem,
            this.借书证ToolStripMenuItem,
            this.借阅管理ToolStripMenuItem,
            this.信息管理ToolStripMenuItem,
            this.图书浏览ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增图书ToolStripMenuItem,
            this.下架图书ToolStripMenuItem,
            this.注销ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem1.Text = "系统管理";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 新增图书ToolStripMenuItem
            // 
            this.新增图书ToolStripMenuItem.Name = "新增图书ToolStripMenuItem";
            this.新增图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.新增图书ToolStripMenuItem.Text = "修改密码";
            this.新增图书ToolStripMenuItem.Click += new System.EventHandler(this.新增图书ToolStripMenuItem_Click);
            // 
            // 下架图书ToolStripMenuItem
            // 
            this.下架图书ToolStripMenuItem.Name = "下架图书ToolStripMenuItem";
            this.下架图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.下架图书ToolStripMenuItem.Text = "用户管理";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.录入图书ToolStripMenuItem,
            this.下架图书ToolStripMenuItem1,
            this.查询图书ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.编辑ToolStripMenuItem.Text = "图书管理";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 录入图书ToolStripMenuItem
            // 
            this.录入图书ToolStripMenuItem.Name = "录入图书ToolStripMenuItem";
            this.录入图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.录入图书ToolStripMenuItem.Text = "录入图书";
            this.录入图书ToolStripMenuItem.Click += new System.EventHandler(this.录入图书ToolStripMenuItem_Click);
            // 
            // 下架图书ToolStripMenuItem1
            // 
            this.下架图书ToolStripMenuItem1.Name = "下架图书ToolStripMenuItem1";
            this.下架图书ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.下架图书ToolStripMenuItem1.Text = "下架图书";
            this.下架图书ToolStripMenuItem1.Click += new System.EventHandler(this.下架图书ToolStripMenuItem1_Click);
            // 
            // 查询图书ToolStripMenuItem
            // 
            this.查询图书ToolStripMenuItem.Name = "查询图书ToolStripMenuItem";
            this.查询图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询图书ToolStripMenuItem.Text = "查询图书";
            this.查询图书ToolStripMenuItem.Click += new System.EventHandler(this.查询图书ToolStripMenuItem_Click);
            // 
            // 借书证ToolStripMenuItem
            // 
            this.借书证ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.办理借阅证ToolStripMenuItem,
            this.挂失借阅证ToolStripMenuItem,
            this.注销借阅证ToolStripMenuItem});
            this.借书证ToolStripMenuItem.Name = "借书证ToolStripMenuItem";
            this.借书证ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.借书证ToolStripMenuItem.Text = "读者管理";
            this.借书证ToolStripMenuItem.Click += new System.EventHandler(this.借书证ToolStripMenuItem_Click);
            // 
            // 办理借阅证ToolStripMenuItem
            // 
            this.办理借阅证ToolStripMenuItem.Name = "办理借阅证ToolStripMenuItem";
            this.办理借阅证ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.办理借阅证ToolStripMenuItem.Text = "办理借阅证";
            this.办理借阅证ToolStripMenuItem.Click += new System.EventHandler(this.办理借阅证ToolStripMenuItem_Click);
            // 
            // 挂失借阅证ToolStripMenuItem
            // 
            this.挂失借阅证ToolStripMenuItem.Name = "挂失借阅证ToolStripMenuItem";
            this.挂失借阅证ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.挂失借阅证ToolStripMenuItem.Text = "挂失&补办借阅证";
            this.挂失借阅证ToolStripMenuItem.Click += new System.EventHandler(this.挂失借阅证ToolStripMenuItem_Click);
            // 
            // 注销借阅证ToolStripMenuItem
            // 
            this.注销借阅证ToolStripMenuItem.Name = "注销借阅证ToolStripMenuItem";
            this.注销借阅证ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.注销借阅证ToolStripMenuItem.Text = "注销借阅证";
            this.注销借阅证ToolStripMenuItem.Click += new System.EventHandler(this.注销借阅证ToolStripMenuItem_Click);
            // 
            // 借阅管理ToolStripMenuItem
            // 
            this.借阅管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书ToolStripMenuItem});
            this.借阅管理ToolStripMenuItem.Name = "借阅管理ToolStripMenuItem";
            this.借阅管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.借阅管理ToolStripMenuItem.Text = "图书租借";
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.借书ToolStripMenuItem.Text = "借书/还书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 信息管理ToolStripMenuItem
            // 
            this.信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.热门书统计ToolStripMenuItem});
            this.信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
            this.信息管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.信息管理ToolStripMenuItem.Text = "信息管理";
            // 
            // 热门书统计ToolStripMenuItem
            // 
            this.热门书统计ToolStripMenuItem.Name = "热门书统计ToolStripMenuItem";
            this.热门书统计ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.热门书统计ToolStripMenuItem.Text = "热门书统计";
            this.热门书统计ToolStripMenuItem.Click += new System.EventHandler(this.热门书统计ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 图书浏览ToolStripMenuItem
            // 
            this.图书浏览ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.阅读摘要ToolStripMenuItem,
            this.新书浏览ToolStripMenuItem});
            this.图书浏览ToolStripMenuItem.Name = "图书浏览ToolStripMenuItem";
            this.图书浏览ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.图书浏览ToolStripMenuItem.Text = "图书浏览";
            // 
            // 阅读摘要ToolStripMenuItem
            // 
            this.阅读摘要ToolStripMenuItem.Name = "阅读摘要ToolStripMenuItem";
            this.阅读摘要ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.阅读摘要ToolStripMenuItem.Text = "阅读摘要";
            // 
            // 新书浏览ToolStripMenuItem
            // 
            this.新书浏览ToolStripMenuItem.Name = "新书浏览ToolStripMenuItem";
            this.新书浏览ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.新书浏览ToolStripMenuItem.Text = "新书浏览";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "欢迎使用图书管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下架图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书证ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 录入图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下架图书ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 办理借阅证ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 挂失借阅证ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销借阅证ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.GroupBox groupBox_son;
        private System.Windows.Forms.ToolStripMenuItem 查询图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 热门书统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书浏览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 阅读摘要ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新书浏览ToolStripMenuItem;
    }
}

