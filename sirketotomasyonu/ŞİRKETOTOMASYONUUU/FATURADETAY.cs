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
    public partial class FATURADETAY : Form
    {
        public FATURADETAY()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        
        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLFATURADETAY ", bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void FATURADETAY_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
