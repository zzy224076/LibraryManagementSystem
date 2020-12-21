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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlClass sqlClass = new SqlClass();
            DataSet ds= sqlClass.Query("select * from BookInfo order by Loantimes desc");
            dataGridView1.Rows.Clear();
            int i = 1;
            foreach (DataRow mDr in ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(i,mDr[0], mDr[1], mDr[2], mDr[3], mDr[4], mDr[5], mDr[6], mDr[7]);
                i++;
            }
        }

    }
    }

