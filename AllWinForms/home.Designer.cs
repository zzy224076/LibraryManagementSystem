
namespace LibraryManagementSystem
{
    partial class home
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_son = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.热门书统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.阅读摘要ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.groupBox_son.SuspendLayout();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox_son);
            this.toolStripContainer1.ContentPanel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1745, 700);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1745, 730);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
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
            this.groupBox_son.Controls.Add(this.label3);
            this.groupBox_son.Location = new System.Drawing.Point(0, 3);
            this.groupBox_son.Name = "groupBox_son";
            this.groupBox_son.Size = new System.Drawing.Size(1742, 753);
            this.groupBox_son.TabIndex = 4;
            this.groupBox_son.TabStop = false;
            this.groupBox_son.Enter += new System.EventHandler(this.groupBox_son_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(613, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(644, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "欢迎您使用图书馆管理系统！";
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
            this.menuStrip1.Size = new System.Drawing.Size(1745, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 26);
            this.toolStripMenuItem1.Text = "系统管理";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.系统设置ToolStripMenuItem.Text = "参数设置";
            this.系统设置ToolStripMenuItem.Click += new System.EventHandler(this.系统设置ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
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
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.编辑ToolStripMenuItem.Text = "图书管理";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 录入图书ToolStripMenuItem
            // 
            this.录入图书ToolStripMenuItem.Name = "录入图书ToolStripMenuItem";
            this.录入图书ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.录入图书ToolStripMenuItem.Text = "录入图书";
            this.录入图书ToolStripMenuItem.Click += new System.EventHandler(this.录入图书ToolStripMenuItem_Click);
            // 
            // 下架图书ToolStripMenuItem1
            // 
            this.下架图书ToolStripMenuItem1.Name = "下架图书ToolStripMenuItem1";
            this.下架图书ToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.下架图书ToolStripMenuItem1.Text = "下架图书";
            this.下架图书ToolStripMenuItem1.Click += new System.EventHandler(this.下架图书ToolStripMenuItem1_Click);
            // 
            // 查询图书ToolStripMenuItem
            // 
            this.查询图书ToolStripMenuItem.Name = "查询图书ToolStripMenuItem";
            this.查询图书ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
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
            this.借书证ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.借书证ToolStripMenuItem.Text = "读者管理";
            this.借书证ToolStripMenuItem.Click += new System.EventHandler(this.借书证ToolStripMenuItem_Click);
            // 
            // 办理借阅证ToolStripMenuItem
            // 
            this.办理借阅证ToolStripMenuItem.Name = "办理借阅证ToolStripMenuItem";
            this.办理借阅证ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.办理借阅证ToolStripMenuItem.Text = "办理借阅证";
            this.办理借阅证ToolStripMenuItem.Click += new System.EventHandler(this.办理借阅证ToolStripMenuItem_Click);
            // 
            // 挂失借阅证ToolStripMenuItem
            // 
            this.挂失借阅证ToolStripMenuItem.Name = "挂失借阅证ToolStripMenuItem";
            this.挂失借阅证ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.挂失借阅证ToolStripMenuItem.Text = "挂失&补办借阅证";
            this.挂失借阅证ToolStripMenuItem.Click += new System.EventHandler(this.挂失借阅证ToolStripMenuItem_Click);
            // 
            // 注销借阅证ToolStripMenuItem
            // 
            this.注销借阅证ToolStripMenuItem.Name = "注销借阅证ToolStripMenuItem";
            this.注销借阅证ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.注销借阅证ToolStripMenuItem.Text = "注销借阅证";
            this.注销借阅证ToolStripMenuItem.Click += new System.EventHandler(this.注销借阅证ToolStripMenuItem_Click);
            // 
            // 借阅管理ToolStripMenuItem
            // 
            this.借阅管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书ToolStripMenuItem,
            this.还书ToolStripMenuItem});
            this.借阅管理ToolStripMenuItem.Name = "借阅管理ToolStripMenuItem";
            this.借阅管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.借阅管理ToolStripMenuItem.Text = "图书租借";
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.借书ToolStripMenuItem.Text = "借书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.还书ToolStripMenuItem.Text = "还书";
            this.还书ToolStripMenuItem.Click += new System.EventHandler(this.还书ToolStripMenuItem_Click);
            // 
            // 信息管理ToolStripMenuItem
            // 
            this.信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.热门书统计ToolStripMenuItem});
            this.信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
            this.信息管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.信息管理ToolStripMenuItem.Text = "信息管理";
            // 
            // 热门书统计ToolStripMenuItem
            // 
            this.热门书统计ToolStripMenuItem.Name = "热门书统计ToolStripMenuItem";
            this.热门书统计ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.热门书统计ToolStripMenuItem.Text = "热门书统计";
            this.热门书统计ToolStripMenuItem.Click += new System.EventHandler(this.热门书统计ToolStripMenuItem_Click);
            // 
            // 图书浏览ToolStripMenuItem
            // 
            this.图书浏览ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.阅读摘要ToolStripMenuItem});
            this.图书浏览ToolStripMenuItem.Name = "图书浏览ToolStripMenuItem";
            this.图书浏览ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.图书浏览ToolStripMenuItem.Text = "图书浏览";
            // 
            // 阅读摘要ToolStripMenuItem
            // 
            this.阅读摘要ToolStripMenuItem.Name = "阅读摘要ToolStripMenuItem";
            this.阅读摘要ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.阅读摘要ToolStripMenuItem.Text = "阅读摘要";
            this.阅读摘要ToolStripMenuItem.Click += new System.EventHandler(this.阅读摘要ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 730);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "home";
            this.Text = "欢迎使用图书管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.groupBox_son.ResumeLayout(false);
            this.groupBox_son.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox_son;
        private System.Windows.Forms.ToolStripMenuItem 查询图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 热门书统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书浏览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 阅读摘要ToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem;
    }
}

