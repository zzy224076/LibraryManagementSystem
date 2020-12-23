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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SqlClass sqlClass = new SqlClass();
            DataSet ds=  sqlClass.Query("select Title from BookInfo");
            dataGridView2.Rows.Clear();
            foreach (DataRow mDr in ds.Tables[0].Rows)
            {
                dataGridView2.Rows.Add( mDr[0]);
               
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlClass sqlClass = new SqlClass();
            string title = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            DataSet ds = sqlClass.Query("select ReadingSummary from BookInfo where Title = '" + title + "'");
            textBox1.Text = ds.Tables[0].Rows[0][0]+"";

        }
    }
}
