
namespace Otopark_Otomasyonu
{
    partial class formAracGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboAracTur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGirisTarihi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPlaka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboParkYer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textAboneKimlik = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboAboneTur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Türü:";
            // 
            // comboAracTur
            // 
            this.comboAracTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAracTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboAracTur.FormattingEnabled = true;
            this.comboAracTur.Location = new System.Drawing.Point(133, 329);
            this.comboAracTur.Name = "comboAracTur";
            this.comboAracTur.Size = new System.Drawing.Size(206, 32);
            this.comboAracTur.TabIndex = 1;
            this.comboAracTur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giriş Tarihi:";
            // 
            // labelGirisTarihi
            // 
            this.labelGirisTarihi.AutoSize = true;
            this.labelGirisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGirisTarihi.Location = new System.Drawing.Point(149, 291);
            this.labelGirisTarihi.Name = "labelGirisTarihi";
            this.labelGirisTarihi.Size = new System.Drawing.Size(16, 24);
            this.labelGirisTarihi.TabIndex = 3;
            this.labelGirisTarihi.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(149, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plaka ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Plaka:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textPlaka
            // 
            this.textPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPlaka.Location = new System.Drawing.Point(130, 164);
            this.textPlaka.Name = "textPlaka";
            this.textPlaka.Size = new System.Drawing.Size(212, 29);
            this.textPlaka.TabIndex = 6;
            this.textPlaka.TextChanged += new System.EventHandler(this.textPlaka_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Park Yeri:";
            // 
            // comboParkYer
            // 
            this.comboParkYer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParkYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboParkYer.FormattingEnabled = true;
            this.comboParkYer.Items.AddRange(new object[] {
            "HATA"});
            this.comboParkYer.Location = new System.Drawing.Point(133, 381);
            this.comboParkYer.Name = "comboParkYer";
            this.comboParkYer.Size = new System.Drawing.Size(206, 32);
            this.comboParkYer.TabIndex = 11;
            this.comboParkYer.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Araç Sahibi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(126, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Açıklama";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 477);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(324, 65);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Otopark_Otomasyonu.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textAboneKimlik
            // 
            this.textAboneKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAboneKimlik.Location = new System.Drawing.Point(130, 199);
            this.textAboneKimlik.Name = "textAboneKimlik";
            this.textAboneKimlik.Size = new System.Drawing.Size(175, 29);
            this.textAboneKimlik.TabIndex = 17;
            this.textAboneKimlik.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 29);
            this.button2.TabIndex = 18;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.Location = new System.Drawing.Point(8, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Abonelik Türü:";
            // 
            // comboAboneTur
            // 
            this.comboAboneTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAboneTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboAboneTur.FormattingEnabled = true;
            this.comboAboneTur.Items.AddRange(new object[] {
            "Saatlik Hesaplanacak",
            "1 Ay ",
            "1-3 Ay ",
            "3-6 Ay ",
            "6-12 Ay"});
            this.comboAboneTur.Location = new System.Drawing.Point(164, 249);
            this.comboAboneTur.Name = "comboAboneTur";
            this.comboAboneTur.Size = new System.Drawing.Size(178, 26);
            this.comboAboneTur.TabIndex = 33;
            // 
            // formAracGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(348, 591);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboAboneTur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textAboneKimlik);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboParkYer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textPlaka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelGirisTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboAracTur);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Name = "formAracGiris";
            this.ShowInTaskbar = false;
            this.Text = "Yeni Kayıt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboAracTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGirisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPlaka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboParkYer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textAboneKimlik;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboAboneTur;
    }
}