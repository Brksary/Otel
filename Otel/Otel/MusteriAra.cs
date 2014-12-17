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

namespace Otel
{
    public partial class MusteriAra : Form
    {
        public MusteriAra()
        {
            InitializeComponent();
        }


        void sqloku()
        {


            string tc = tcsorgu.Text;


           


            Liste.View = View.Details;

            Liste.Columns.Clear();
            Liste.Columns.Add("AdSoyad", 80, HorizontalAlignment.Center);
            Liste.Columns.Add("Oda", 30, HorizontalAlignment.Center);
            Liste.Columns.Add("Giriş", 80, HorizontalAlignment.Center);
            Liste.Columns.Add("Çıkış", 80, HorizontalAlignment.Center);
            Liste.Columns.Add("telefon", 80, HorizontalAlignment.Center);
            Liste.Columns.Add("Tc", 80, HorizontalAlignment.Center);




            string baglanti = "Data Source=PC\\SA; Initial Catalog=Otel;User Id = sa;Password =1234; Integrated Security=true";

            SqlConnection con = new SqlConnection(baglanti);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand komut = new SqlCommand("select AdSoyad, Odano as [Kaldığı Oda], giris,cikis,Telefon,TcKimlik from musteriler  where TcKimlik = '" + tc + "' ", con);

            SqlDataAdapter adp = new SqlDataAdapter(komut);

            DataTable veriler = new DataTable();

            adp.Fill(veriler);


            Liste.Items.Clear();

            for (int i = 0; i < veriler.Rows.Count; i++)
            {
                DataRow satir = veriler.Rows[i];

                if (satir.RowState != DataRowState.Deleted)
                {
                    ListViewItem item = new ListViewItem(satir["AdSoyad"].ToString());
                    item.SubItems.Add(satir["Kaldığı Oda"].ToString());
                    item.SubItems.Add(satir["giris"].ToString());
                    item.SubItems.Add(satir["cikis"].ToString());
                    item.SubItems.Add(satir["Telefon"].ToString());
                    item.SubItems.Add(satir["TcKimlik"].ToString());

                    Liste.Items.Add(item);
                }
            }


            con.Close();






        }









        private void MusteriAra_Load(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqloku();
        }
    }
}
