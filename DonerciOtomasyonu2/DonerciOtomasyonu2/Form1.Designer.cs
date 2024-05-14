namespace DonerciOtomasyonu2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            button1 = new Button();
            panel1 = new Panel();
            listBox10 = new ListBox();
            listBox9 = new ListBox();
            textBox4 = new TextBox();
            label7 = new Label();
            button10 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button9 = new Button();
            button8 = new Button();
            listBox8 = new ListBox();
            listBox7 = new ListBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            textBox1 = new TextBox();
            label1 = new Label();
            button4 = new Button();
            textBox14 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox15 = new TextBox();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            textBox16 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog2 = new PrintPreviewDialog();
            button7 = new Button();
            printDialog1 = new PrintDialog();
            printDialog2 = new PrintDialog();
            button11 = new Button();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Tarih = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 215);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(293, 109);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Normal Ekmekli", "Yarım-Ekmekli", "1.5-Ekmekli", "2-Ekmekli", "2.5-Ekmekli", "3-Ekmekli" });
            listBox2.Location = new Point(24, 350);
            listBox2.Margin = new Padding(4, 3, 4, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(139, 94);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Items.AddRange(new object[] { "Normal Ketçaplı", "Az-Ketçaplı", "Ketçapsız", "Bol-Ketçaplı" });
            listBox3.Location = new Point(178, 350);
            listBox3.Margin = new Padding(4, 3, 4, 3);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(139, 94);
            listBox3.TabIndex = 2;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Items.AddRange(new object[] { "Normal Soslu", "Az-Soslu", "Sossuz", "Bol-Soslu" });
            listBox4.Location = new Point(24, 463);
            listBox4.Margin = new Padding(4, 3, 4, 3);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(139, 94);
            listBox4.TabIndex = 3;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Items.AddRange(new object[] { "Normal Mayonezli", "Az-Mayonezli", "Mayonezsiz", "Bol-Mayonezli" });
            listBox5.Location = new Point(335, 350);
            listBox5.Margin = new Padding(4, 3, 4, 3);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(139, 94);
            listBox5.TabIndex = 4;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Items.AddRange(new object[] { "Normal Salatalı", "Az-Salatalı", "Salatasız", "Bol-Salatalı" });
            listBox6.Location = new Point(178, 463);
            listBox6.Margin = new Padding(4, 3, 4, 3);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(139, 94);
            listBox6.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(335, 297);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(139, 27);
            button1.TabIndex = 6;
            button1.Text = "Ürünü Siparişe Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox10);
            panel1.Controls.Add(listBox9);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox8);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(listBox7);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(listBox3);
            panel1.Controls.Add(listBox5);
            panel1.Controls.Add(listBox6);
            panel1.Controls.Add(listBox4);
            panel1.Location = new Point(13, 1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 680);
            panel1.TabIndex = 7;
            // 
            // listBox10
            // 
            listBox10.FormattingEnabled = true;
            listBox10.ItemHeight = 15;
            listBox10.Items.AddRange(new object[] { "Normal Yağlı", "Az-Yağlı", "Yağsız", "Bol-Yağlı" });
            listBox10.Location = new Point(335, 573);
            listBox10.Margin = new Padding(4, 3, 4, 3);
            listBox10.Name = "listBox10";
            listBox10.Size = new Size(139, 94);
            listBox10.TabIndex = 19;
            // 
            // listBox9
            // 
            listBox9.FormattingEnabled = true;
            listBox9.ItemHeight = 15;
            listBox9.Items.AddRange(new object[] { "Normal Acılı", "Az-Acılı", "Acısız", "Bol-Acılı" });
            listBox9.Location = new Point(178, 573);
            listBox9.Margin = new Padding(4, 3, 4, 3);
            listBox9.Name = "listBox9";
            listBox9.Size = new Size(139, 94);
            listBox9.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(343, 124);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 23);
            textBox4.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(193, 132);
            label7.Name = "label7";
            label7.Size = new Size(144, 15);
            label7.TabIndex = 16;
            label7.Text = "Güncellenecek Ürün Fiyatı";
            // 
            // button10
            // 
            button10.Location = new Point(24, 123);
            button10.Name = "button10";
            button10.Size = new Size(146, 23);
            button10.TabIndex = 15;
            button10.Text = "Ürün Fiyatı Güncelle";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(343, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 23);
            textBox2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 70);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 12;
            label6.Text = "Eklenecek Ürün Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 34);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 11;
            label5.Text = "Eklenecek Ürün Adı";
            // 
            // button9
            // 
            button9.Location = new Point(24, 177);
            button9.Name = "button9";
            button9.Size = new Size(166, 23);
            button9.TabIndex = 10;
            button9.Text = "Ürün Listesinden Ürün Sil";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // button8
            // 
            button8.Location = new Point(24, 69);
            button8.Name = "button8";
            button8.Size = new Size(146, 23);
            button8.TabIndex = 9;
            button8.Text = "Lİsteye Ürün Ekle";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // listBox8
            // 
            listBox8.FormattingEnabled = true;
            listBox8.ItemHeight = 15;
            listBox8.Items.AddRange(new object[] { "Normal Soğanlı", "Az-Soğanlı", "Soğansız", "Bol-Soğanlı" });
            listBox8.Location = new Point(24, 573);
            listBox8.Margin = new Padding(4, 3, 4, 3);
            listBox8.Name = "listBox8";
            listBox8.Size = new Size(139, 94);
            listBox8.TabIndex = 8;
            // 
            // listBox7
            // 
            listBox7.FormattingEnabled = true;
            listBox7.ItemHeight = 15;
            listBox7.Items.AddRange(new object[] { "Normal Patatesli", "Az-Patatesli", "Patatessiz", "Bol-Patatesli" });
            listBox7.Location = new Point(335, 463);
            listBox7.Margin = new Padding(4, 3, 4, 3);
            listBox7.Name = "listBox7";
            listBox7.Size = new Size(139, 94);
            listBox7.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4, Column5 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(530, 27);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(291, 396);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.RowStateChanged += dataGridView1_RowStateChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Ürün Adı";
            Column1.FillWeight = 95.98756F;
            Column1.HeaderText = "Ürün Adı";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Ürün Adedi";
            Column3.FillWeight = 82.10016F;
            Column3.HeaderText = "Ürün Adedi";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Ürün Fiyatı";
            Column2.FillWeight = 67.35352F;
            Column2.HeaderText = "Ürün Fiyatı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Toplam";
            Column4.FillWeight = 87.04592F;
            Column4.HeaderText = "Toplam";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Özellik";
            Column5.FillWeight = 167.5126F;
            Column5.HeaderText = "Özellik";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // button2
            // 
            button2.Location = new Point(530, 484);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(140, 27);
            button2.TabIndex = 98;
            button2.Text = "Yanlış Girilen Kaydı Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(530, 531);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(140, 27);
            button3.TabIndex = 99;
            button3.Text = "Siparişi Sıfırla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(530, 451);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 100;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 432);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 101;
            label1.Text = "Toplam";
            // 
            // button4
            // 
            button4.Location = new Point(705, 586);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(117, 27);
            button4.TabIndex = 102;
            button4.Text = "Siparişi Yazdır";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(705, 451);
            textBox14.Margin = new Padding(4, 3, 4, 3);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(116, 23);
            textBox14.TabIndex = 103;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 432);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 104;
            label2.Text = "Müşteri Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(701, 491);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 106;
            label3.Text = "Müşteri Adres";
            label3.Click += label3_Click;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(705, 507);
            textBox15.Margin = new Padding(4, 3, 4, 3);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(116, 51);
            textBox15.TabIndex = 105;
            textBox15.TextChanged += textBox15_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Tarih });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Location = new Point(1019, 27);
            dataGridView2.Margin = new Padding(4, 3, 4, 3);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(294, 479);
            dataGridView2.TabIndex = 107;
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
            dataGridView2.RowsAdded += dataGridView2_RowsAdded;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1089, 520);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 109;
            label4.Text = "Toplam";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(1145, 512);
            textBox16.Margin = new Padding(4, 3, 4, 3);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(168, 23);
            textBox16.TabIndex = 108;
            // 
            // button5
            // 
            button5.Location = new Point(1145, 545);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(169, 27);
            button5.TabIndex = 110;
            button5.Text = "Yanlış Girilen Kaydı Sil";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1145, 580);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(169, 27);
            button6.TabIndex = 111;
            button6.Text = "Veri Tabanından Veri Çek";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // printDocument2
            // 
            printDocument2.PrintPage += printDocument2_PrintPage;
            // 
            // printPreviewDialog2
            // 
            printPreviewDialog2.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog2.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog2.ClientSize = new Size(400, 300);
            printPreviewDialog2.Enabled = true;
            printPreviewDialog2.Icon = (Icon)resources.GetObject("printPreviewDialog2.Icon");
            printPreviewDialog2.Name = "printPreviewDialog2";
            printPreviewDialog2.Visible = false;
            // 
            // button7
            // 
            button7.Location = new Point(1145, 650);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(169, 27);
            button7.TabIndex = 112;
            button7.Text = "Sürekli Satışları Yazdır";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            printDialog2.UseEXDialog = true;
            // 
            // button11
            // 
            button11.Location = new Point(1145, 615);
            button11.Margin = new Padding(4, 3, 4, 3);
            button11.Name = "button11";
            button11.Size = new Size(169, 27);
            button11.TabIndex = 113;
            button11.Text = "Veri Tabanını Sıfırla";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Ürün Adı";
            Column6.FillWeight = 111.1935F;
            Column6.HeaderText = "Ürün Adı";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Ürün Adedi";
            Column7.FillWeight = 69.7393951F;
            Column7.HeaderText = "Ürün Adedi";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Ürün Fiyatı";
            Column8.FillWeight = 78.53015F;
            Column8.HeaderText = "Ürün Fiyatı";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Toplam";
            Column9.FillWeight = 88.2526855F;
            Column9.HeaderText = "Toplam";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Tarih
            // 
            Tarih.DataPropertyName = "Tarih";
            Tarih.FillWeight = 152.284256F;
            Tarih.HeaderText = "Tarih";
            Tarih.Name = "Tarih";
            Tarih.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(button11);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(textBox16);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(textBox15);
            Controls.Add(label2);
            Controls.Add(textBox14);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private Button button1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private TextBox textBox1;
        private Label label1;
        private Button button4;
        private TextBox textBox14;
        private Label label2;
        private Label label3;
        private TextBox textBox15;
        private DataGridView dataGridView2;
        private Label label4;
        private TextBox textBox16;
        private Button button5;
        private Button button6;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private PrintPreviewDialog printPreviewDialog2;
        private Button button7;
        private PrintDialog printDialog1;
        private PrintDialog printDialog2;
        private ListBox listBox7;
        private ListBox listBox8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button8;
        private Label label6;
        private Label label5;
        private Button button9;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label7;
        private Button button10;
        private TextBox textBox4;
        private ListBox listBox10;
        private ListBox listBox9;
        private Button button11;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Tarih;
    }
}

