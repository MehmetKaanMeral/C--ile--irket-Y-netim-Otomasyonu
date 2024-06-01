using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ŞİRKETOTOMASYONUUU
{
    class sqlbaglanti
    {
        public static string connString = System.IO.File.ReadAllText(@"C:\connection.txt");
        public SqlConnection baglanti()
        {
           

        SqlConnection b = new SqlConnection(@connString);
            b.Open();
            return b;
        }
    }
}
