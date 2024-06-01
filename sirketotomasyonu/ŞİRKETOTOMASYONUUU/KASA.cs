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
    public partial class KASA : Form
    {
        public KASA()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("execute satıslarlıste", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        void listelegider()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLGİDERLER", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }



        private void KASA_Load(object sender, EventArgs e)
        {
            listele();
            listelegider();

            SqlCommand km = new SqlCommand("select sum (TOPLAMFIYAT) from TBLFATURADETAY", bgl.baglanti());
            SqlDataReader dr = km.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand km1 = new SqlCommand("select (ELEKTİRİK+SU+DOGALGAZ+İNTERNET+KİRA) from TBLGİDERLER order by ID ASC", bgl.baglanti());
            SqlDataReader dr1 = km1.ExecuteReader();
            while (dr1.Read())
            {
                label2.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand km2 = new SqlCommand("select MAASLAR  from TBLGİDERLER order by ID ASC", bgl.baglanti());
            SqlDataReader dr2 = km2.ExecuteReader();
            while (dr2.Read())
            {
                label3.Text = dr2[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            groupBox1.Text = "ELEKTİRİK";
            chart1.Series["AYLAR"].Points.Clear();
            sayac++;
            if(sayac>0 && sayac <= 5)
            {
                SqlCommand km2 = new SqlCommand("select top 4 AY,ELEKTİRİK  from TBLGİDERLER order by ID DESC", bgl.baglanti());
                SqlDataReader dr2 = km2.ExecuteReader();
                while (dr2.Read())
                {
                    chart1.Series["AYLAR"].Points.AddXY(dr2[0],dr2[1]);
                }
                bgl.baglanti().Close();
            }
            if (sayac > 5 && sayac <= 10)
            {
                groupBox1.Text = "SU";
                chart1.Series["AYLAR"].Points.Clear();
                SqlCommand km2 = new SqlCommand("select top 4 AY,SU  from TBLGİDERLER order by ID DESC", bgl.baglanti());
                SqlDataReader dr2 = km2.ExecuteReader();
                while (dr2.Read())
                {
                    chart1.Series["AYLAR"].Points.AddXY(dr2[0], dr2[1]);
                }
                bgl.baglanti().Close();
            }
            if (sayac > 10 && sayac <= 15)
            {
                groupBox1.Text = "DOGALGAZ";
                chart1.Series["AYLAR"].Points.Clear();
                SqlCommand km2 = new SqlCommand("select top 4 AY,DOGALGAZ  from TBLGİDERLER order by ID DESC", bgl.baglanti());
                SqlDataReader dr2 = km2.ExecuteReader();
                while (dr2.Read())
                {
                    chart1.Series["AYLAR"].Points.AddXY(dr2[0], dr2[1]);
                }
                bgl.baglanti().Close();
            }
            if (sayac > 15 && sayac <= 20)
            {
                groupBox1.Text = "İNTERNET";
                chart1.Series["AYLAR"].Points.Clear();
                SqlCommand km2 = new SqlCommand("select top 4 AY,İNTERNET  from TBLGİDERLER order by ID DESC", bgl.baglanti());
                SqlDataReader dr2 = km2.ExecuteReader();
                while (dr2.Read())
                {
                    chart1.Series["AYLAR"].Points.AddXY(dr2[0], dr2[1]);
                }
                bgl.baglanti().Close();
            }
            if (sayac > 20 && sayac <= 25)
            {
                groupBox1.Text = "KİRA";
                chart1.Series["AYLAR"].Points.Clear();
                SqlCommand km2 = new SqlCommand("select top 4 AY,KİRA  from TBLGİDERLER order by ID DESC", bgl.baglanti());
                SqlDataReader dr2 = km2.ExecuteReader();
                while (dr2.Read())
                {
                    chart1.Series["AYLAR"].Points.AddXY(dr2[0], dr2[1]);
                }
                bgl.baglanti().Close();
            }
            if (sayac == 25)
            {
                sayac = 0;
            }


        }
    }
}
