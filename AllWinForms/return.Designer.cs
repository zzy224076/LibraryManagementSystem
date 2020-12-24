
namespace LibraryManagementSystem.AllWinForms
{
    partial class Form_return
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
            this.button_return = new System.Windows.Forms.Button();
            this.textBox_book_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(626, 440);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(114, 52);
            this.button_return.TabIndex = 17;
            this.button_return.Text = "归还";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // textBox_book_id
            // 
            this.textBox_book_id.Location = new System.Drawing.Point(713, 306);
            this.textBox_book_id.Name = "textBox_book_id";
            this.textBox_book_id.Size = new System.Drawing.Size(165, 25);
            this.textBox_book_id.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(542, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "图书ID";
            // 
            // Form_return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 750);
            this.Controls.Add(this.textBox_book_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_return);
            this.Name = "Form_return";
            this.Text = "@return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.TextBox textBox_book_id;
        private System.Windows.Forms.Label label4;
    }
}