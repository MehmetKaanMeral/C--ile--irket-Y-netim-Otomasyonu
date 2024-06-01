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
    public partial class STOKLAR : Form
    {
        public STOKLAR()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void STOKLAR_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,SUM (ADET) as 'ADET' from TBL_URUNLER group by URUNAD ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand km = new SqlCommand("select URUNAD,SUM (ADET) as 'ADET' from TBL_URUNLER group by URUNAD ", bgl.baglanti());
            SqlDataReader dr = km.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Series1"].Points.AddXY(dr[0], dr[1]);
            }
        }
    }
}
