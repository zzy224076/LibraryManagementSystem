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
    public partial class ranking : Form
    {
        public ranking()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlClass sqlClass = new SqlClass();
            DataSet ds= sqlClass.Query("SELECT DISTINCT(Title),SUM(Loantimes) times from BookInfo GROUP BY Title ORDER BY times desc;");
            dataGridView1.Rows.Clear();
            int i = 1;
            foreach (DataRow mDr in ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(i,mDr[0], mDr[1]);
                i++;
            }
        }

    }
    }

