namespace Otopark_Otomasyonu
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxKamera1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picLicensePlate = new System.Windows.Forms.PictureBox();
            this.lbxPlates = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolKameraButton = new System.Windows.Forms.ToolStripButton();
            this.kameraGroup1 = new System.Windows.Forms.GroupBox();
            this.labelFiligran1 = new System.Windows.Forms.Label();
            this.kameraGroup2 = new System.Windows.Forms.GroupBox();
            this.labelFiligran2 = new System.Windows.Forms.Label();
            this.pictureboxKamera2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timerKamera2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLicensePlate)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.kameraGroup1.SuspendLayout();
            this.kameraGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxKamera2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timerKamera1
            // 
            this.timerKamera1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // pictureBoxKamera1
            // 
            this.pictureBoxKamera1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKamera1.Location = new System.Drawing.Point(0, 18);
            this.pictureBoxKamera1.Name = "pictureBoxKamera1";
            this.pictureBoxKamera1.Size = new System.Drawing.Size(506, 500);
            this.pictureBoxKamera1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKamera1.TabIndex = 34;
            this.pictureBoxKamera1.TabStop = false;
            this.pictureBoxKamera1.Click += new System.EventHandler(this.pictureBoxKamera1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(138, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "PLAKA";
            // 
            // picLicensePlate
            // 
            this.picLicensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLicensePlate.Location = new System.Drawing.Point(572, 596);
            this.picLicensePlate.Name = "picLicensePlate";
            this.picLicensePlate.Size = new System.Drawing.Size(445, 107);
            this.picLicensePlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLicensePlate.TabIndex = 33;
            this.picLicensePlate.TabStop = false;
            // 
            // lbxPlates
            // 
            this.lbxPlates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxPlates.FormattingEnabled = true;
            this.lbxPlates.ItemHeight = 17;
            this.lbxPlates.Location = new System.Drawing.Point(204, 643);
            this.lbxPlates.Name = "lbxPlates";
            this.lbxPlates.Size = new System.Drawing.Size(161, 21);
            this.lbxPlates.TabIndex = 35;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolKameraButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1141, 27);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolKameraButton
            // 
            this.toolKameraButton.Image = ((System.Drawing.Image)(resources.GetObject("toolKameraButton.Image")));
            this.toolKameraButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKameraButton.Name = "toolKameraButton";
            this.toolKameraButton.Size = new System.Drawing.Size(114, 24);
            this.toolKameraButton.Text = "Kamera Ayarları";
            this.toolKameraButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // kameraGroup1
            // 
            this.kameraGroup1.Controls.Add(this.labelFiligran1);
            this.kameraGroup1.Controls.Add(this.pictureBoxKamera1);
            this.kameraGroup1.Controls.Add(this.pictureBox2);
            this.kameraGroup1.Location = new System.Drawing.Point(5, 29);
            this.kameraGroup1.Margin = new System.Windows.Forms.Padding(2);
            this.kameraGroup1.Name = "kameraGroup1";
            this.kameraGroup1.Padding = new System.Windows.Forms.Padding(2);
            this.kameraGroup1.Size = new System.Drawing.Size(506, 529);
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
            this.labelFiligran1.Location = new System.Drawing.Point(25, 482);
            this.labelFiligran1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiligran1.Name = "labelFiligran1";
            this.labelFiligran1.Size = new System.Drawing.Size(70, 25);
            this.labelFiligran1.TabIndex = 39;
            this.labelFiligran1.Text = "label1";
            // 
            // kameraGroup2
            // 
            this.kameraGroup2.Controls.Add(this.labelFiligran2);
            this.kameraGroup2.Controls.Add(this.pictureboxKamera2);
            this.kameraGroup2.Controls.Add(this.pictureBox3);
            this.kameraGroup2.Location = new System.Drawing.Point(572, 29);
            this.kameraGroup2.Margin = new System.Windows.Forms.Padding(2);
            this.kameraGroup2.Name = "kameraGroup2";
            this.kameraGroup2.Padding = new System.Windows.Forms.Padding(2);
            this.kameraGroup2.Size = new System.Drawing.Size(513, 518);
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
            this.labelFiligran2.Location = new System.Drawing.Point(36, 482);
            this.labelFiligran2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiligran2.Name = "labelFiligran2";
            this.labelFiligran2.Size = new System.Drawing.Size(70, 25);
            this.labelFiligran2.TabIndex = 40;
            this.labelFiligran2.Text = "label2";
            // 
            // pictureboxKamera2
            // 
            this.pictureboxKamera2.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxKamera2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureboxKamera2.Location = new System.Drawing.Point(5, 18);
            this.pictureboxKamera2.Name = "pictureboxKamera2";
            this.pictureboxKamera2.Size = new System.Drawing.Size(500, 500);
            this.pictureboxKamera2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxKamera2.TabIndex = 34;
            this.pictureboxKamera2.TabStop = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerKamera2
            // 
            this.timerKamera2.Tick += new System.EventHandler(this.timerKamera2_Tick);
            // 
            // kameraMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1141, 714);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kameraGroup2);
            this.Controls.Add(this.picLicensePlate);
            this.Controls.Add(this.kameraGroup1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxPlates);
            this.Name = "kameraMonitor";
            this.Text = "kameraMonitor";
            this.Load += new System.EventHandler(this.kameraMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLicensePlate)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.kameraGroup1.ResumeLayout(false);
            this.kameraGroup1.PerformLayout();
            this.kameraGroup2.ResumeLayout(false);
            this.kameraGroup2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxKamera2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFiligran1;
        private System.Windows.Forms.Label labelFiligran2;
        private System.Windows.Forms.Timer timerKamera2;
    }
}