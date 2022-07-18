using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace döviz_kur_hesabı_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            //Her Beş Saniyede Verinin Güncellenmesi İçin Timer
            timer1.Start();
            timer1.Interval = 5000;

            //Para birimlerinin kurlarının site üzerinden çekilip xml olarak kayıt edilmesi
            XmlDocument docveri = new XmlDocument();
            docveri.Load("https://www.tcmb.gov.tr/kurlar/today.xml");

            XmlNode kur = docveri;

            txttarih.Text = kur.SelectSingleNode("/Tarih_Date/@Tarih").InnerText;

            //Dolar Kurunun Çekilip String Formatına Dönüşümü
            string dolar = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='USD']/ForexSelling").InnerText;
            txtdolar.Text = dolar;

            //Euro Kurunun Çekilip String Formatına Dönüşümü
            string euro = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='EUR']/ForexSelling").InnerText;
            txteuro.Text = euro; 

            //Kuveyt Dinarının Kurunun Çekilip String Formatına Dönüşümü
            string dinar = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='KWD']/ForexSelling").InnerText;
            txtdinar.Text = dinar;

            //Azerbaycan Manatı Kurunun Çekilip String Formatına Dönüşümü
            string manat = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='AZN']/ForexSelling").InnerText;
            txtmanat.Text = manat;

            //İngiliz Sterlini Kurunun Çekilip String Formatına Dönüşümü
            string sterlin = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='GBP']/ForexSelling").InnerText;
            txtsterlin.Text = sterlin;

            //Norveç Kronu Kurunun Çekilip String Formatına Dönüşümü
            string kron = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='NOK']/ForexSelling").InnerText;
            txtkron.Text = kron;

            //Norveç Kronu Kurunun Çekilip String Formatına Dönüşümü
            string yen = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='JPY']/ForexSelling").InnerText;
            txtyen.Text = yen;

            //Norveç Kronu Kurunun Çekilip String Formatına Dönüşümü
            string rus = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='RUB']/ForexSelling").InnerText;
            txtrus.Text = rus;

            //Norveç Kronu Kurunun Çekilip String Formatına Dönüşümü
            string yuan = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='CNY']/ForexSelling").InnerText;
            txtyuan.Text = yuan;

            //Norveç Kronu Kurunun Çekilip String Formatına Dönüşümü
            string frang = kur.SelectSingleNode("/Tarih_Date/Currency[@Kod='CHF']/ForexSelling").InnerText;
            txtfrang.Text = frang;

        }
 
        // combobox ile seçilen para birimi üzerinden işlem yapıl
        double para1,para2,bölüm;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dolar kurunun, kur textbox'una transferi
            if(comboBox1.SelectedIndex==0)
            {
                txtkur.Text = txtdolar.Text;
            }
            else if (comboBox1.SelectedIndex==1)
            {
                txtkur.Text = txteuro.Text;
            }
            else if (comboBox1.SelectedIndex==2)
            {
                txtkur.Text = txtdinar.Text;
            }
            else if (comboBox1.SelectedIndex==3)
            {
                txtkur.Text = txtsterlin.Text;
            }
            else if (comboBox1.SelectedIndex==4)
            {
                txtkur.Text = txtmanat.Text;
            }
            else if (comboBox1.SelectedIndex==5)
            {
                txtkur.Text = txtkron.Text ;
            }
            else if (comboBox1.SelectedIndex==6)
            {
                txtkur.Text = txtyen.Text ;
            }
            else if (comboBox1.SelectedIndex==7)
            {
                txtkur.Text = txtyuan.Text;
            }
            else if (comboBox1.SelectedIndex==8)
            {
                txtkur.Text = txtrus.Text ;
            }
            else if (comboBox1.SelectedIndex==9)
            {
                txtkur.Text = txtfrang.Text ;
            }

        }
        //textboclar temizlenir.
        private void tmzlbttn_Click(object sender, EventArgs e)
        {
            txtsonuc.Clear();
            txtdeger.Clear();
            txtkur.Clear();
        }
        //değer ve kurun çarpımı ile sonuc bulunur.
        double kur, deger, sonuc;
        private void hsplbttn_Click(object sender, EventArgs e)
        {
            kur = Convert.ToDouble(txtkur.Text);
            deger = Convert.ToDouble(txtdeger.Text);
            sonuc = kur * deger;
            txtsonuc.Text = sonuc.ToString() + " ₺";
        }

        // text change ile txtkura aktarılır , virgül ve noktaları eklenir.
        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ",");
        }

        //Programı Kapatma Butonu Ve Uyarı Ekranı
        private void kptbttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamayı Kapatmak İstiyor Musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

    }
}
