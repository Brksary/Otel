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
    public partial class BosOdalar : Form
    {
        public BosOdalar()
        {
            InitializeComponent();
        }

        

        void oku()
        {

            string baglanti = "Data Source=PC\\SA; Initial Catalog=Otel;User Id = sa;Password =1234; Integrated Security=true";

            SqlConnection con = new SqlConnection(baglanti);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand komut = new SqlCommand("select OdaNo  from odalar where Durum = 'Boş' ", con);

            SqlDataReader rdr = komut.ExecuteReader();

            while(rdr.Read())
            {

                odatx.Items.Add(rdr["OdaNo"]);

            }

            con.Close();
        }

        string ad, giris, cikis;
        int tc, tel, odano;


        void sqlverial()
        {


            ad = AdSoyadtx.Text;
            giris = giristx.Text;
            cikis = cikistx.Text;
            tc = int.Parse(Tctx.Text);
            tel = int.Parse(Teltx.Text);
            odano = int.Parse(odatx.Text);





        }



        void sqlyaz()
        {


            string baglanti = "Data Source=PC\\SA; Initial Catalog=Otel;User Id = sa;Password =1234; Integrated Security=true";

            SqlConnection con = new SqlConnection(baglanti);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand komut = new SqlCommand("insert into musteriler (AdSoyad,Odano,giris,cikis,Telefon,TcKimlik) values ('" + ad + "','" + odano + "','" + giris + "','" + cikis + "','" + tel + "','" + tc + "') ", con);

            komut.ExecuteNonQuery();


            con.Close();

            MessageBox.Show("Aktarıldı");






        }









        void BodOdalar()
        {

           listView1.View = View.Details;

           listView1.Columns.Clear();
           listView1.Columns.Add("Boş Odalar",100, HorizontalAlignment.Center);

            string baglanti = "Data Source=PC\\SA; Initial Catalog=Otel;User Id = sa;Password =1234; Integrated Security=true";

            SqlConnection con = new SqlConnection(baglanti);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand komut = new SqlCommand("select OdaNo  from odalar where Durum = 'Boş' ", con);

            SqlDataAdapter adp = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();

            adp.Fill(tablo);
           
            listView1.Items.Clear();

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                DataRow satir = tablo.Rows[i];

                if (satir.RowState != DataRowState.Deleted)
                {

                    ListViewItem item = new ListViewItem(satir["OdaNo"].ToString());
                    
                    listView1.Items.Add(item);
                }  
                

                con.Close();
            }



        }

        private void BosOdalar_Load(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            oku();
            BodOdalar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlverial();
            sqlyaz();
        }
    }
}
