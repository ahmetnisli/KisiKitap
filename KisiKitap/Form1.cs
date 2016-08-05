using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiKitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Server=.;Database=KisiKitap;Integrated Security=true";
        SqlConnection conn = new SqlConnection("Server=.;Database=KisiKitap;Integrated Security=true");
        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriGetir();
        }





        private void KisileriGetir()
        {
            cmbKisiler.Items.Clear();
            AdoNetHelper.Database ado = new AdoNetHelper.Database(connectionString);
            DataTable dt= ado.GetTable("Select * from Kisiler",new List<SqlParameter>());
            foreach(DataRow item in dt.Rows)
            {
                Kisi kisi = new Kisi();
                kisi.Id = (int)item["KisiID"];
                kisi.Ad = item["Ad"].ToString();
                kisi.Soyad = item["Soyad"].ToString();
                kisi.EPosta = item["Email"].ToString();
                kisi.Telefon = item["Telefon"].ToString();
                cmbKisiler.Items.Add(kisi);
            }
        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(connectionString);
            string query = "Insert into Kisiler Values(@ad,@soyad,@email,@telefon)";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter("@ad", txtKisiAd.Text));
            lst.Add(new SqlParameter("@soyad", txtKisiSoyad.Text));
            lst.Add(new SqlParameter("@email", txtKisiEmail.Text));
            lst.Add(new SqlParameter("@telefon", txtKisiTelefon.Text));
            ado.RunQuery(query, lst);
            KisileriGetir();
           

        }

        //private void VerileriTemizle()
        //{
        //    foreach (Control item in Controls)
        //    {
        //        if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
        //        {
        //            item.Text = "";
        //        }
        //    }
        //    foreach (Control item in groupBox1.Controls)
        //    {
        //        if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
        //        {
        //            item.Text = "";
        //        }
        //    }
        //    numKitapFiyat.Value = 0;
        //    chkKitapVarMi.Checked = false;
        //}

        private void cmbKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKisiler.SelectedIndex > -1)
            {
                Kisi kisi = (Kisi)cmbKisiler.SelectedItem;
                KitaplariGetir(kisi.Id);
                txtKisiAd.Text = kisi.Ad;
                txtKisiSoyad.Text = kisi.Soyad;
                txtKisiTelefon.Text = kisi.Telefon;
                txtKisiEmail.Text = kisi.EPosta;
            }
        }

        private void KitaplariGetir(int index)
        {
            lstKitaplar.Items.Clear();
            AdoNetHelper.Database ado = new AdoNetHelper.Database(connectionString);
            string query = "Select * from Kitaplar where KisiID=@id ";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter("@id", index));
            DataTable dt= ado.GetTable(query, lst);
            foreach(DataRow item in dt.Rows)
            {
                Kitap ktp = new Kitap();
                ktp.KitapID = (int)item["KitapID"];
                ktp.KitapAdi = item["KitapAdi"].ToString();
                ktp.Yazar = item["Yazar"].ToString();
                ktp.Kategori = item["Kategori"].ToString();
                ktp.Fiyat = (decimal)item["Fiyat"];
                ktp.VarMi = (bool)item["VarMi"];
               // ktp.KisiID = (int)item["KisiID"];
                lstKitaplar.Items.Add(ktp);
            }
        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedIndex > -1)
            {
                Kitap ktp = lstKitaplar.SelectedItem as Kitap;
                txtKitapAdi.Text = ktp.KitapAdi;
                txtKitapKategori.Text = ktp.Kategori;
                txtKitapYazar.Text = ktp.Yazar;
                numKitapFiyat.Value = ktp.Fiyat;
                chkKitapVarMi.Checked = ktp.VarMi;
            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            AdoNetHelper.Database ado = new AdoNetHelper.Database(connectionString);
            Kisi kisi = cmbKisiler.SelectedItem as Kisi;
            string query = "Insert into Kitaplar Values(@kitapad,@yazar,@kategori,@fiyat,@VarMi,@KisiId)";
            List<SqlParameter> lst = new List<SqlParameter>();
            lst.Add(new SqlParameter("@kitapad", txtKitapAdi.Text));
            lst.Add(new SqlParameter("@yazar", txtKitapYazar.Text));
            lst.Add(new SqlParameter("@kategori", txtKitapKategori.Text));
            lst.Add(new SqlParameter("@fiyat", numKitapFiyat.Value));
            lst.Add(new SqlParameter("@VarMi", chkKitapVarMi.Checked));
            lst.Add(new SqlParameter("@KisiId", kisi.Id));
            ado.RunQuery(query, lst);
            KitaplariGetir(kisi.Id);
            
        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedIndex > -1)
            {
                AdoNetHelper.Database ado = new AdoNetHelper.Database(connectionString);
                Kisi kisi = (Kisi)cmbKisiler.SelectedItem;
                Kitap ktp = lstKitaplar.SelectedItem as Kitap;
                string query = "Update Kitaplar set KitapAdi=@kitapad,Yazar=@yazar,Kategori=@kategori,Fiyat=@fiyat,VarMi=@varMı,KisiID=@kisiId where KitapID=@kitapId";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@kitapad", txtKitapAdi.Text));
                lst.Add(new SqlParameter("@yazar", txtKitapYazar.Text));
                lst.Add(new SqlParameter("@kategori", txtKitapKategori.Text));
                lst.Add(new SqlParameter("@fiyat", numKitapFiyat.Value));
                lst.Add(new SqlParameter("@varMı", chkKitapVarMi.Checked));
                lst.Add(new SqlParameter("@kisiId", kisi.Id));
                lst.Add(new SqlParameter("@kitapId", ktp.KitapID));
                ado.RunQuery(query, lst);
                KitaplariGetir(kisi.Id);
              
            }
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedIndex > -1)
            {
                AdoNetHelper.Database ado = new AdoNetHelper.Database(connectionString);
                Kisi kisi = cmbKisiler.SelectedItem as Kisi;
                string query = "Delete from Kitaplar where KitapID=@kitapId";
                List<SqlParameter> lst = new List<SqlParameter>();
                Kitap ktp = lstKitaplar.SelectedItem as Kitap;
                lst.Add(new SqlParameter("@kitapId", ktp.KitapID));
                ado.RunQuery(query, lst);
                KitaplariGetir(kisi.Id);
                
            }
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            // Sunucu : smtp.gmail.com
            // Port : 587
            // Kullanici Adı : wissen.sc305@gmail.com
            // Şifre : wissen.sc30
            Kisi kisi = cmbKisiler.SelectedItem as Kisi;
            // Eposta gönderme yetki ayarları..
            NetworkCredential kimlik = new NetworkCredential();
            kimlik.UserName = "Mail";
            kimlik.Password = "Sifre";

            // Eposta sunucusu ayarları..
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;

            client.Credentials = kimlik;    // Mail gönderme yetkisi sunucuya verilir.
            client.EnableSsl = true;        // Güvenlik açılır.

            // Gönderilecek mesaj..
            MailMessage posta = new MailMessage();
            posta.IsBodyHtml = true;        // Zengin içerikli mail gönderme için açılır.
            posta.Subject = "Bilgi Mesajı";
            posta.Body = txtMail.Text;

            try
            {
                posta.From = new MailAddress(kimlik.UserName);
                posta.To.Add(new MailAddress(kisi.EPosta));

                client.Send(posta);

                MessageBox.Show("Mail Gonderildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu...");
            }
        }

       
    }
}
