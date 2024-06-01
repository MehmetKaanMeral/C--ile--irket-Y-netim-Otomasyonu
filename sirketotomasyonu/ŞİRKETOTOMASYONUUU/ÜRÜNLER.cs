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
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;

namespace ŞİRKETOTOMASYONUUU
{
    public partial class ÜRÜNLER : Form
    {
        public ÜRÜNLER()
        {
            InitializeComponent();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTBOX.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TXTAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TXTMODEL.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MTXTYIL.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           NUADET.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TXTAF.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TXTSF.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        List<string> markalar = new List<string>();
        void listele()
        {
            comboBox1.Items.Clear();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUNLER" ,bgl.baglanti());
            SqlCommand comm = new SqlCommand("select *from TBL_URUNLER", bgl.baglanti());
            SqlCommand cm = new SqlCommand("select count(MARKA) from TBL_URUNLER", bgl.baglanti());
            SqlDataReader drr = comm.ExecuteReader();
            int cnt = (int)cm.ExecuteScalar();
            while (drr.Read())
            {
                
                markalar.Add(drr[2].ToString());
             
                for (int i = 0; i < cnt; i++)
                {

                    if (!comboBox1.Items.Contains(drr[2].ToString()))
                    {
                        comboBox1.Items.Add(drr[2].ToString());
                    }
                    

                }
            }

           
            


      



            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ÜRÜNLER_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTAD.Text == string.Empty)
                hata = 1;
            if (comboBox1.Text == string.Empty)
                hata = 1;
            if (TXTMODEL.Text == string.Empty)
                hata = 1;
            if (MTXTYIL.Text == string.Empty)
                hata = 1;
            if (NUADET.Text == string.Empty)
                hata = 1;
            if (TXTAF.Text == string.Empty)
                hata = 1;
            if (TXTSF.Text == string.Empty)
                hata = 1;
            if (hata == 1)
            {

                MessageBox.Show("BOŞ ALANLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cm = new SqlCommand("insert into TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYATI,SATISFIYATI) values" + " ('" + TXTAD.Text + "','" + comboBox1.Text + "','" + TXTMODEL.Text + "','" + MTXTYIL.Text + "','" + NUADET.Text + "','" + TXTAF.Text + "','" + TXTSF.Text + "')", bgl.baglanti());
                int basari = cm.ExecuteNonQuery();
                bgl.baglanti().Close();

                if (basari == 1)
                    MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
                TXTAD.Clear();
                TXTAF.Clear();
                MTXTYIL.Clear();
                comboBox1.Text = "";
                TXTSF.Clear();
                TXTMODEL.Clear();
            }

    }

        private void button2_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (TXTBOX.Text == string.Empty)
                hata = 1;
            if (hata == 1)
            MessageBox.Show("ALANI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                SqlCommand komut = new SqlCommand("select * from TBL_URUNLER where ID  = '" + TXTBOX.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if(dr.Read())
                {
                    SqlCommand cm = new SqlCommand("delete  from TBL_URUNLER where ID  = '" + TXTBOX.Text + "'", bgl.baglanti());
                    int basari = cm.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    if(basari==1)
                        MessageBox.Show("ÜRÜN SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("ÜRÜN SİLİNMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                    MessageBox.Show("BÖYLE BİR ÜRÜN BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TXTBOX.Clear();
            listele();
            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("update TBL_URUNLER set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYATI=@p6,SATISFIYATI=@p7 where ID=@p8", bgl.baglanti());
            cm.Parameters.AddWithValue("@p1", TXTAD.Text);
            cm.Parameters.AddWithValue("@p2", comboBox1.Text);
            cm.Parameters.AddWithValue("@p3", TXTMODEL.Text);
            cm.Parameters.AddWithValue("@p4", MTXTYIL.Text);
            cm.Parameters.AddWithValue("@p5", int.Parse(((NUADET.Value).ToString())));
            cm.Parameters.AddWithValue("@p6", decimal.Parse(TXTAF.Text));
            cm.Parameters.AddWithValue("@p7", decimal.Parse(TXTSF.Text));
            cm.Parameters.AddWithValue("@p8", TXTBOX.Text);

            int basari = cm.ExecuteNonQuery();
            bgl.baglanti().Close();

            if (basari == 1)
                MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("KAYIT EKLENDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            TXTAD.Clear();
            TXTAF.Clear();
            MTXTYIL.Clear();
            comboBox1.Text = "";
            TXTSF.Clear();
            TXTMODEL.Clear();
        

        }

        private void button4_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j + 1, i + 1];
                    alan2.Cells[2] = dataGridView1[i, j].Value;
                }
            }
        }
    }
}
