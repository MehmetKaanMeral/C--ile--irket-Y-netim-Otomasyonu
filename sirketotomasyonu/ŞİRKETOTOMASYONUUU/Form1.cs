using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞİRKETOTOMASYONUUU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new ÜRÜNLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);

        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new MÜŞTERİLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);


            








            

        
            }

        private void şirketlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new ŞİRKETLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new PERSONELLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        }

        private void giderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new GİDERLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);

        }

        private void bankalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new BANKALAR
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        }

        private void faturalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void fATURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void faturaDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new FATURADETAY
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);

        }



        private void sATIŞLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
       

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
      
        }

        private void stoklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new STOKLAR
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        }

        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new KASA
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);

        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new AYARLAR
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fATURAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var urun = new FATURALAR
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        }

        private void sATIŞLARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var urun = new SATISLAR
            {

                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);

        }
    }
    }
    
    
    
