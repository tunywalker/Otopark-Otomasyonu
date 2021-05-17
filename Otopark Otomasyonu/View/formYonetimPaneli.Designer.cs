
namespace Otopark_Otomasyonu.View
{
    partial class formYonetimPaneli
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFtSil = new System.Windows.Forms.Button();
            this.buttonFtGuncelle = new System.Windows.Forms.Button();
            this.buttonFtEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textFiyat = new System.Windows.Forms.TextBox();
            this.textKisaltma = new System.Windows.Forms.TextBox();
            this.textUzunAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonYeniAt = new System.Windows.Forms.Button();
            this.buttonAtSil = new System.Windows.Forms.Button();
            this.buttonAtGuncelle = new System.Windows.Forms.Button();
            this.buttonAtEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textAtFiyat = new System.Windows.Forms.TextBox();
            this.textAtSure = new System.Windows.Forms.TextBox();
            this.textAtAd = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonFtSil);
            this.groupBox1.Controls.Add(this.buttonFtGuncelle);
            this.groupBox1.Controls.Add(this.buttonFtEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textFiyat);
            this.groupBox1.Controls.Add(this.textKisaltma);
            this.groupBox1.Controls.Add(this.textUzunAd);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(431, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyat Tarifeleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(356, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFtSil
            // 
            this.buttonFtSil.Enabled = false;
            this.buttonFtSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFtSil.Location = new System.Drawing.Point(356, 63);
            this.buttonFtSil.Name = "buttonFtSil";
            this.buttonFtSil.Size = new System.Drawing.Size(25, 38);
            this.buttonFtSil.TabIndex = 1;
            this.buttonFtSil.Text = "-";
            this.buttonFtSil.UseVisualStyleBackColor = true;
            this.buttonFtSil.Click += new System.EventHandler(this.buttonFtSil_Click);
            // 
            // buttonFtGuncelle
            // 
            this.buttonFtGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFtGuncelle.Location = new System.Drawing.Point(204, 203);
            this.buttonFtGuncelle.Name = "buttonFtGuncelle";
            this.buttonFtGuncelle.Size = new System.Drawing.Size(89, 23);
            this.buttonFtGuncelle.TabIndex = 7;
            this.buttonFtGuncelle.Text = "Güncelle";
            this.buttonFtGuncelle.UseVisualStyleBackColor = true;
            this.buttonFtGuncelle.Click += new System.EventHandler(this.buttonFtGuncelle_Click);
            // 
            // buttonFtEkle
            // 
            this.buttonFtEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFtEkle.Location = new System.Drawing.Point(204, 203);
            this.buttonFtEkle.Name = "buttonFtEkle";
            this.buttonFtEkle.Size = new System.Drawing.Size(89, 23);
            this.buttonFtEkle.TabIndex = 6;
            this.buttonFtEkle.Text = "Kaydet";
            this.buttonFtEkle.UseVisualStyleBackColor = true;
            this.buttonFtEkle.Click += new System.EventHandler(this.buttonFtEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tam Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(222, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kısaltma:";
            // 
            // textFiyat
            // 
            this.textFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textFiyat.Location = new System.Drawing.Point(83, 203);
            this.textFiyat.Name = "textFiyat";
            this.textFiyat.Size = new System.Drawing.Size(100, 22);
            this.textFiyat.TabIndex = 2;
            this.textFiyat.TextChanged += new System.EventHandler(this.textFiyat_TextChanged);
            // 
            // textKisaltma
            // 
            this.textKisaltma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKisaltma.Location = new System.Drawing.Point(299, 175);
            this.textKisaltma.Name = "textKisaltma";
            this.textKisaltma.Size = new System.Drawing.Size(51, 22);
            this.textKisaltma.TabIndex = 1;
            this.textKisaltma.TextChanged += new System.EventHandler(this.textKisaltma_TextChanged);
            // 
            // textUzunAd
            // 
            this.textUzunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textUzunAd.Location = new System.Drawing.Point(83, 175);
            this.textUzunAd.Name = "textUzunAd";
            this.textUzunAd.Size = new System.Drawing.Size(133, 22);
            this.textUzunAd.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonYeniAt);
            this.groupBox2.Controls.Add(this.buttonAtSil);
            this.groupBox2.Controls.Add(this.buttonAtGuncelle);
            this.groupBox2.Controls.Add(this.buttonAtEkle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textAtFiyat);
            this.groupBox2.Controls.Add(this.textAtSure);
            this.groupBox2.Controls.Add(this.textAtAd);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abonelik Türleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonYeniAt
            // 
            this.buttonYeniAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYeniAt.Location = new System.Drawing.Point(356, 19);
            this.buttonYeniAt.Name = "buttonYeniAt";
            this.buttonYeniAt.Size = new System.Drawing.Size(25, 38);
            this.buttonYeniAt.TabIndex = 1;
            this.buttonYeniAt.Text = "+";
            this.buttonYeniAt.UseVisualStyleBackColor = true;
            this.buttonYeniAt.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAtSil
            // 
            this.buttonAtSil.Enabled = false;
            this.buttonAtSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAtSil.Location = new System.Drawing.Point(356, 63);
            this.buttonAtSil.Name = "buttonAtSil";
            this.buttonAtSil.Size = new System.Drawing.Size(25, 38);
            this.buttonAtSil.TabIndex = 1;
            this.buttonAtSil.Text = "-";
            this.buttonAtSil.UseVisualStyleBackColor = true;
            this.buttonAtSil.Click += new System.EventHandler(this.buttonAtSil_Click);
            // 
            // buttonAtGuncelle
            // 
            this.buttonAtGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAtGuncelle.Location = new System.Drawing.Point(224, 203);
            this.buttonAtGuncelle.Name = "buttonAtGuncelle";
            this.buttonAtGuncelle.Size = new System.Drawing.Size(89, 23);
            this.buttonAtGuncelle.TabIndex = 7;
            this.buttonAtGuncelle.Text = "Güncelle";
            this.buttonAtGuncelle.UseVisualStyleBackColor = true;
            this.buttonAtGuncelle.Click += new System.EventHandler(this.buttonAtGuncelle_Click);
            // 
            // buttonAtEkle
            // 
            this.buttonAtEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAtEkle.Location = new System.Drawing.Point(224, 203);
            this.buttonAtEkle.Name = "buttonAtEkle";
            this.buttonAtEkle.Size = new System.Drawing.Size(89, 23);
            this.buttonAtEkle.TabIndex = 6;
            this.buttonAtEkle.Text = "Kaydet";
            this.buttonAtEkle.UseVisualStyleBackColor = true;
            this.buttonAtEkle.Click += new System.EventHandler(this.buttonAtEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tam Ad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(221, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Süre(Gün)";
            // 
            // textAtFiyat
            // 
            this.textAtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAtFiyat.Location = new System.Drawing.Point(83, 203);
            this.textAtFiyat.Name = "textAtFiyat";
            this.textAtFiyat.Size = new System.Drawing.Size(100, 22);
            this.textAtFiyat.TabIndex = 2;
            this.textAtFiyat.TextChanged += new System.EventHandler(this.textAtFiyat_TextChanged);
            // 
            // textAtSure
            // 
            this.textAtSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAtSure.Location = new System.Drawing.Point(317, 178);
            this.textAtSure.Name = "textAtSure";
            this.textAtSure.Size = new System.Drawing.Size(51, 22);
            this.textAtSure.TabIndex = 1;
            this.textAtSure.TextChanged += new System.EventHandler(this.textAtSure_TextChanged);
            // 
            // textAtAd
            // 
            this.textAtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAtAd.Location = new System.Drawing.Point(83, 175);
            this.textAtAd.Name = "textAtAd";
            this.textAtAd.Size = new System.Drawing.Size(133, 22);
            this.textAtAd.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(330, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // formYonetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(189)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(833, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formYonetimPaneli";
            this.Text = "Yonetim Paneli";
            this.Load += new System.EventHandler(this.formYonetimPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonFtGuncelle;
        private System.Windows.Forms.Button buttonFtSil;
        private System.Windows.Forms.Button buttonFtEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFiyat;
        private System.Windows.Forms.TextBox textKisaltma;
        private System.Windows.Forms.TextBox textUzunAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonYeniAt;
        private System.Windows.Forms.Button buttonAtSil;
        private System.Windows.Forms.Button buttonAtGuncelle;
        private System.Windows.Forms.Button buttonAtEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAtFiyat;
        private System.Windows.Forms.TextBox textAtSure;
        private System.Windows.Forms.TextBox textAtAd;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}