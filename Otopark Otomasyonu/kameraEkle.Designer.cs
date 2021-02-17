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
            this.checkAktif = new System.Windows.Forms.CheckBox();
            this.comboLokasyon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkYabanci = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboYontem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFiligran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textKadi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkAktif);
            this.groupBox1.Controls.Add(this.comboLokasyon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkYabanci);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboYontem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textFiligran);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textKadi);
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 253);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kamera Ekle/Düzenle";
            // 
            // checkAktif
            // 
            this.checkAktif.AutoSize = true;
            this.checkAktif.Location = new System.Drawing.Point(191, 179);
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
            this.checkYabanci.Location = new System.Drawing.Point(-1, 179);
            this.checkYabanci.Name = "checkYabanci";
            this.checkYabanci.Size = new System.Drawing.Size(186, 21);
            this.checkYabanci.TabIndex = 16;
            this.checkYabanci.Text = "Yabancı Araçları Tanı";
            this.checkYabanci.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label1.Location = new System.Drawing.Point(21, 27);
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
            this.listBox1.Location = new System.Drawing.Point(7, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 174);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 253);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kameralar";
            // 
            // kameraEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 271);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "kameraEkle";
            this.Text = "Kameralar";
            this.Load += new System.EventHandler(this.kameraEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkYabanci;
        private System.Windows.Forms.Button button1;
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
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}