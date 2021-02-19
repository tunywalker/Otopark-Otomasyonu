namespace Otopark_Otomasyonu
{
    partial class kameraEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelHata = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.checkAktif = new System.Windows.Forms.CheckBox();
            this.comboLokasyon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkYabanci = new System.Windows.Forms.CheckBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.comboYontem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFiligran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textKadi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.checkAktif);
            this.groupBox1.Controls.Add(this.comboLokasyon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkYabanci);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.comboYontem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textFiligran);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textKadi);
            this.groupBox1.Location = new System.Drawing.Point(214, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelHata
            // 
            this.labelHata.AutoSize = true;
            this.labelHata.ForeColor = System.Drawing.Color.Red;
            this.labelHata.Location = new System.Drawing.Point(35, 9);
            this.labelHata.Name = "labelHata";
            this.labelHata.Size = new System.Drawing.Size(49, 17);
            this.labelHata.TabIndex = 13;
            this.labelHata.Text = "HATA";
            this.labelHata.Click += new System.EventHandler(this.labelHata_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(96, 222);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(93, 23);
            this.buttonGuncelle.TabIndex = 20;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // checkAktif
            // 
            this.checkAktif.AutoSize = true;
            this.checkAktif.Location = new System.Drawing.Point(211, 179);
            this.checkAktif.Name = "checkAktif";
            this.checkAktif.Size = new System.Drawing.Size(62, 21);
            this.checkAktif.TabIndex = 19;
            this.checkAktif.Text = "Aktif";
            this.checkAktif.UseVisualStyleBackColor = true;
            // 
            // comboLokasyon
            // 
            this.comboLokasyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLokasyon.FormattingEnabled = true;
            this.comboLokasyon.Items.AddRange(new object[] {
            "Giriş",
            "Çıkış"});
            this.comboLokasyon.Location = new System.Drawing.Point(107, 142);
            this.comboLokasyon.Name = "comboLokasyon";
            this.comboLokasyon.Size = new System.Drawing.Size(140, 25);
            this.comboLokasyon.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lokasyon: ";
            // 
            // checkYabanci
            // 
            this.checkYabanci.AutoSize = true;
            this.checkYabanci.Location = new System.Drawing.Point(12, 179);
            this.checkYabanci.Name = "checkYabanci";
            this.checkYabanci.Size = new System.Drawing.Size(177, 21);
            this.checkYabanci.TabIndex = 16;
            this.checkYabanci.Text = "Sadece Üyeleri Tanı";
            this.checkYabanci.UseVisualStyleBackColor = true;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(96, 222);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(87, 23);
            this.buttonEkle.TabIndex = 15;
            this.buttonEkle.Text = "Kaydet";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboYontem
            // 
            this.comboYontem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYontem.FormattingEnabled = true;
            this.comboYontem.Items.AddRange(new object[] {
            "Sürekli Tarama ",
            "Harekete Duyarlı"});
            this.comboYontem.Location = new System.Drawing.Point(107, 60);
            this.comboYontem.Name = "comboYontem";
            this.comboYontem.Size = new System.Drawing.Size(140, 25);
            this.comboYontem.TabIndex = 14;
            this.comboYontem.SelectedIndexChanged += new System.EventHandler(this.comboYontem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filigran:";
            // 
            // textFiligran
            // 
            this.textFiligran.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textFiligran.Location = new System.Drawing.Point(107, 97);
            this.textFiligran.Name = "textFiligran";
            this.textFiligran.Size = new System.Drawing.Size(140, 23);
            this.textFiligran.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yöntem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kamera Adı:";
            // 
            // textKadi
            // 
            this.textKadi.Location = new System.Drawing.Point(107, 24);
            this.textKadi.Name = "textKadi";
            this.textKadi.Size = new System.Drawing.Size(140, 23);
            this.textKadi.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 191);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSil);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 264);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kameralar";
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(54, 222);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(43, 31);
            this.buttonSil.TabIndex = 22;
            this.buttonSil.Text = "-";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 17;
            this.listBox2.Location = new System.Drawing.Point(6, 158);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(180, 38);
            this.listBox2.TabIndex = 11;
            this.listBox2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // kameraEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 298);
            this.Controls.Add(this.labelHata);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "kameraEkle";
            this.Text = "Kameralar";
            this.Load += new System.EventHandler(this.kameraEkle_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kameraEkle_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkYabanci;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.ComboBox comboYontem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFiligran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKadi;
        private System.Windows.Forms.CheckBox checkAktif;
        private System.Windows.Forms.ComboBox comboLokasyon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHata;
        private System.Windows.Forms.Timer timer1;
    }
}