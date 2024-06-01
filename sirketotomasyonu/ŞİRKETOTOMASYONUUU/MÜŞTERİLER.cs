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
    public partial class MÜŞTERİLER : Form
    {
        public MÜŞTERİLER()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele ()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMUSTERİLER",bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void illistesi()
        {
            SqlCommand cm = new SqlCommand("select sehir from iller", bgl.baglanti());
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                CMİL.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

        }

        private void MÜŞTERİLER_Load(object sender, EventArgs e)
        {
            listele();
            illistesi();
        }

        private void CMİL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMİLCE.Items.Clear();
            SqlCommand cm = new SqlCommand("select ilce from ilceler where sehir=@p1",bgl.baglanti());
            cm.Parameters.AddWithValue("@p1", CMİL.SelectedIndex +1);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                CMİLCE.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BTKAYIT_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTAD.Text == string.Empty)
                hata = 1;
            if (TXTSOYAD.Text == string.Empty)
                hata = 1;
            if (MTXTEL.Text == string.Empty)
                hata = 1;
            if (MTXTC.Text == string.Empty)
                hata = 1;
            if (TXTMAİL.Text == string.Empty)
                hata = 1;
            if (CMİL.Text == string.Empty)
                hata = 1;
            if (CMİLCE.Text == string.Empty)
                hata = 1;
            if (RTBADRES.Text == string.Empty)
                hata = 1;
            if (TXTVERGİ.Text == string.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("BÜTÜN ALANLARI DOLDURUNUZ","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                SqlCommand cm = new SqlCommand("insert into TBLMUSTERİLER(AD,SOYAD,TEL,TC,MAİL,İL,İLCE,ADRES,VERGİDAİRESİ) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
                cm.Parameters.AddWithValue("@p1", TXTAD.Text);
                cm.Parameters.AddWithValue("@p2", TXTSOYAD.Text);
                cm.Parameters.AddWithValue("@p3", MTXTEL.Text);
                cm.Parameters.AddWithValue("@p4", MTXTC.Text);
                cm.Parameters.AddWithValue("@p5", TXTMAİL.Text);
                cm.Parameters.AddWithValue("@p6", CMİL.Text);
                cm.Parameters.AddWithValue("@p7", CMİLCE.Text);
                cm.Parameters.AddWithValue("@p8", RTBADRES.Text);
                cm.Parameters.AddWithValue("@p9", TXTVERGİ.Text);
                int basari = cm.ExecuteNonQuery();
                if (basari == 1)
                    MessageBox.Show("KAYIT EKLENDİ","MESAJ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("KAYIT EKLENMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listele();
            TXTAD.Clear();
            TXTSOYAD.Clear();
            MTXTEL.Clear();
            MTXTC.Clear();
            TXTMAİL.Clear();
            RTBADRES.Clear();
            TXTVERGİ.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTBOX.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXTAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TXTSOYAD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            MTXTEL.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MTXTC.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TXTMAİL.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            CMİL.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            CMİLCE.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            RTBADRES.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            TXTVERGİ.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
           


        }

        private void BTSİL_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTBOX.Text == string.Empty)
                hata = 1;
            if (hata == 1)
                MessageBox.Show("ALANLARI DOLDURUN","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                SqlCommand cm = new SqlCommand("select * from TBLMUSTERİLER where ID = @p1", bgl.baglanti());
                cm.Parameters.AddWithValue("@p1",TXTBOX.Text);
                cm.ExecuteNonQuery();
                SqlDataReader dr=cm.ExecuteReader();
                if (dr.Read())
                {
                    SqlCommand km = new SqlCommand("delete  from TBLMUSTERİLER where ID = @p1", bgl.baglanti());
                    km.Parameters.AddWithValue("@p1", TXTBOX.Text);
                    int basari = km.ExecuteNonQuery(); 
                        bgl.baglanti().Close();
                    if(basari ==1)
                   MessageBox.Show("MÜŞTERİ SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("MÜŞTERİ SİLİNMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("MÜŞTERİ BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
            TXTBOX.Clear();
            listele();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
