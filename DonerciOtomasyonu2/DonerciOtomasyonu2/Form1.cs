using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DonerciOtomasyonu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                con = new
                SqlConnection("server=localhost;database=DonerciOtomasyonu; Trusted_connection=True;TrustServerCertificate=true;");
                
            }
            catch (Exception h)
            {

            }
        }

        SqlConnection con;
        SqlTransaction transaction;
        Dictionary<string, double> urunadvefiyatlari;
        //public double etdonerservisfiyati = 10;
        //public double etdonerdurumfiyati = 10;
        //public double tavukdonerservisfiyati = 10;
        //public double tavukdonerdurumfiyati = 10;
        //public double g3fiyati = 10;
        //public double ayranfiyati = 10;
        //public double kolafiyati = 10;
        //public double fantafiyati = 10;
        //public double salgamfiyati = 10;
        //public double gazozfiyati = 10;
        //public double sufiyati = 10;
        //public double cayfiyati = 10;
        //public double etdonermenufiyati = 10;
        //public double tavukdonermenufiyati = 10;
        //public double ogrencimenufiyati = 10;
        public void UrunEkle()
        {
            Product urun = new Product();
            string eklenecekUrunAdi = listBox1.Text;
            if (eklenecekUrunAdi != null
                       && Regex.IsMatch(eklenecekUrunAdi, "^[öüÖÜĞğşŞçÇıİ|a-z|A-Z|0-9]{2,20}(\\s[öüÖÜĞğşŞçÇıİ|a-z|A-Z]{2,20}){0,3}$"))
            { urun.Name = eklenecekUrunAdi; }
            urun.Amount = 1;
            urun.Properties = "";
            urun.Date = DateTime.Now.ToString("dd/MM/yyyy");

            int i = 0;
            i = 0;
            while (i < urunadvefiyatlari.Count)
            {
                if (urunadvefiyatlari.ElementAt(i).Key == listBox1.Text)
                {
                    urun.Price = urunadvefiyatlari.ElementAt(i).Value;
                    urun.TotalPrice = urunadvefiyatlari.ElementAt(i).Value;
                }

                i++;
            }

            //if (listBox1.Text == "Et Döner Servis")
            //{ urun.Price = etdonerservisfiyati; urun.TotalPrice = etdonerservisfiyati; }
            //if (listBox1.Text == "Et Döner Dürüm")
            //{ urun.Price = etdonerdurumfiyati; urun.TotalPrice = etdonerdurumfiyati; }
            //if (listBox1.Text == "Tavuk Döner Servis")
            //{ urun.Price = tavukdonerservisfiyati; urun.TotalPrice = tavukdonerservisfiyati; }
            //if (listBox1.Text == "Tavuk Döner Dürüm")
            //{ urun.Price = tavukdonerdurumfiyati; urun.TotalPrice = tavukdonerdurumfiyati; }
            //if (listBox1.Text == "G3")
            //{ urun.Price = g3fiyati; urun.TotalPrice = g3fiyati; }
            //if (listBox1.Text == "Ayran")
            //{ urun.Price = ayranfiyati; urun.TotalPrice = ayranfiyati; }
            //if (listBox1.Text == "Şalgam")
            //{ urun.Price = salgamfiyati; urun.TotalPrice = salgamfiyati; }
            //if (listBox1.Text == "Kola")
            //{ urun.Price = kolafiyati; urun.TotalPrice = kolafiyati; }
            //if (listBox1.Text == "Fanta")
            //{ urun.Price = fantafiyati; urun.TotalPrice = fantafiyati; }
            //if (listBox1.Text == "Gazoz")
            //{ urun.Price = gazozfiyati; urun.TotalPrice = gazozfiyati; }
            //if (listBox1.Text == "Su")
            //{ urun.Price = sufiyati; urun.TotalPrice = sufiyati; }
            //if (listBox1.Text == "Çay")
            //{ urun.Price = cayfiyati; urun.TotalPrice = cayfiyati; }
            //if (listBox1.Text == "Et Döner Menü")
            //{ urun.Price = etdonermenufiyati; urun.TotalPrice = etdonermenufiyati; }
            //if (listBox1.Text == "Tavuk Döner Menü")
            //{ urun.Price = tavukdonermenufiyati; urun.TotalPrice = tavukdonermenufiyati; }
            //if (listBox1.Text == "Öğrenci Menü")
            //{ urun.Price = ogrencimenufiyati; urun.TotalPrice = ogrencimenufiyati; }

            if (listBox2.Text != "Normal Ekmekli")
            { urun.Properties += listBox2.Text + "\n"; }
            if (listBox3.Text != "Normal Ketçaplı")
            { urun.Properties += listBox3.Text + "\n"; }
            if (listBox4.Text != "Normal Soslu")
            { urun.Properties += listBox4.Text + "\n"; }
            if (listBox5.Text != "Normal Mayonezli")
            { urun.Properties += listBox5.Text + "\n"; }
            if (listBox6.Text != "Normal Salatalı")
            { urun.Properties += listBox6.Text + "\n"; }
            if (listBox7.Text != "Normal Patatesli")
            { urun.Properties += listBox7.Text + "\n"; }
            if (listBox8.Text != "Normal Soğanlı")
            { urun.Properties += listBox8.Text + "\n"; }
            if (listBox9.Text != "Normal Acılı")
            { urun.Properties += listBox9.Text + "\n"; }
            if (listBox10.Text != "Normal Yağlı")
            { urun.Properties += listBox10.Text + "\n"; }

            try
            {
                bool found = false;
                bool found2 = false;
                if (dataGridView1.Rows.Count > 0)
                {
                    i = 0;
                    while (i < dataGridView1.Rows.Count)
                    {
                        string string1 = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                        string string2 = urun.Properties;
                        string1 = Regex.Replace(string1, "\\s", "");
                        string2 = Regex.Replace(string2, "\\s", "");
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == urun.Name
                            && Regex.IsMatch(urun.Name, "^[öüÖÜĞğşŞçÇıİ|a-z|A-Z|0-9]{2,20}(\\s[öüÖÜĞğşŞçÇıİ|a-z|A-Z]{2,20}){0,3}$")
                            && string1 == string2)
                        {
                            dataGridView1.Rows[i].Cells[1].Value =
                                Convert.ToString(1 +
                                Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value));
                            dataGridView1.Rows[i].Cells[2].Value =
                                Convert.ToString(urun.Price);
                            dataGridView1.Rows[i].Cells[3].Value =
                                Convert.ToString(urun.Price +
                                Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value));
                            found = true;
                        }
                        i++;
                    }
                }
                if (dataGridView2.Rows.Count > 0)
                {
                    i = 0;
                    while (i < dataGridView2.Rows.Count)
                    {
                        if (Convert.ToString(dataGridView2.Rows[i].Cells[0].Value) == urun.Name
                            && dataGridView2.Rows[i].Cells[4].Value.ToString() == urun.Date
                            && Regex.IsMatch(urun.Name, "^[öüÖÜĞğşŞçÇıİ|a-z|A-Z|0-9]{2,20}(\\s[öüÖÜĞğşŞçÇıİ|a-z|A-Z]{2,20}){0,3}$"))
                        {
                            dataGridView2.Rows[i].Cells[1].Value =
                                Convert.ToString(1 +
                                Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value));
                            dataGridView2.Rows[i].Cells[2].Value =
                                Convert.ToString(urun.Price);
                            dataGridView2.Rows[i].Cells[3].Value =
                                Convert.ToString(urun.Price +
                                Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value));
                            found2 = true;
                        }
                        i++;
                    }
                }

                if (found == false && Regex.IsMatch(urun.Name, "^[öüÖÜĞğşŞçÇıİ|a-z|A-Z|0-9]{2,20}(\\s[öüÖÜĞğşŞçÇıİ|a-z|A-Z]{2,20}){0,3}$"))
                {
                    string s = Regex.Replace(urun.Properties, "\\s+", " ");
                    dataGridView1.Rows.Add(urun.Name, urun.Amount, urun.Price, urun.TotalPrice, s);
                }
                if (found2 == false && Regex.IsMatch(urun.Name, "^[öüÖÜĞğşŞçÇıİ|a-z|A-Z|0-9]{2,20}(\\s[öüÖÜĞğşŞçÇıİ|a-z|A-Z]{2,20}){0,3}$"))
                {
                    DataTable dt = dataGridView2.DataSource as DataTable;
                    if (dt != null)
                    {
                        
                        // set the field values as required                
                        dt.Rows.Add(urun.Name, urun.Amount, urun.Price, urun.TotalPrice, urun.Date);
                        dataGridView2.DataSource = dt;
                    }
                    else
                    {
                        dataGridView2.Rows.Add(urun.Name, urun.Amount, urun.Price, urun.TotalPrice, urun.Date);
                    }
                    
                }
            }
            catch (Exception ex) 
            {
                
            }

            listBox2.SelectedIndex = 0;
            listBox3.SelectedIndex = 0;
            listBox4.SelectedIndex = 0;
            listBox5.SelectedIndex = 0;
            listBox6.SelectedIndex = 0;
            listBox7.SelectedIndex = 0;
            listBox8.SelectedIndex = 0;
            listBox9.SelectedIndex = 0;
            listBox10.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
           
                UrunEkle();
            

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox2.Text) + "where [Ürün Adı]='Et Döner Servis'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    etdonerservisfiyati = Double.Parse(textBox2.Text);
            //    textBox2.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox3.Text) + "where [Ürün Adı]='Et Döner Dürüm'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    etdonerdurumfiyati = Double.Parse(textBox3.Text);
            //    textBox3.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox4.Text) + "where [Ürün Adı]='Tavuk Döner Servis'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    tavukdonerservisfiyati = Double.Parse(textBox4.Text);
            //    textBox4.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox5.Text) + "where [Ürün Adı]='Tavuk Döner Dürüm'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    tavukdonerdurumfiyati = Double.Parse(textBox5.Text);
            //    textBox5.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox6.Text) + "where [Ürün Adı]='G3'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    g3fiyati = Double.Parse(textBox6.Text);
            //    textBox6.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox7.Text) + "where [Ürün Adı]='Ayran'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    ayranfiyati = Double.Parse(textBox7.Text);
            //    textBox7.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox8.Text) + "where [Ürün Adı]='Kola'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    kolafiyati = Double.Parse(textBox8.Text);
            //    textBox8.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox9.Text) + "where [Ürün Adı]='Fanta'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    fantafiyati = Double.Parse(textBox9.Text);
            //    textBox9.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox10.Text) + "where [Ürün Adı]='Su'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    sufiyati = Double.Parse(textBox10.Text);
            //    textBox10.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox11.Text) + "where [Ürün Adı]='Çay'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    cayfiyati = Double.Parse(textBox11.Text);
            //    textBox11.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox12.Text) + "where [Ürün Adı]='Şalgam'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    salgamfiyati = Double.Parse(textBox12.Text);
            //    textBox12.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox13.Text) + "where [Ürün Adı]='Gazoz'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    gazozfiyati = Double.Parse(textBox13.Text);
            //    textBox13.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox19.Text) + "where [Ürün Adı]='Et Döner Menü'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    etdonermenufiyati = Double.Parse(textBox19.Text);
            //    textBox19.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox18.Text) + "where [Ürün Adı]='Tavuk Döner Menü'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    tavukdonermenufiyati = Double.Parse(textBox18.Text);
            //    textBox18.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
            //            "[Ürün Fiyatı]=" + Double.Parse(textBox17.Text) + "where [Ürün Adı]='Öğrenci Menü'", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    ogrencimenufiyati = Double.Parse(textBox17.Text);
            //    textBox17.Text = "";
            //    MessageBox.Show("Fiyat Başarıyla Değiştirilmiştir", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);



            //}
            //catch (Exception a)
            //{

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Seçili kayıt sadece siparişten değil \nSürekli kayıtlardan da silinecektir!\nEmin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.No)
            {

            }
            if (secim == DialogResult.Yes)
            {

                int rowindex = dataGridView1.SelectedCells[0].RowIndex;
                int rowindex1 = 0;
                int i = 0;
                while (i < dataGridView2.Rows.Count - 1)
                {
                    if (dataGridView2.Rows[i].Cells[0].Value.ToString()
                        .Equals(dataGridView1.Rows[rowindex].Cells[0].Value.ToString()))
                    {
                        rowindex1 = dataGridView2.Rows[i].Cells[0].RowIndex;
                    }
                    i++;
                }

                if (Int32.Parse(Convert.ToString(dataGridView1.Rows[rowindex].Cells[1].Value)) >= 1)
                {
                    dataGridView1.Rows[rowindex].Cells[1].Value =
                        Convert.ToString(Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[1].Value) - 1);
                    dataGridView1.Rows[rowindex].Cells[3].Value =
                        Convert.ToString(Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[3].Value)
                        - Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[2].Value));
                }

                try
                {
                    if (Int32.Parse(Convert.ToString(dataGridView2.Rows[rowindex1].Cells[1].Value)) >= 1
                    && dataGridView1.Rows[rowindex].Cells[0].Value.ToString().Trim() ==
                    dataGridView2.Rows[rowindex1].Cells[0].Value.ToString().Trim())
                    {
                        dataGridView2.Rows[rowindex1].Cells[1].Value =
                            Convert.ToString(Convert.ToInt32(dataGridView2.Rows[rowindex1].Cells[1].Value) - 1);
                        dataGridView2.Rows[rowindex1].Cells[3].Value =
                            Convert.ToString(Convert.ToDouble(dataGridView2.Rows[rowindex1].Cells[3].Value)
                            - Convert.ToDouble(dataGridView2.Rows[rowindex1].Cells[2].Value));
                    }

                }
                catch (Exception ex)
                {
                    if (Int32.Parse(Convert.ToString(dataGridView1.Rows[rowindex].Cells[1].Value)) < 1)
                    {
                        dataGridView1.Rows.RemoveAt(rowindex);
                    }
                }

                if (Int32.Parse(Convert.ToString(dataGridView1.Rows[rowindex].Cells[1].Value)) < 1)
                {
                    dataGridView1.Rows.RemoveAt(rowindex);
                }

                if (Int32.Parse(Convert.ToString(dataGridView2.Rows[rowindex1].Cells[1].Value)) < 1
                    && dataGridView1.Rows[rowindex].Cells[0].Value ==
                    dataGridView2.Rows[rowindex1].Cells[0].Value)
                {
                    dataGridView2.Rows.RemoveAt(rowindex1);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Sipariş Hesabı Sıfırlanacaktır! Emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.No)
            {

            }
            if (secim == DialogResult.Yes)
            {

                while (dataGridView1.Rows.Count > 1)
                {

                    dataGridView1.Rows.RemoveAt(0);

                }
                textBox14.Text = "";
                textBox15.Text = "";

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp,
                new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(objBmp, 0, 0);
            e.Graphics.DrawString("Toplam tutar: " + textBox1.Text,
                new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new Point(0, this.dataGridView1.Height + 20));
            e.Graphics.DrawString("Müşteri Telefon: " + textBox14.Text,
                new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new Point(0, this.dataGridView1.Height + 50));
            e.Graphics.DrawString("Müşteri Adres: ",
                new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new Point(0, this.dataGridView1.Height + 80));
            e.Graphics.DrawString(textBox15.Text,
                new Font("Verdana", 6, FontStyle.Bold), Brushes.Black, new Point(0, this.dataGridView1.Height + 110));
            e.Graphics.DrawString("XXXXX DÖNER ",
                new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new Point(0, this.dataGridView1.Height + 140));
            e.Graphics.DrawString("0322XXXXXXX-0541XXXXXXX ",
                new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new Point(0, this.dataGridView1.Height + 170));
            e.Graphics.DrawString("100. Yıl Mah. XXXXX XXXX Blv. No:89 ADANA",
                new Font("Verdana", 8, FontStyle.Bold), Brushes.Black, new Point(0, this.dataGridView1.Height + 200));
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            double total = 0;
            while (i < dataGridView1.Rows.Count - 1)
            {
                total += Double.Parse(Convert.ToString(dataGridView1.Rows[i].Cells[3].Value));
                i++;
            }
            textBox1.Text = total.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int i = 0;
            double total = 0;
            while (i < dataGridView1.Rows.Count - 1)
            {
                total += Double.Parse(Convert.ToString(dataGridView1.Rows[i].Cells[3].Value));
                i++;
            }
            textBox1.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
            PrintDialog p1 = new PrintDialog();
            p1.Document = printDocument1;
            p1.AllowSelection = true;
            p1.AllowSomePages = true;
            if (p1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }


        public static Boolean IsTableExistInDb(string tableName, SqlConnection Con)
        {

            try
            {


                SqlCommand Cmd = new SqlCommand("SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = " + "'" + tableName + "'", Con);
                Con.Open();
                Object result = Cmd.ExecuteScalar();
                Con.Close();

                if (result != null && byte.Parse(result.ToString()) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return true;

            }
            finally
            {
                if (Con.State != ConnectionState.Closed)
                {
                    Con.Close();

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection;
            try
            {
                connection = new SqlConnection("Server=localhost; Integrated Security=SSPI; database=master");
                //SqlCommand command = new SqlCommand("Create Database if not exists DonerciOtomasyonu", connection);
                SqlCommand command = new SqlCommand($"If(db_id(N'DonerciOtomasyonu') IS NULL) CREATE DATABASE [DonerciOtomasyonu]", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {


            }
            finally
            {

            }

            try
            {

                string query = "Create table dbo.DonerciOtomasyonu" +
                    "(" +
                    "[Ürün Adı] nvarchar(50) not null," +

                    "[Ürün Fiyatı] float not null," +

                    ")";
                SqlCommand command1 = new SqlCommand(query, con);
                if (!IsTableExistInDb("dbo.DonerciOtomasyonu", con))
                {
                    con.Open();
                    command1.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            try
            {

                string query = "Create table dbo.DonerciOtomasyonu2" +
                    "(" +
                    "[Ürün Adı] nvarchar(50) not null," +
                    "[Ürün Adedi] int not null," +
                    "[Ürün Fiyatı] float not null," +
                    "Toplam float not null," +
                    "Tarih nvarchar(50) not null" +
                    ")";
                SqlCommand command1 = new SqlCommand(query, con);
                if (!IsTableExistInDb("dbo.DonerciOtomasyonu2", con))
                {
                    con.Open();
                    command1.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            try
            {

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DonerciOtomasyonu2", con);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = table;
                con.Close();



            }
            catch (Exception ex)
            {

            }


            urunadvefiyatlari = new Dictionary<string, double>();
            int i = 0;

            SqlCommand com = new SqlCommand("Select * from DonerciOtomasyonu", con);

            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                urunadvefiyatlari.Add(dr["Ürün Adı"].ToString(), Double.Parse(dr["Ürün Fiyatı"].ToString()));
            }
            con.Close();


            listBox1.Items.Clear();
            i = 0;
            while (i < urunadvefiyatlari.Count)
            {
                listBox1.Items.Add(urunadvefiyatlari.ElementAt(i).Key);

                i++;
            }


            //try
            //{

            //    SqlCommand cmd1 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Et Döner Servis'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd1.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        etdonerservisfiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd2 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Et Döner Dürüm'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd2.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        etdonerdurumfiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd3 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Tavuk Döner Servis'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd3.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        tavukdonerservisfiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd4 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Tavuk Döner Dürüm'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd4.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        tavukdonerdurumfiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd5 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='G3'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd5.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        g3fiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd6 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Ayran'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd6.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        ayranfiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd7 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Şalgam'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd7.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        salgamfiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd8 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Gazoz'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd8.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        gazozfiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd9 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Su'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd9.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        sufiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd10 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Çay'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd10.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        cayfiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd11 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Kola'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd11.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        kolafiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd12 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Fanta'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd12.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        fantafiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd13 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Et Döner Menü'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd13.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        etdonermenufiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}

            //try
            //{

            //    SqlCommand cmd14 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Tavuk Döner Menü'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd14.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        tavukdonermenufiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
            //try
            //{

            //    SqlCommand cmd15 =
            //    new SqlCommand("Select * from DonerciOtomasyonu where [Ürün Adı]='Öğrenci Menü'", con);
            //    con.Open();
            //    SqlDataReader dr = cmd15.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        ogrencimenufiyati = Double.Parse(dr["Ürün Fiyatı"].ToString());
            //    }
            //    con.Close();
            //}
            //catch (Exception j)
            //{

            //}
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            int i = 0;
            double total = 0;
            while (i < dataGridView2.Rows.Count - 1)
            {
                total += Double.Parse(Convert.ToString(dataGridView2.Rows[i].Cells[3].Value));
                i++;
            }
            textBox16.Text = total.ToString();
            
        
            try
            {

                con.Open();
                transaction = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand("Truncate table DonerciOtomasyonu2", con,transaction);
                
                cmd.ExecuteNonQuery();
                //con.Close();
                int k = 0;
                while (k < dataGridView2.Rows.Count - 1)
                {

                    SqlCommand cmd2 = new SqlCommand("Insert into DonerciOtomasyonu2 values " +
                        "(@urunadi,@urunadedi,@urunfiyati," +
                        " @toplam,@tarih)", con,transaction);
                    cmd2.Parameters.AddWithValue("@urunadi", dataGridView2.Rows[k].Cells[0].Value);
                    cmd2.Parameters.AddWithValue("@urunadedi", dataGridView2.Rows[k].Cells[1].Value);
                    cmd2.Parameters.AddWithValue("@urunfiyati", dataGridView2.Rows[k].Cells[2].Value);
                    cmd2.Parameters.AddWithValue("@toplam", dataGridView2.Rows[k].Cells[3].Value);
                    cmd2.Parameters.AddWithValue("@tarih", dataGridView2.Rows[k].Cells[4].Value);
                    //con.Open();
                    cmd2.ExecuteNonQuery();
                    
                    k++;
                }
                transaction.Commit();
                con.Close();


            }
            catch (Exception a)
            {
                try
                {
                    transaction.Rollback();
                    if (con.State == ConnectionState.Open)
                    { con.Close(); }
                }
                catch(Exception ex)
                {
                    if (con.State == ConnectionState.Open)
                    { con.Close(); }
                }
                


            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            double total = 0;
            while (i < dataGridView2.Rows.Count - 1)
            {
                total += Double.Parse(Convert.ToString(dataGridView2.Rows[i].Cells[3].Value));
                i++;
            }
            textBox16.Text = total.ToString();

            try
            {
                //SqlCommand cmd = new SqlCommand("Update DonerciOtomasyonu set " +
                //        "[Ürün Adedi]=0," +
                //        " Toplam=0", con);
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                int k = 0;
                while (k < dataGridView2.Rows.Count - 1)
                {

                    SqlCommand cmd2 = new SqlCommand("Update DonerciOtomasyonu2 set " +
                        "[Ürün Adı]=@urunadi,[Ürün Adedi]=@urunadedi,[Ürün Fiyatı]=@urunfiyati," +
                        " Toplam=@toplam, Tarih=@tarih where [Ürün Adı]=@urunadi and Tarih=@tarih", con);
                    cmd2.Parameters.AddWithValue("@urunadi", dataGridView2.Rows[k].Cells[0].Value);
                    cmd2.Parameters.AddWithValue("@urunadedi", dataGridView2.Rows[k].Cells[1].Value);
                    cmd2.Parameters.AddWithValue("@urunfiyati", dataGridView2.Rows[k].Cells[2].Value);
                    cmd2.Parameters.AddWithValue("@toplam", dataGridView2.Rows[k].Cells[3].Value);
                    cmd2.Parameters.AddWithValue("@tarih", dataGridView2.Rows[k].Cells[4].Value);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    k++;
                }


            }
            catch (Exception a)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Seçili Kayıt Silinecektir! Emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.No)
            {

            }
            if (secim == DialogResult.Yes)
            {
                int rowindex = dataGridView2.SelectedCells[0].RowIndex;
                if (Int32.Parse(Convert.ToString(dataGridView2.Rows[rowindex].Cells[1].Value)) >= 1)
                {
                    dataGridView2.Rows[rowindex].Cells[1].Value =
                        Convert.ToString(Convert.ToInt32(dataGridView2.Rows[rowindex].Cells[1].Value) - 1);
                    dataGridView2.Rows[rowindex].Cells[3].Value =
                        Convert.ToString(Convert.ToDouble(dataGridView2.Rows[rowindex].Cells[3].Value)
                        - Convert.ToDouble(dataGridView2.Rows[rowindex].Cells[2].Value));
                }
                if (Int32.Parse(dataGridView2.Rows[rowindex].Cells[1].Value.ToString()) < 1)
                {
                    dataGridView2.Rows.RemoveAt(rowindex);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Bunu yaparsanız veritabanındaki kalan veriler çekilecektir.\nBu önceden kalan verileri çekmenize neden olabilir!\nEmin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.No)
            {

            }
            if (secim == DialogResult.Yes)
            {
                try
                {

                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DonerciOtomasyonu2", con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView2.AutoGenerateColumns = false;
                    dataGridView2.DataSource = table;
                    con.Close();



                }
                catch (Exception a)
                {

                }
            }

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView2.Width, this.dataGridView2.Height);
            dataGridView2.DrawToBitmap(objBmp,
                new Rectangle(0, 0, this.dataGridView2.Width, this.dataGridView2.Height));
            e.Graphics.DrawImage(objBmp, 0, 0);
            e.Graphics.DrawString("Toplam tutar= " + textBox16.Text,
                new Font("Verdana", 12, FontStyle.Bold), Brushes.Black, new Point(0, this.dataGridView2.Height + 30));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //printPreviewDialog2.Document = printDocument2;
            //printPreviewDialog2.ShowDialog();
            PrintDialog p2 = new PrintDialog();
            p2.Document = printDocument2;
            p2.AllowSelection = true;
            p2.AllowSomePages = true;
            if (p2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Program kapatılırsa günlük veri kaybı olabilir!\n" +
                "Programı kapatmak istediğinize emin misiniz?", "UYARI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.No)
            {
                e.Cancel = true;
            }
            if (secim == DialogResult.Yes)
            {

                Application.ExitThread();
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            int i = 0;
            int a = 0;
            i = 0;
            double eklenecekUrunFiyati;
            string eklenecekUrunAdi = textBox2.Text;
            try
            {
                if (!textBox3.Text.ToString().Contains(","))
                    eklenecekUrunFiyati = Double.Parse(textBox3.Text);
                else
                {
                    a++;
                    MessageBox.Show("Eklenecek Ürün Fiyatı\nVirgül İçermemelidir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    eklenecekUrunFiyati = 0;
                }


            }
            catch (Exception ex)
            {
                a++;
                MessageBox.Show("Eklenecek Ürün Fiyatı\nBoş veya Hatalı", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                eklenecekUrunFiyati = 0;
            }
            if (eklenecekUrunAdi == null
                    || !Regex.IsMatch(eklenecekUrunAdi, "^[öüÖÜĞğşŞçÇıİ|a-z|A-Z|0-9]{2,20}(\\s[öüÖÜĞğşŞçÇıİ|a-z|A-Z]{2,20}){0,3}$"))
            {
                a++;
                MessageBox.Show("Eksik yada hatalı ürün adı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            while (i < listBox1.Items.Count)
            {

                if (listBox1.Items[i].ToString() == eklenecekUrunAdi)
                {
                    a++;
                    MessageBox.Show("Bu isimde bir ürün zaten var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                i++;
            }
            if (a == 0)
            {
                listBox1.Items.Add(eklenecekUrunAdi);
                SqlCommand cm = new SqlCommand("Insert into DonerciOtomasyonu " +
                    "values (@urunadi,@urunfiyati)", con);
                cm.Parameters.AddWithValue("@urunadi", eklenecekUrunAdi);

                cm.Parameters.AddWithValue("@urunfiyati", eklenecekUrunFiyati);


                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                urunadvefiyatlari.Clear();
                SqlCommand com = new SqlCommand("Select * from DonerciOtomasyonu", con);

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    urunadvefiyatlari.Add(dr["Ürün Adı"].ToString(), Double.Parse(dr["Ürün Fiyatı"].ToString()));
                }
                con.Close();


                listBox1.Items.Clear();
                i = 0;
                while (i < urunadvefiyatlari.Count)
                {
                    listBox1.Items.Add(urunadvefiyatlari.ElementAt(i).Key);

                    i++;
                }
                textBox2.Text = "";
                textBox3.Text = "";
                //try
                //{
                //    SqlCommand cmd2 = new SqlCommand("Update DonerciOtomasyonu set " +
                //        "[Ürün Adedi]=@urunadedi, Toplam=@toplam", con);

                //    cmd2.Parameters.AddWithValue("@urunadedi", 0);
                //    cmd2.Parameters.AddWithValue("@toplam", 0);


                //    con.Open();
                //    cmd2.ExecuteNonQuery();
                //    con.Close();
                //}
                //catch (Exception ex)
                //{

                //}
                try
                {

                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DonerciOtomasyonu2", con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView2.AutoGenerateColumns = false;
                    dataGridView2.DataSource = table;
                    con.Close();



                }
                catch (Exception ex)
                {

                }
                MessageBox.Show("Ürün Ekleme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }




        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Bu işlem yapılırsa ürün hem sürekli kayıtlardan\nhem de siparişlerden silinecektir\nEmin misiniz?", "UYARI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.No)
            {

            }
            if (secim == DialogResult.Yes)
            {
                int a = 0;
                string silinecekUrunAdi;
                try
                {
                    silinecekUrunAdi = listBox1.SelectedItem.ToString();
                }
                catch (Exception ex)
                {
                    a++;
                    silinecekUrunAdi = null;
                }

                if (a == 0)
                {
                    try
                    {



                        SqlCommand cm = new SqlCommand("Delete from DonerciOtomasyonu where [Ürün Adı]=@urunadi", con);
                        cm.Parameters.AddWithValue("@urunadi", silinecekUrunAdi);
                        con.Open();
                        cm.ExecuteNonQuery();
                        con.Close();
                        urunadvefiyatlari.Clear();
                        int i = 0;
                        SqlCommand com = new SqlCommand("Select * from DonerciOtomasyonu", con);

                        con.Open();
                        SqlDataReader dr = com.ExecuteReader();
                        while (dr.Read())
                        {
                            urunadvefiyatlari.Add(dr["Ürün Adı"].ToString(), Double.Parse(dr["Ürün Fiyatı"].ToString()));
                        }
                        con.Close();


                        listBox1.Items.Clear();
                        i = 0;
                        while (i < urunadvefiyatlari.Count)
                        {
                            listBox1.Items.Add(urunadvefiyatlari.ElementAt(i).Key);

                            i++;
                        }

                    }
                    catch (Exception ex)
                    {

                    }
                    //try
                    //{
                    //    SqlCommand cmd2 = new SqlCommand("Update DonerciOtomasyonu set " +
                    //        "[Ürün Adedi]=@urunadedi, Toplam=@toplam", con);

                    //    cmd2.Parameters.AddWithValue("@urunadedi", 0);
                    //    cmd2.Parameters.AddWithValue("@toplam", 0);


                    //    con.Open();
                    //    cmd2.ExecuteNonQuery();
                    //    con.Close();
                    //}
                    //catch (Exception ex)
                    //{

                    //}
                    try
                    {

                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DonerciOtomasyonu2", con);
                        DataTable table = new DataTable();
                        da.Fill(table);
                        dataGridView2.AutoGenerateColumns = false;
                        dataGridView2.DataSource = table;
                        con.Close();



                    }
                    catch (Exception ex)
                    {

                    }
                    try
                    {
                        int rd;
                        rd = 0;
                        while (rd < dataGridView1.Rows.Count)
                        {
                            if (dataGridView1.Rows[rd].Cells[0].Value.ToString() == silinecekUrunAdi)
                            { dataGridView1.Rows.RemoveAt(rd); rd--; }
                            rd++;
                        }
                    }
                    catch (Exception ex) { }

                    MessageBox.Show("Silme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            double guncellenecekUrunFiyati;
            string guncellenecekUrunAdi;
            int index = listBox1.SelectedIndex;
            int a = 0;
            try
            {
                guncellenecekUrunAdi = listBox1.SelectedItem.ToString();


            }
            catch (Exception ex)
            {
                a++;
                guncellenecekUrunAdi = null;
                MessageBox.Show("Guncellenecek Ürün Adı\nBoş veya Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            try
            {
                if (!textBox4.Text.ToString().Contains(","))
                    guncellenecekUrunFiyati = Double.Parse(textBox4.Text);
                else
                {
                    a++;
                    MessageBox.Show("Güncellenecek Ürün Fiyatı\nVirgül İçermemelidir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    guncellenecekUrunFiyati = 0;
                }


            }
            catch (Exception ex)
            {
                a++;
                MessageBox.Show("Güncellenecek Ürün Fiyatı\nBoş veya Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                guncellenecekUrunFiyati = 0;
            }
            if (a == 0)
            {
                SqlCommand cm = new SqlCommand("Update DonerciOtomasyonu set [Ürün Fiyatı]=@urunfiyati where [Ürün Adı]=@urunadi", con);
                cm.Parameters.AddWithValue("@urunadi", guncellenecekUrunAdi);
                cm.Parameters.AddWithValue("@urunfiyati", guncellenecekUrunFiyati);
                con.Open();
                cm.ExecuteNonQuery();
                con.Close();
                urunadvefiyatlari.Clear();
                int i = 0;
                SqlCommand com = new SqlCommand("Select * from DonerciOtomasyonu", con);

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    urunadvefiyatlari.Add(dr["Ürün Adı"].ToString(), Double.Parse(dr["Ürün Fiyatı"].ToString()));
                }
                con.Close();


                listBox1.Items.Clear();
                i = 0;
                while (i < urunadvefiyatlari.Count)
                {
                    listBox1.Items.Add(urunadvefiyatlari.ElementAt(i).Key);

                    i++;
                }
                try
                {

                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DonerciOtomasyonu2", con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView2.AutoGenerateColumns = false;
                    dataGridView2.DataSource = table;
                    con.Close();



                }
                catch (Exception ex)
                {

                }
                textBox4.Text = "";
                MessageBox.Show("Fiyat Güncelleme Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Question);
                listBox1.SelectedIndex = index;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Bunu yaparsanız veritabanı sıfırlanacaktır.\nBu önceki verilerin kaybına neden olabilir!\nEmin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.No)
            {

            }
            if (secim == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd2 = new SqlCommand("Truncate table DonerciOtomasyonu2", con);

                    


                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {

                }
                try
                {

                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DonerciOtomasyonu2", con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView2.AutoGenerateColumns = false;
                    dataGridView2.DataSource = table;
                    con.Close();



                }
                catch (Exception ex)
                {

                }
                MessageBox.Show("Veritabanı Sıfırlama İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
    }
}
