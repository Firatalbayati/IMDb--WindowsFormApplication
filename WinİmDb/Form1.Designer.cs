
namespace WinİmDb
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
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.lblDirectors = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.lblWriters = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lstStars = new System.Windows.Forms.ListBox();
            this.lstDirectors = new System.Windows.Forms.ListBox();
            this.MoviePhoto = new System.Windows.Forms.PictureBox();
            this.btnAltyazi = new System.Windows.Forms.Button();
            this.btnFilmİndir = new System.Windows.Forms.Button();
            this.lstWriters = new System.Windows.Forms.ListBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.Saat = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSonuc
            // 
            this.lstSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSonuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstSonuc.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 20;
            this.lstSonuc.Location = new System.Drawing.Point(800, 91);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(271, 160);
            this.lstSonuc.TabIndex = 2;
            this.lstSonuc.SelectedIndexChanged += new System.EventHandler(this.lstSonuc_SelectedIndexChanged);
            // 
            // lblDirectors
            // 
            this.lblDirectors.AutoSize = true;
            this.lblDirectors.BackColor = System.Drawing.Color.White;
            this.lblDirectors.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDirectors.ForeColor = System.Drawing.Color.Black;
            this.lblDirectors.Location = new System.Drawing.Point(780, 535);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Size = new System.Drawing.Size(139, 23);
            this.lblDirectors.TabIndex = 8;
            this.lblDirectors.Text = "Yönetmenler :";
            // 
            // lblStars
            // 
            this.lblStars.AutoSize = true;
            this.lblStars.BackColor = System.Drawing.Color.White;
            this.lblStars.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStars.ForeColor = System.Drawing.Color.Black;
            this.lblStars.Location = new System.Drawing.Point(822, 747);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(97, 23);
            this.lblStars.TabIndex = 10;
            this.lblStars.Text = "Yıldızlar :";
            // 
            // btnSonuc
            // 
            this.btnSonuc.BackColor = System.Drawing.Color.Black;
            this.btnSonuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSonuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonuc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSonuc.Location = new System.Drawing.Point(700, 17);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(82, 30);
            this.btnSonuc.TabIndex = 0;
            this.btnSonuc.Text = "Ara";
            this.btnSonuc.UseVisualStyleBackColor = false;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // lblWriters
            // 
            this.lblWriters.AutoSize = true;
            this.lblWriters.BackColor = System.Drawing.Color.White;
            this.lblWriters.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWriters.ForeColor = System.Drawing.Color.Black;
            this.lblWriters.Location = new System.Drawing.Point(821, 641);
            this.lblWriters.Name = "lblWriters";
            this.lblWriters.Size = new System.Drawing.Size(98, 23);
            this.lblWriters.TabIndex = 9;
            this.lblWriters.Text = "Yazarlar :";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMovieName.Location = new System.Drawing.Point(401, 17);
            this.txtMovieName.Multiline = true;
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(271, 30);
            this.txtMovieName.TabIndex = 1;
            this.txtMovieName.Text = "matrix";
            this.txtMovieName.TextChanged += new System.EventHandler(this.txtMovieName_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(804, 300);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(462, 204);
            this.lblDescription.TabIndex = 7;
            // 
            // lstStars
            // 
            this.lstStars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstStars.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lstStars.FormattingEnabled = true;
            this.lstStars.ItemHeight = 16;
            this.lstStars.Location = new System.Drawing.Point(930, 754);
            this.lstStars.Name = "lstStars";
            this.lstStars.Size = new System.Drawing.Size(273, 96);
            this.lstStars.TabIndex = 6;
            // 
            // lstDirectors
            // 
            this.lstDirectors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDirectors.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lstDirectors.FormattingEnabled = true;
            this.lstDirectors.ItemHeight = 16;
            this.lstDirectors.Location = new System.Drawing.Point(930, 542);
            this.lstDirectors.Name = "lstDirectors";
            this.lstDirectors.Size = new System.Drawing.Size(273, 96);
            this.lstDirectors.TabIndex = 4;
            // 
            // MoviePhoto
            // 
            this.MoviePhoto.Location = new System.Drawing.Point(320, 300);
            this.MoviePhoto.Name = "MoviePhoto";
            this.MoviePhoto.Size = new System.Drawing.Size(442, 552);
            this.MoviePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePhoto.TabIndex = 3;
            this.MoviePhoto.TabStop = false;
            // 
            // btnAltyazi
            // 
            this.btnAltyazi.BackColor = System.Drawing.Color.Black;
            this.btnAltyazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltyazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAltyazi.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAltyazi.ForeColor = System.Drawing.Color.White;
            this.btnAltyazi.Location = new System.Drawing.Point(804, 17);
            this.btnAltyazi.Name = "btnAltyazi";
            this.btnAltyazi.Size = new System.Drawing.Size(147, 30);
            this.btnAltyazi.TabIndex = 15;
            this.btnAltyazi.Text = "Alt yazı İndir";
            this.btnAltyazi.UseVisualStyleBackColor = false;
            this.btnAltyazi.Click += new System.EventHandler(this.btnAltyazi_Click);
            // 
            // btnFilmİndir
            // 
            this.btnFilmİndir.BackColor = System.Drawing.Color.Black;
            this.btnFilmİndir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilmİndir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilmİndir.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmİndir.ForeColor = System.Drawing.Color.White;
            this.btnFilmİndir.Location = new System.Drawing.Point(974, 17);
            this.btnFilmİndir.Name = "btnFilmİndir";
            this.btnFilmİndir.Size = new System.Drawing.Size(147, 30);
            this.btnFilmİndir.TabIndex = 19;
            this.btnFilmİndir.Text = "Filmi İndir";
            this.btnFilmİndir.UseVisualStyleBackColor = false;
            this.btnFilmİndir.Click += new System.EventHandler(this.btnFilmİndir_Click);
            // 
            // lstWriters
            // 
            this.lstWriters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstWriters.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lstWriters.FormattingEnabled = true;
            this.lstWriters.ItemHeight = 16;
            this.lstWriters.Location = new System.Drawing.Point(930, 648);
            this.lstWriters.Name = "lstWriters";
            this.lstWriters.Size = new System.Drawing.Size(273, 96);
            this.lstWriters.TabIndex = 5;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Black;
            this.lblTarih.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(3, 39);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(106, 18);
            this.lblTarih.TabIndex = 23;
            this.lblTarih.Text = "Kasım 29 2020";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.BackColor = System.Drawing.Color.Black;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGun.ForeColor = System.Drawing.Color.White;
            this.lblGun.Location = new System.Drawing.Point(117, 39);
            this.lblGun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(47, 18);
            this.lblGun.TabIndex = 22;
            this.lblGun.Text = "Pazar";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.BackColor = System.Drawing.Color.Black;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.Color.White;
            this.lblSaniye.Location = new System.Drawing.Point(71, -1);
            this.lblSaniye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(24, 18);
            this.lblSaniye.TabIndex = 21;
            this.lblSaniye.Text = "22";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.Black;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(27, 17);
            this.lblSaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(44, 18);
            this.lblSaat.TabIndex = 20;
            this.lblSaat.Text = "22:22";
            // 
            // Saat
            // 
            this.Saat.Tick += new System.EventHandler(this.Saat_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 485);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 422);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1361, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(222, 422);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1361, 485);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(222, 412);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(399, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Arama sonuçu bulunan filmler :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 896);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnFilmİndir);
            this.Controls.Add(this.btnAltyazi);
            this.Controls.Add(this.lblDirectors);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.lblStars);
            this.Controls.Add(this.lblWriters);
            this.Controls.Add(this.MoviePhoto);
            this.Controls.Add(this.lstStars);
            this.Controls.Add(this.lstDirectors);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lstWriters);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.txtMovieName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDb";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Label lblDirectors;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Label lblWriters;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListBox lstStars;
        private System.Windows.Forms.ListBox lstDirectors;
        private System.Windows.Forms.PictureBox MoviePhoto;
        private System.Windows.Forms.Button btnAltyazi;
        private System.Windows.Forms.Button btnFilmİndir;
        private System.Windows.Forms.ListBox lstWriters;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer Saat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}

