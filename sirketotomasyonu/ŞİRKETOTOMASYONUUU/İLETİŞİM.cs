using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace ŞİRKETOTOMASYONUUU
{
    public partial class İLETİŞİM : Form
    {
        public İLETİŞİM()
        {
            InitializeComponent();
        }

        private void İLETİŞİM_Load(object sender, EventArgs e)
        { }
            public string mail;
        private void iletişim_load(object sender, EventArgs e)
        {
            textBox1.Text = mail;
        }
        private void button1_click(object sender,EventArgs e)
        { 

        }

        private void BTKAYIT_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
            SmtpClient gönder = new SmtpClient();
            gönder.Credentials = new System.Net.NetworkCredential("mail","şifre");
            gönder.Port = 587;
            gönder.Host = "smtp.gmail.com";
            gönder.EnableSsl = true;
            msg.To.Add(textBox1.Text);
            msg.From = new MailAddress("mail");
            msg.Subject = textBox1.Text;
            gönder.Send(msg);


        }
    }
}
