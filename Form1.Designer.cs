namespace döviz_kur_hesabı_deneme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hsplbttn = new System.Windows.Forms.Button();
            this.tmzlbttn = new System.Windows.Forms.Button();
            this.kptbttn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdeger = new System.Windows.Forms.TextBox();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.txtkur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfrang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtyuan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtrus = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtyen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtkron = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmanat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdolar = new System.Windows.Forms.TextBox();
            this.txteuro = new System.Windows.Forms.TextBox();
            this.txtsterlin = new System.Windows.Forms.TextBox();
            this.txtdinar = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txttarih = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(142, -39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 30);
            this.label15.TabIndex = 10005;
            this.label15.Text = "Döviz Kurları Dönüştürücü";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtdeger);
            this.groupBox2.Controls.Add(this.txtsonuc);
            this.groupBox2.Location = new System.Drawing.Point(287, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 350);
            this.groupBox2.TabIndex = 10004;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dönüştür";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(230, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(185, 17);
            this.label16.TabIndex = 10010;
            this.label16.Text = "Dönüştürülecek Para Birimi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hsplbttn);
            this.panel1.Controls.Add(this.tmzlbttn);
            this.panel1.Controls.Add(this.kptbttn);
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 90);
            this.panel1.TabIndex = 29;
            // 
            // hsplbttn
            // 
            this.hsplbttn.BackColor = System.Drawing.Color.Lime;
            this.hsplbttn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hsplbttn.Location = new System.Drawing.Point(0, 0);
            this.hsplbttn.Name = "hsplbttn";
            this.hsplbttn.Size = new System.Drawing.Size(138, 90);
            this.hsplbttn.TabIndex = 1;
            this.hsplbttn.Text = "DÖNÜŞTÜR";
            this.hsplbttn.UseVisualStyleBackColor = false;
            this.hsplbttn.Click += new System.EventHandler(this.hsplbttn_Click);
            // 
            // tmzlbttn
            // 
            this.tmzlbttn.BackColor = System.Drawing.Color.Blue;
            this.tmzlbttn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tmzlbttn.Location = new System.Drawing.Point(138, 0);
            this.tmzlbttn.Name = "tmzlbttn";
            this.tmzlbttn.Size = new System.Drawing.Size(138, 90);
            this.tmzlbttn.TabIndex = 2;
            this.tmzlbttn.Text = "TEMİZLE";
            this.tmzlbttn.UseVisualStyleBackColor = false;
            this.tmzlbttn.Click += new System.EventHandler(this.tmzlbttn_Click);
            // 
            // kptbttn
            // 
            this.kptbttn.BackColor = System.Drawing.Color.Red;
            this.kptbttn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.kptbttn.Location = new System.Drawing.Point(276, 0);
            this.kptbttn.Name = "kptbttn";
            this.kptbttn.Size = new System.Drawing.Size(138, 90);
            this.kptbttn.TabIndex = 3;
            this.kptbttn.Text = "KAPAT";
            this.kptbttn.UseVisualStyleBackColor = false;
            this.kptbttn.Click += new System.EventHandler(this.kptbttn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(88, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Paranın Değeri";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DOLAR",
            "EURO",
            "KUVEYT DİNARI",
            "İNGİLİZ STERLİNİ",
            "AZERBAYCAN MANATI",
            "NORVEÇ KRONU",
            "JAPON YENİ",
            "RUS RUBLESİ",
            "ÇİN YUANI",
            "İSVİÇRE FRANGI"});
            this.comboBox1.Location = new System.Drawing.Point(233, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 10007;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Dönüşecek Para Birimi Miktarı";
            // 
            // txtdeger
            // 
            this.txtdeger.Location = new System.Drawing.Point(14, 60);
            this.txtdeger.Name = "txtdeger";
            this.txtdeger.Size = new System.Drawing.Size(97, 20);
            this.txtdeger.TabIndex = 0;
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(199, 125);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(97, 20);
            this.txtsonuc.TabIndex = 25;
            // 
            // txtkur
            // 
            this.txtkur.Location = new System.Drawing.Point(593, 12);
            this.txtkur.Name = "txtkur";
            this.txtkur.Size = new System.Drawing.Size(23, 20);
            this.txtkur.TabIndex = 21;
            this.txtkur.TabStop = false;
            this.txtkur.Visible = false;
            this.txtkur.TextChanged += new System.EventHandler(this.txtkur_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtfrang);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtyuan);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtrus);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtyen);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtkron);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmanat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdolar);
            this.groupBox1.Controls.Add(this.txteuro);
            this.groupBox1.Controls.Add(this.txtsterlin);
            this.groupBox1.Controls.Add(this.txtdinar);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 375);
            this.groupBox1.TabIndex = 10003;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncel Kurlar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 15);
            this.label11.TabIndex = 170044;
            this.label11.Text = "İSVİÇRE FRANGI";
            // 
            // txtfrang
            // 
            this.txtfrang.Location = new System.Drawing.Point(173, 340);
            this.txtfrang.Name = "txtfrang";
            this.txtfrang.Size = new System.Drawing.Size(86, 20);
            this.txtfrang.TabIndex = 170045;
            this.txtfrang.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 170041;
            this.label9.Text = "ÇİN YUANI\t";
            // 
            // txtyuan
            // 
            this.txtyuan.Location = new System.Drawing.Point(173, 305);
            this.txtyuan.Name = "txtyuan";
            this.txtyuan.Size = new System.Drawing.Size(86, 20);
            this.txtyuan.TabIndex = 170042;
            this.txtyuan.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 170038;
            this.label12.Text = "RUS RUBLESİ\t";
            // 
            // txtrus
            // 
            this.txtrus.Location = new System.Drawing.Point(173, 270);
            this.txtrus.Name = "txtrus";
            this.txtrus.Size = new System.Drawing.Size(86, 20);
            this.txtrus.TabIndex = 170039;
            this.txtrus.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 170035;
            this.label13.Text = "JAPON YENİ\t";
            // 
            // txtyen
            // 
            this.txtyen.Location = new System.Drawing.Point(173, 235);
            this.txtyen.Name = "txtyen";
            this.txtyen.Size = new System.Drawing.Size(86, 20);
            this.txtyen.TabIndex = 170036;
            this.txtyen.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 15);
            this.label14.TabIndex = 170032;
            this.label14.Text = "NORVEÇ KRONU\t";
            // 
            // txtkron
            // 
            this.txtkron.Location = new System.Drawing.Point(173, 200);
            this.txtkron.Name = "txtkron";
            this.txtkron.Size = new System.Drawing.Size(86, 20);
            this.txtkron.TabIndex = 170033;
            this.txtkron.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "AZERBAYCAN MANATI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "İNGİLİZ STERLİNİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "KUVEYT DİNARI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "EURO";
            // 
            // txtmanat
            // 
            this.txtmanat.Location = new System.Drawing.Point(173, 165);
            this.txtmanat.Name = "txtmanat";
            this.txtmanat.Size = new System.Drawing.Size(86, 20);
            this.txtmanat.TabIndex = 5999;
            this.txtmanat.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOLAR";
            // 
            // txtdolar
            // 
            this.txtdolar.Location = new System.Drawing.Point(173, 25);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.Size = new System.Drawing.Size(86, 20);
            this.txtdolar.TabIndex = 199;
            this.txtdolar.TabStop = false;
            // 
            // txteuro
            // 
            this.txteuro.Location = new System.Drawing.Point(173, 60);
            this.txteuro.Name = "txteuro";
            this.txteuro.Size = new System.Drawing.Size(86, 20);
            this.txteuro.TabIndex = 299;
            this.txteuro.TabStop = false;
            // 
            // txtsterlin
            // 
            this.txtsterlin.Location = new System.Drawing.Point(173, 130);
            this.txtsterlin.Name = "txtsterlin";
            this.txtsterlin.Size = new System.Drawing.Size(86, 20);
            this.txtsterlin.TabIndex = 499;
            this.txtsterlin.TabStop = false;
            // 
            // txtdinar
            // 
            this.txtdinar.Location = new System.Drawing.Point(173, 95);
            this.txtdinar.Name = "txtdinar";
            this.txtdinar.Size = new System.Drawing.Size(86, 20);
            this.txtdinar.TabIndex = 3999;
            this.txtdinar.TabStop = false;
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(645, 12);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(68, 20);
            this.txttarih.TabIndex = 10006;
            this.txttarih.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::döviz_kur_hesabı_deneme.Properties.Resources.wallpaperbetter_com_1366x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(721, 399);
            this.Controls.Add(this.txttarih);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtkur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz Kuru Dönüştürücü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hsplbttn;
        private System.Windows.Forms.Button tmzlbttn;
        private System.Windows.Forms.Button kptbttn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdeger;
        private System.Windows.Forms.TextBox txtkur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfrang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtyuan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtrus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtyen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtkron;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmanat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdolar;
        private System.Windows.Forms.TextBox txteuro;
        private System.Windows.Forms.TextBox txtsterlin;
        private System.Windows.Forms.TextBox txtdinar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txttarih;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label16;
    }
}

