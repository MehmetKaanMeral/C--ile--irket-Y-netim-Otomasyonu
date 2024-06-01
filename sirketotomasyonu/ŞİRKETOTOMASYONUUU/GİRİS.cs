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
    public partial class GİRİS : Form
    {
        public GİRİS()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select * from TBL_ADMİN where AD=@p1 and SIFRE=@p2", bgl.baglanti());
            cm.Parameters.AddWithValue("@p1", textBox1.Text);
            cm.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
                
            }
            else
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI","UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
