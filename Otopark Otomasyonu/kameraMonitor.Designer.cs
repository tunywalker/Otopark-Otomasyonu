﻿namespace Otopark_Otomasyonu
{
    partial class kameraMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kameraMonitor));
            this.timerKamera1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbxPlates = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.kameraGroup1 = new System.Windows.Forms.GroupBox();
            this.labelFiligran1 = new System.Windows.Forms.Label();
            this.kameraGroup2 = new System.Windows.Forms.GroupBox();
            this.labelFiligran2 = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.timerKamera2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textPlaka = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butonGirisReddet = new System.Windows.Forms.Button();
            this.sonraKaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTekrarTani = new System.Windows.Forms.Button();
            this.picLicensePlate = new System.Windows.Forms.PictureBox();
            this.pictureboxKamera2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxKamera1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolKameraButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.kameraGroup1.SuspendLayout();
            this.kameraGroup2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLicensePlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxKamera2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timerKamera1
            // 
            this.timerKamera1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-560, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "PLAKA";
            // 
            // lbxPlates
            // 
            this.lbxPlates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxPlates.FormattingEnabled = true;
            this.lbxPlates.ItemHeight = 22;
            this.lbxPlates.Location = new System.Drawing.Point(516, 23);
            this.lbxPlates.Margin = new System.Windows.Forms.Padding(4);
            this.lbxPlates.Name = "lbxPlates";
            this.lbxPlates.Size = new System.Drawing.Size(160, 114);
            this.lbxPlates.TabIndex = 35;
            this.lbxPlates.SelectedIndexChanged += new System.EventHandler(this.lbxPlates_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolKameraButton,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1456, 42);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 39);
            this.toolStripLabel1.Text = "Kapasite:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 39);
            this.toolStripLabel2.Text = "0/100";
            // 
            // kameraGroup1
            // 
            this.kameraGroup1.Controls.Add(this.labelFiligran1);
            this.kameraGroup1.Controls.Add(this.pictureBoxKamera1);
            this.kameraGroup1.Controls.Add(this.pictureBox2);
            this.kameraGroup1.Location = new System.Drawing.Point(7, 58);
            this.kameraGroup1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kameraGroup1.Name = "kameraGroup1";
            this.kameraGroup1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kameraGroup1.Size = new System.Drawing.Size(699, 630);
            this.kameraGroup1.TabIndex = 41;
            this.kameraGroup1.TabStop = false;
            this.kameraGroup1.Text = "KameraGrup1";
            // 
            // labelFiligran1
            // 
            this.labelFiligran1.AutoSize = true;
            this.labelFiligran1.BackColor = System.Drawing.Color.Transparent;
            this.labelFiligran1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiligran1.ForeColor = System.Drawing.Color.White;
            this.labelFiligran1.Location = new System.Drawing.Point(33, 593);
            this.labelFiligran1.Name = "labelFiligran1";
            this.labelFiligran1.Size = new System.Drawing.Size(86, 31);
            this.labelFiligran1.TabIndex = 39;
            this.labelFiligran1.Text = "label1";
            // 
            // kameraGroup2
            // 
            this.kameraGroup2.Controls.Add(this.labelFiligran2);
            this.kameraGroup2.Controls.Add(this.pictureboxKamera2);
            this.kameraGroup2.Controls.Add(this.pictureBox3);
            this.kameraGroup2.Location = new System.Drawing.Point(763, 58);
            this.kameraGroup2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kameraGroup2.Name = "kameraGroup2";
            this.kameraGroup2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kameraGroup2.Size = new System.Drawing.Size(684, 615);
            this.kameraGroup2.TabIndex = 42;
            this.kameraGroup2.TabStop = false;
            this.kameraGroup2.Text = "KameraGrup2";
            // 
            // labelFiligran2
            // 
            this.labelFiligran2.AutoSize = true;
            this.labelFiligran2.BackColor = System.Drawing.Color.Transparent;
            this.labelFiligran2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiligran2.ForeColor = System.Drawing.Color.White;
            this.labelFiligran2.Location = new System.Drawing.Point(48, 593);
            this.labelFiligran2.Name = "labelFiligran2";
            this.labelFiligran2.Size = new System.Drawing.Size(86, 31);
            this.labelFiligran2.TabIndex = 40;
            this.labelFiligran2.Text = "label2";
            // 
            // timerLoad
            // 
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // timerKamera2
            // 
            this.timerKamera2.Tick += new System.EventHandler(this.timerKamera2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.butonGirisReddet);
            this.groupBox2.Controls.Add(this.textPlaka);
            this.groupBox2.Controls.Add(this.sonraKaydet);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.buttonTekrarTani);
            this.groupBox2.Controls.Add(this.lbxPlates);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.picLicensePlate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(16, 694);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(689, 254);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giriş İşlemleri";
            // 
            // textPlaka
            // 
            this.textPlaka.Location = new System.Drawing.Point(435, 164);
            this.textPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.textPlaka.Name = "textPlaka";
            this.textPlaka.Size = new System.Drawing.Size(241, 37);
            this.textPlaka.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(763, 718);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(673, 236);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çıkış";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(457, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 114);
            this.listBox1.TabIndex = 36;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // butonGirisReddet
            // 
            this.butonGirisReddet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonGirisReddet.Image = global::Otopark_Otomasyonu.Properties.Resources.reddet;
            this.butonGirisReddet.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butonGirisReddet.Location = new System.Drawing.Point(8, 209);
            this.butonGirisReddet.Margin = new System.Windows.Forms.Padding(4);
            this.butonGirisReddet.Name = "butonGirisReddet";
            this.butonGirisReddet.Size = new System.Drawing.Size(183, 37);
            this.butonGirisReddet.TabIndex = 46;
            this.butonGirisReddet.Text = "Girişi Reddet";
            this.butonGirisReddet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonGirisReddet.UseVisualStyleBackColor = true;
            this.butonGirisReddet.Click += new System.EventHandler(this.butonGirisReddet_Click);
            // 
            // sonraKaydet
            // 
            this.sonraKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonraKaydet.Image = global::Otopark_Otomasyonu.Properties.Resources.sonra;
            this.sonraKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sonraKaydet.Location = new System.Drawing.Point(8, 164);
            this.sonraKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.sonraKaydet.Name = "sonraKaydet";
            this.sonraKaydet.Size = new System.Drawing.Size(217, 37);
            this.sonraKaydet.TabIndex = 40;
            this.sonraKaydet.Text = "Çıkışta İşlem Yap";
            this.sonraKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sonraKaydet.UseVisualStyleBackColor = true;
            this.sonraKaydet.Click += new System.EventHandler(this.sonraKaydet_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::Otopark_Otomasyonu.Properties.Resources.newCar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(8, 113);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 37);
            this.button2.TabIndex = 44;
            this.button2.Text = "Üyelik Oluştur";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTekrarTani
            // 
            this.buttonTekrarTani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTekrarTani.Image = global::Otopark_Otomasyonu.Properties.Resources.tekrar;
            this.buttonTekrarTani.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTekrarTani.Location = new System.Drawing.Point(435, 209);
            this.buttonTekrarTani.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTekrarTani.Name = "buttonTekrarTani";
            this.buttonTekrarTani.Size = new System.Drawing.Size(243, 37);
            this.buttonTekrarTani.TabIndex = 43;
            this.buttonTekrarTani.Text = "Tekrar Tanımla";
            this.buttonTekrarTani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTekrarTani.UseVisualStyleBackColor = true;
            this.buttonTekrarTani.Click += new System.EventHandler(this.button1_Click);
            // 
            // picLicensePlate
            // 
            this.picLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLicensePlate.Location = new System.Drawing.Point(8, 32);
            this.picLicensePlate.Margin = new System.Windows.Forms.Padding(4);
            this.picLicensePlate.Name = "picLicensePlate";
            this.picLicensePlate.Size = new System.Drawing.Size(485, 73);
            this.picLicensePlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLicensePlate.TabIndex = 33;
            this.picLicensePlate.TabStop = false;
            // 
            // pictureboxKamera2
            // 
            this.pictureboxKamera2.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxKamera2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureboxKamera2.Location = new System.Drawing.Point(7, 22);
            this.pictureboxKamera2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureboxKamera2.Name = "pictureboxKamera2";
            this.pictureboxKamera2.Size = new System.Drawing.Size(666, 615);
            this.pictureboxKamera2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxKamera2.TabIndex = 34;
            this.pictureboxKamera2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(167, 47);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBoxKamera1
            // 
            this.pictureBoxKamera1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKamera1.Location = new System.Drawing.Point(9, 22);
            this.pictureBoxKamera1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxKamera1.Name = "pictureBoxKamera1";
            this.pictureBoxKamera1.Size = new System.Drawing.Size(677, 615);
            this.pictureBoxKamera1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKamera1.TabIndex = 34;
            this.pictureBoxKamera1.TabStop = false;
            this.pictureBoxKamera1.Click += new System.EventHandler(this.pictureBoxKamera1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(160, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // toolKameraButton
            // 
            this.toolKameraButton.Image = ((System.Drawing.Image)(resources.GetObject("toolKameraButton.Image")));
            this.toolKameraButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKameraButton.Name = "toolKameraButton";
            this.toolKameraButton.Size = new System.Drawing.Size(139, 39);
            this.toolKameraButton.Text = "Kamera Ayarları";
            this.toolKameraButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 39);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // kameraMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1456, 962);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kameraGroup2);
            this.Controls.Add(this.kameraGroup1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kameraMonitor";
            this.Text = "kameraMonitor";
            this.Load += new System.EventHandler(this.kameraMonitor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.kameraGroup1.ResumeLayout(false);
            this.kameraGroup1.PerformLayout();
            this.kameraGroup2.ResumeLayout(false);
            this.kameraGroup2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLicensePlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxKamera2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerKamera1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxKamera1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picLicensePlate;
        private System.Windows.Forms.ListBox lbxPlates;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolKameraButton;
        private System.Windows.Forms.GroupBox kameraGroup1;
        private System.Windows.Forms.GroupBox kameraGroup2;
        private System.Windows.Forms.PictureBox pictureboxKamera2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.Button buttonTekrarTani;
        private System.Windows.Forms.Label labelFiligran1;
        private System.Windows.Forms.Label labelFiligran2;
        private System.Windows.Forms.Timer timerKamera2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button sonraKaydet;
        private System.Windows.Forms.TextBox textPlaka;
        private System.Windows.Forms.Button butonGirisReddet;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}