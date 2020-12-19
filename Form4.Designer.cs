
namespace LibraryManagementSystem
{
    partial class Form_xiajia
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
            this.textBox_xiajia = new System.Windows.Forms.TextBox();
            this.button_xiajia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(361, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书名称";
            // 
            // textBox_xiajia
            // 
            this.textBox_xiajia.Location = new System.Drawing.Point(573, 229);
            this.textBox_xiajia.Name = "textBox_xiajia";
            this.textBox_xiajia.Size = new System.Drawing.Size(173, 25);
            this.textBox_xiajia.TabIndex = 1;
            // 
            // button_xiajia
            // 
            this.button_xiajia.Location = new System.Drawing.Point(457, 323);
            this.button_xiajia.Name = "button_xiajia";
            this.button_xiajia.Size = new System.Drawing.Size(139, 72);
            this.button_xiajia.TabIndex = 2;
            this.button_xiajia.Text = "下架";
            this.button_xiajia.UseVisualStyleBackColor = true;
            this.button_xiajia.Click += new System.EventHandler(this.button_xiajia_Click);
            // 
            // Form_xiajia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 680);
            this.Controls.Add(this.button_xiajia);
            this.Controls.Add(this.textBox_xiajia);
            this.Controls.Add(this.label1);
            this.Name = "Form_xiajia";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_xiajia;
        private System.Windows.Forms.Button button_xiajia;
    }
}