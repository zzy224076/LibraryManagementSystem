
namespace LibraryManagementSystem.AllWinForms
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_stu_loanNum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_tea_loanNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_stu_loanDate = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown_tea_loanDate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stu_loanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tea_loanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stu_loanDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tea_loanDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(782, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生可借本数：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown_stu_loanNum
            // 
            this.numericUpDown_stu_loanNum.Location = new System.Drawing.Point(997, 185);
            this.numericUpDown_stu_loanNum.Name = "numericUpDown_stu_loanNum";
            this.numericUpDown_stu_loanNum.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_stu_loanNum.TabIndex = 1;
            // 
            // numericUpDown_tea_loanNum
            // 
            this.numericUpDown_tea_loanNum.Location = new System.Drawing.Point(997, 303);
            this.numericUpDown_tea_loanNum.Name = "numericUpDown_tea_loanNum";
            this.numericUpDown_tea_loanNum.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_tea_loanNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(784, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "教师可借本数：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(784, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "学生可借天数：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown_stu_loanDate
            // 
            this.numericUpDown_stu_loanDate.Location = new System.Drawing.Point(997, 245);
            this.numericUpDown_stu_loanDate.Name = "numericUpDown_stu_loanDate";
            this.numericUpDown_stu_loanDate.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_stu_loanDate.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(911, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_tea_loanDate
            // 
            this.numericUpDown_tea_loanDate.Location = new System.Drawing.Point(997, 373);
            this.numericUpDown_tea_loanDate.Name = "numericUpDown_tea_loanDate";
            this.numericUpDown_tea_loanDate.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_tea_loanDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(784, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "教师可借天数：";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 749);
            this.Controls.Add(this.numericUpDown_tea_loanDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_stu_loanDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_tea_loanNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_stu_loanNum);
            this.Controls.Add(this.label1);
            this.Name = "settings";
            this.Text = "system";
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stu_loanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tea_loanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stu_loanDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tea_loanDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_stu_loanNum;
        private System.Windows.Forms.NumericUpDown numericUpDown_tea_loanNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_stu_loanDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown_tea_loanDate;
        private System.Windows.Forms.Label label4;
    }
}