
namespace LibraryManagementSystem
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_cert_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_cert_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_cert_value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.comboBox_depart = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_cert_ID
            // 
            this.textBox_cert_ID.Location = new System.Drawing.Point(881, 161);
            this.textBox_cert_ID.Name = "textBox_cert_ID";
            this.textBox_cert_ID.Size = new System.Drawing.Size(100, 25);
            this.textBox_cert_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(706, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "借书证书ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(706, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "证件名称";
            // 
            // comboBox_cert_name
            // 
            this.comboBox_cert_name.FormattingEnabled = true;
            this.comboBox_cert_name.Items.AddRange(new object[] {
            "身份证号",
            "学号/职工号"});
            this.comboBox_cert_name.Location = new System.Drawing.Point(881, 284);
            this.comboBox_cert_name.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox_cert_name.Name = "comboBox_cert_name";
            this.comboBox_cert_name.Size = new System.Drawing.Size(107, 23);
            this.comboBox_cert_name.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(706, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "证件号码";
            // 
            // textBox_cert_value
            // 
            this.textBox_cert_value.Location = new System.Drawing.Point(881, 338);
            this.textBox_cert_value.Name = "textBox_cert_value";
            this.textBox_cert_value.Size = new System.Drawing.Size(107, 25);
            this.textBox_cert_value.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(706, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "所在部门";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(706, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "姓名";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(881, 416);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(107, 25);
            this.textBox_name.TabIndex = 18;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(706, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "证件类型";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "教师",
            "学生"});
            this.comboBox_type.Location = new System.Drawing.Point(881, 215);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(107, 23);
            this.comboBox_type.TabIndex = 22;
            // 
            // comboBox_depart
            // 
            this.comboBox_depart.FormattingEnabled = true;
            this.comboBox_depart.Items.AddRange(new object[] {
            "管理学院",
            "经济学院",
            "商学院",
            "会计学院",
            "艺术设计学院",
            "传媒学院",
            "外国语学院",
            "智慧制造学院",
            "计算机与人工智能学院",
            "土木建筑学院",
            "马克思主义学院",
            "公共教学部"});
            this.comboBox_depart.Location = new System.Drawing.Point(881, 480);
            this.comboBox_depart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox_depart.Name = "comboBox_depart";
            this.comboBox_depart.Size = new System.Drawing.Size(107, 23);
            this.comboBox_depart.TabIndex = 23;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 846);
            this.Controls.Add(this.comboBox_depart);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_cert_value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_cert_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_cert_ID);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_cert_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_cert_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_cert_value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.ComboBox comboBox_depart;
    }
}