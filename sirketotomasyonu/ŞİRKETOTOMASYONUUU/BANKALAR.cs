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
    public partial class BANKALAR : Form
    {
        public BANKALAR()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("execute bankalistele", bgl.baglanti());
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BTSİL_Click(object sender, EventArgs e)
        {
            
        }

        private void BANKALAR_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
