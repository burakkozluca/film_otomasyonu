using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace VTYS_PROJE1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;Port=5432;Database=filmotomasyonu;User Id=postgres;Password=123");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM \"Film\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (tbxId.Text != "")
            {
                MessageBox.Show("ID alanı otomatik belirlenir. Lütfen boş bırakınız.");
            }
            else
            {
                string sqlEkle = "INSERT INTO \"Film\"(\"Ad\",\"Yayin_Tarihi\",\"IMBD\",\"Konu\",\"Bitis_zamani\",\"Sure\",\"Fragman\",\"Baslama_zamani\",\"Afis\",\"Yonetmen_ID\",\"Kategori_ID\",\"Yerli_ID\") VALUES (@p1 ,@p2,@p3,@p4,@p8,@p6,@p7,@p5,@p9,@p10,@p11,@p12)";

                NpgsqlCommand ekle = new NpgsqlCommand(sqlEkle, baglanti);
                ekle.Parameters.AddWithValue("@p1", tbxAd.Text);
                ekle.Parameters.AddWithValue("@p2", DateTime.Parse(tbxYayin_tarihi.Text));
                ekle.Parameters.AddWithValue("@p3", tbximbd.Text);
                ekle.Parameters.AddWithValue("@p4", tbxkonu.Text);
                ekle.Parameters.AddWithValue("@p5", int.Parse(tbxbaslama_zamani.Text));
                ekle.Parameters.AddWithValue("@p6", int.Parse(tbxsure.Text));
                ekle.Parameters.AddWithValue("@p7", tbxfragman.Text);
                ekle.Parameters.AddWithValue("@p8", int.Parse(tbxbitis_zamani.Text));
                ekle.Parameters.AddWithValue("@p9", tbxafis.Text);
                ekle.Parameters.AddWithValue("@p10", int.Parse(tbxyonetmen.Text));
                ekle.Parameters.AddWithValue("@p11", int.Parse(tbxkategori.Text));
                ekle.Parameters.AddWithValue("@p12", int.Parse(tbxyerli.Text));

                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme işlemi gerçekleşti.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int id = int.Parse(tbxId.Text);
            string sqlSil = "DELETE FROM \"Film\" WHERE \"ID\" =" + id + "";

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                NpgsqlCommand sil = new NpgsqlCommand(sqlSil, baglanti);
                sil.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbx = (TextBox)item;
                    tbx.Clear();
                }
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sqlGuncelle = "UPDATE \"Film\" SET \"Ad\"=  @p1  ,\"Yayin_Tarihi\"=@p2,\"IMBD\"=@p3,\"Konu\"=@p4,\"Bitis_zamani\"=@p8,\"Sure\"=@p6,\"Fragman\"=@p7,\"Baslama_zamani\"=@p5,\"Afis\"=@p9,\"Yonetmen_ID\"=@p10,\"Kategori_ID\"=@p11,\"Yerli_ID\"=@p12 WHERE \"ID\"=@p13";

            NpgsqlCommand guncelle = new NpgsqlCommand(sqlGuncelle, baglanti);
            guncelle.Parameters.AddWithValue("@p1", tbxAd.Text);
            guncelle.Parameters.AddWithValue("@p2", DateTime.Parse(tbxYayin_tarihi.Text));
            guncelle.Parameters.AddWithValue("@p3", tbximbd.Text);
            guncelle.Parameters.AddWithValue("@p4", tbxkonu.Text);
            guncelle.Parameters.AddWithValue("@p8", int.Parse(tbxbitis_zamani.Text));
            guncelle.Parameters.AddWithValue("@p6", int.Parse(tbxsure.Text));
            guncelle.Parameters.AddWithValue("@p7", tbxfragman.Text);
            guncelle.Parameters.AddWithValue("@p5", int.Parse(tbxbaslama_zamani.Text));
            guncelle.Parameters.AddWithValue("@p9", tbxafis.Text);
            guncelle.Parameters.AddWithValue("@p10", int.Parse(tbxyonetmen.Text));
            guncelle.Parameters.AddWithValue("@p11", int.Parse(tbxkategori.Text));
            guncelle.Parameters.AddWithValue("@p12", int.Parse(tbxyerli.Text));
            guncelle.Parameters.AddWithValue("@p13", int.Parse(tbxId.Text));

            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void tbxAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter ara = new NpgsqlDataAdapter("SELECT * FROM \"Film\" WHERE \"Ad\" LIKE '%" + tbxAra.Text + "%' ", baglanti);
            ara.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
    }
}