using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ŞİRKETOTOMASYONUUU
{
    public partial class ŞİRKETLER : Form
    {
        public ŞİRKETLER()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLSİRKETLER", bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

               
        }

        

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            İLETİŞİM frm = new İLETİŞİM();
            frm.mail = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ŞİRKETLER_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
