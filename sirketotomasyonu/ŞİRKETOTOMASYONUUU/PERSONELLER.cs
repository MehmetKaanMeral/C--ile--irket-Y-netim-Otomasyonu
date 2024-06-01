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
    public partial class PERSONELLER : Form
    {
        public PERSONELLER()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_PERSONEL", bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }







        private void PERSONELLER_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BTSİL_Click(object sender, EventArgs e)
        {

        }
    }
}
