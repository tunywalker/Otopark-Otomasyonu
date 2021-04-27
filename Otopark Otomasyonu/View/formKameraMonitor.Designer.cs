namespace Otopark_Otomasyonu
{
    partial class formKameraMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKameraMonitor));
            this.timerKamera1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbxPlates = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolKameraButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.kameraGroup1 = new System.Windows.Forms.GroupBox();
            this.kamera1LoadingLabel = new System.Windows.Forms.Label();
            this.labelFiligran1 = new System.Windows.Forms.Label();
            this.pictureBoxKamera1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kameraGroup2 = new System.Windows.Forms.GroupBox();
            this.kamera2LoadingLabel = new System.Windows.Forms.Label();
            this.pictureboxKamera2 = new System.Windows.Forms.PictureBox();
            this.labelFiligran2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.timerKamera2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butonGirisReddet = new System.Windows.Forms.Button();
            this.textPlaka = new System.Windows.Forms.TextBox();
            this.sonraKaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTekrarTani = new System.Windows.Forms.Button();
            this.picLicensePlate = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTekrarTani2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textPlkaCikis = new System.Windows.Forms.TextBox();
            this.picLicensePlateCikis = new System.Windows.Forms.PictureBox();
            this.lbxPlatesCikis = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1.SuspendLayout();
            this.kameraGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.kameraGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxKamera2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicensePlate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicensePlateCikis)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(-420, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "PLAKA";
            // 
            // lbxPlates
            // 
            this.lbxPlates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxPlates.FormattingEnabled = true;
            this.lbxPlates.ItemHeight = 17;
            this.lbxPlates.Location = new System.Drawing.Point(385, 31);
            this.lbxPlates.Name = "lbxPlates";
            this.lbxPlates.Size = new System.Drawing.Size(121, 89);
            this.lbxPlates.TabIndex = 35;
            this.lbxPlates.SelectedIndexChanged += new System.EventHandler(this.lbxPlates_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolKameraButton,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1092, 43);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolKameraButton
            // 
            this.toolKameraButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolKameraButton.Image = ((System.Drawing.Image)(resources.GetObject("toolKameraButton.Image")));
            this.toolKameraButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKameraButton.Name = "toolKameraButton";
            this.toolKameraButton.Size = new System.Drawing.Size(145, 40);
            this.toolKameraButton.Text = "Kamera Ayarları";
            this.toolKameraButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(97, 40);
            this.toolStripButton2.Text = "Aboneler";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(86, 40);
            this.toolStripButton3.Text = "Kayıtlar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(169, 40);
            this.toolStripButton4.Text = "Otoparktaki Araçlar";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(129, 40);
            this.toolStripButton1.Text = "İndirim Paneli";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 40);
            this.toolStripLabel1.Text = "Kapasite:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 40);
            this.toolStripLabel2.Text = "0/100";
            // 
            // kameraGroup1
            // 
            this.kameraGroup1.BackColor = System.Drawing.Color.Transparent;
            this.kameraGroup1.Controls.Add(this.kamera1LoadingLabel);
            this.kameraGroup1.Controls.Add(this.labelFiligran1);
            this.kameraGroup1.Controls.Add(this.pictureBoxKamera1);
            this.kameraGroup1.Controls.Add(this.pictureBox2);
            this.kameraGroup1.Location = new System.Drawing.Point(5, 47);
            this.kameraGroup1.Margin = new System.Windows.Forms.Padding(2);
            this.kameraGroup1.Name = "kameraGroup1";
            this.kameraGroup1.Padding = new System.Windows.Forms.Padding(2);
            this.kameraGroup1.Size = new System.Drawing.Size(524, 474);
            this.kameraGroup1.TabIndex = 41;
            this.kameraGroup1.TabStop = false;
            this.kameraGroup1.Text = "KameraGrup1";
            // 
            // kamera1LoadingLabel
            // 
            this.kamera1LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.kamera1LoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kamera1LoadingLabel.Location = new System.Drawing.Point(11, 99);
            this.kamera1LoadingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kamera1LoadingLabel.Name = "kamera1LoadingLabel";
            this.kamera1LoadingLabel.Size = new System.Drawing.Size(502, 31);
            this.kamera1LoadingLabel.TabIndex = 40;
            this.kamera1LoadingLabel.Text = "Kamera Algılanıyor";
            this.kamera1LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFiligran1
            // 
            this.labelFiligran1.AutoSize = true;
            this.labelFiligran1.BackColor = System.Drawing.Color.Transparent;
            this.labelFiligran1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiligran1.ForeColor = System.Drawing.Color.White;
            this.labelFiligran1.Location = new System.Drawing.Point(23, 416);
            this.labelFiligran1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiligran1.Name = "labelFiligran1";
            this.labelFiligran1.Size = new System.Drawing.Size(18, 25);
            this.labelFiligran1.TabIndex = 39;
            this.labelFiligran1.Text = ",";
            // 
            // pictureBoxKamera1
            // 
            this.pictureBoxKamera1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKamera1.Image = global::Otopark_Otomasyonu.Properties.Resources.connecting;
            this.pictureBoxKamera1.Location = new System.Drawing.Point(5, 17);
            this.pictureBoxKamera1.Name = "pictureBoxKamera1";
            this.pictureBoxKamera1.Size = new System.Drawing.Size(514, 449);
            this.pictureBoxKamera1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKamera1.TabIndex = 34;
            this.pictureBoxKamera1.TabStop = false;
            this.pictureBoxKamera1.Click += new System.EventHandler(this.pictureBoxKamera1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(120, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // kameraGroup2
            // 
            this.kameraGroup2.BackColor = System.Drawing.Color.Transparent;
            this.kameraGroup2.Controls.Add(this.kamera2LoadingLabel);
            this.kameraGroup2.Controls.Add(this.pictureboxKamera2);
            this.kameraGroup2.Controls.Add(this.labelFiligran2);
            this.kameraGroup2.Controls.Add(this.pictureBox3);
            this.kameraGroup2.Location = new System.Drawing.Point(572, 47);
            this.kameraGroup2.Margin = new System.Windows.Forms.Padding(2);
            this.kameraGroup2.Name = "kameraGroup2";
            this.kameraGroup2.Padding = new System.Windows.Forms.Padding(2);
            this.kameraGroup2.Size = new System.Drawing.Size(655, 474);
            this.kameraGroup2.TabIndex = 42;
            this.kameraGroup2.TabStop = false;
            this.kameraGroup2.Text = "KameraGrup2";
            // 
            // kamera2LoadingLabel
            // 
            this.kamera2LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.kamera2LoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kamera2LoadingLabel.Location = new System.Drawing.Point(8, 99);
            this.kamera2LoadingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kamera2LoadingLabel.Name = "kamera2LoadingLabel";
            this.kamera2LoadingLabel.Size = new System.Drawing.Size(502, 31);
            this.kamera2LoadingLabel.TabIndex = 42;
            this.kamera2LoadingLabel.Text = "Kamera Algılanıyor";
            this.kamera2LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureboxKamera2
            // 
            this.pictureboxKamera2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureboxKamera2.Image = global::Otopark_Otomasyonu.Properties.Resources.connecting;
            this.pictureboxKamera2.Location = new System.Drawing.Point(1, 17);
            this.pictureboxKamera2.Name = "pictureboxKamera2";
            this.pictureboxKamera2.Size = new System.Drawing.Size(514, 449);
            this.pictureboxKamera2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxKamera2.TabIndex = 41;
            this.pictureboxKamera2.TabStop = false;
            this.pictureboxKamera2.Click += new System.EventHandler(this.pictureboxKamera2_Click_1);
            // 
            // labelFiligran2
            // 
            this.labelFiligran2.AutoSize = true;
            this.labelFiligran2.BackColor = System.Drawing.Color.Transparent;
            this.labelFiligran2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiligran2.ForeColor = System.Drawing.Color.White;
            this.labelFiligran2.Location = new System.Drawing.Point(36, 482);
            this.labelFiligran2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiligran2.Name = "labelFiligran2";
            this.labelFiligran2.Size = new System.Drawing.Size(19, 25);
            this.labelFiligran2.TabIndex = 40;
            this.labelFiligran2.Text = "-";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(125, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
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
            this.label1.Location = new System.Drawing.Point(533, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 241);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giriş İşlemleri";
            // 
            // butonGirisReddet
            // 
            this.butonGirisReddet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonGirisReddet.Image = global::Otopark_Otomasyonu.Properties.Resources.reddet;
            this.butonGirisReddet.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butonGirisReddet.Location = new System.Drawing.Point(6, 170);
            this.butonGirisReddet.Name = "butonGirisReddet";
            this.butonGirisReddet.Size = new System.Drawing.Size(137, 30);
            this.butonGirisReddet.TabIndex = 46;
            this.butonGirisReddet.Text = "Girişi Reddet";
            this.butonGirisReddet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonGirisReddet.UseVisualStyleBackColor = true;
            this.butonGirisReddet.Click += new System.EventHandler(this.butonGirisReddet_Click);
            // 
            // textPlaka
            // 
            this.textPlaka.Location = new System.Drawing.Point(330, 168);
            this.textPlaka.Name = "textPlaka";
            this.textPlaka.Size = new System.Drawing.Size(182, 31);
            this.textPlaka.TabIndex = 45;
            // 
            // sonraKaydet
            // 
            this.sonraKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonraKaydet.Image = global::Otopark_Otomasyonu.Properties.Resources.sonra;
            this.sonraKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sonraKaydet.Location = new System.Drawing.Point(6, 133);
            this.sonraKaydet.Name = "sonraKaydet";
            this.sonraKaydet.Size = new System.Drawing.Size(163, 30);
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
            this.button2.Location = new System.Drawing.Point(6, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 30);
            this.button2.TabIndex = 44;
            this.button2.Text = "Giriş İşlemleri";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTekrarTani
            // 
            this.buttonTekrarTani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTekrarTani.Image = global::Otopark_Otomasyonu.Properties.Resources.tekrar;
            this.buttonTekrarTani.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTekrarTani.Location = new System.Drawing.Point(330, 205);
            this.buttonTekrarTani.Name = "buttonTekrarTani";
            this.buttonTekrarTani.Size = new System.Drawing.Size(182, 30);
            this.buttonTekrarTani.TabIndex = 43;
            this.buttonTekrarTani.Text = "Tekrar Tanımla";
            this.buttonTekrarTani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTekrarTani.UseVisualStyleBackColor = true;
            this.buttonTekrarTani.Click += new System.EventHandler(this.button1_Click);
            // 
            // picLicensePlate
            // 
            this.picLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLicensePlate.Location = new System.Drawing.Point(6, 31);
            this.picLicensePlate.Name = "picLicensePlate";
            this.picLicensePlate.Size = new System.Drawing.Size(364, 60);
            this.picLicensePlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLicensePlate.TabIndex = 33;
            this.picLicensePlate.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTekrarTani2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textPlkaCikis);
            this.groupBox1.Controls.Add(this.picLicensePlateCikis);
            this.groupBox1.Controls.Add(this.lbxPlatesCikis);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.groupBox1.Location = new System.Drawing.Point(552, 529);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 241);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çıkış İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonTekrarTani2
            // 
            this.buttonTekrarTani2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTekrarTani2.Image = global::Otopark_Otomasyonu.Properties.Resources.tekrar;
            this.buttonTekrarTani2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTekrarTani2.Location = new System.Drawing.Point(318, 205);
            this.buttonTekrarTani2.Name = "buttonTekrarTani2";
            this.buttonTekrarTani2.Size = new System.Drawing.Size(182, 30);
            this.buttonTekrarTani2.TabIndex = 47;
            this.buttonTekrarTani2.Text = "Tekrar Tanımla";
            this.buttonTekrarTani2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTekrarTani2.UseVisualStyleBackColor = true;
            this.buttonTekrarTani2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = global::Otopark_Otomasyonu.Properties.Resources.cikis1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(6, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 30);
            this.button3.TabIndex = 48;
            this.button3.Text = "Çıkış İşlemleri";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textPlkaCikis
            // 
            this.textPlkaCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textPlkaCikis.Location = new System.Drawing.Point(320, 169);
            this.textPlkaCikis.Name = "textPlkaCikis";
            this.textPlkaCikis.Size = new System.Drawing.Size(182, 31);
            this.textPlkaCikis.TabIndex = 47;
            // 
            // picLicensePlateCikis
            // 
            this.picLicensePlateCikis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLicensePlateCikis.Location = new System.Drawing.Point(6, 28);
            this.picLicensePlateCikis.Name = "picLicensePlateCikis";
            this.picLicensePlateCikis.Size = new System.Drawing.Size(356, 53);
            this.picLicensePlateCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLicensePlateCikis.TabIndex = 37;
            this.picLicensePlateCikis.TabStop = false;
            // 
            // lbxPlatesCikis
            // 
            this.lbxPlatesCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxPlatesCikis.FormattingEnabled = true;
            this.lbxPlatesCikis.ItemHeight = 17;
            this.lbxPlatesCikis.Location = new System.Drawing.Point(407, 31);
            this.lbxPlatesCikis.Name = "lbxPlatesCikis";
            this.lbxPlatesCikis.Size = new System.Drawing.Size(121, 89);
            this.lbxPlatesCikis.TabIndex = 36;
            this.lbxPlatesCikis.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // formKameraMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(189)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1092, 778);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kameraGroup2);
            this.Controls.Add(this.kameraGroup1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "formKameraMonitor";
            this.Text = " ";
            this.Load += new System.EventHandler(this.kameraMonitor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.kameraGroup1.ResumeLayout(false);
            this.kameraGroup1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.kameraGroup2.ResumeLayout(false);
            this.kameraGroup2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxKamera2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicensePlate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLicensePlateCikis)).EndInit();
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
        private System.Windows.Forms.ListBox lbxPlatesCikis;
        private System.Windows.Forms.PictureBox picLicensePlateCikis;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textPlkaCikis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label kamera1LoadingLabel;
        private System.Windows.Forms.PictureBox pictureboxKamera2;
        private System.Windows.Forms.Label kamera2LoadingLabel;
        private System.Windows.Forms.Button buttonTekrarTani2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}