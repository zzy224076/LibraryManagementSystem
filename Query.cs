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
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Query_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox_query_bookName.Text;
            SqlClass sqlClass = new SqlClass();
            DataSet ds = sqlClass.QueryByTitle(title);
            dataGridView1.Rows.Clear();
            foreach (DataRow mDr in ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(mDr[0], mDr[1], mDr[2], mDr[3], mDr[4], mDr[5], mDr[6]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
