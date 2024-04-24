namespace Tp_WinForm_Grupo_19
{
    partial class viewPrincipal
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
            this.panelBorderStyle = new System.Windows.Forms.Panel();
            this.ibHome = new FontAwesome.Sharp.IconButton();
            this.ibMinimize = new FontAwesome.Sharp.IconButton();
            this.ibMaximize = new FontAwesome.Sharp.IconButton();
            this.ibExit = new FontAwesome.Sharp.IconButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMenu2 = new System.Windows.Forms.Panel();
            this.ibSocialNetworks = new FontAwesome.Sharp.IconButton();
            this.ibMoreInformation = new FontAwesome.Sharp.IconButton();
            this.ibUs = new FontAwesome.Sharp.IconButton();
            this.panelMenu1 = new System.Windows.Forms.Panel();
            this.ibaAddArticles = new FontAwesome.Sharp.IconButton();
            this.ibviewArticles = new FontAwesome.Sharp.IconButton();
            this.ibArticles = new FontAwesome.Sharp.IconButton();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelBorderStyle.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelMenu2.SuspendLayout();
            this.panelMenu1.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorderStyle
            // 
            this.panelBorderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.panelBorderStyle.Controls.Add(this.ibHome);
            this.panelBorderStyle.Controls.Add(this.ibMinimize);
            this.panelBorderStyle.Controls.Add(this.ibMaximize);
            this.panelBorderStyle.Controls.Add(this.ibExit);
            this.panelBorderStyle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorderStyle.Location = new System.Drawing.Point(0, 0);
            this.panelBorderStyle.Name = "panelBorderStyle";
            this.panelBorderStyle.Size = new System.Drawing.Size(1264, 50);
            this.panelBorderStyle.TabIndex = 0;
            this.panelBorderStyle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorderStyle_MouseDown);
            this.panelBorderStyle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBorderStyle_MouseMove);
            this.panelBorderStyle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBorderStyle_MouseUp);
            // 
            // ibHome
            // 
            this.ibHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ibHome.FlatAppearance.BorderSize = 0;
            this.ibHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.ibHome.IconColor = System.Drawing.Color.White;
            this.ibHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibHome.IconSize = 40;
            this.ibHome.Location = new System.Drawing.Point(12, 12);
            this.ibHome.Name = "ibHome";
            this.ibHome.Size = new System.Drawing.Size(34, 32);
            this.ibHome.TabIndex = 4;
            this.ibHome.UseVisualStyleBackColor = true;
            // 
            // ibMinimize
            // 
            this.ibMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ibMinimize.FlatAppearance.BorderSize = 0;
            this.ibMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ibMinimize.IconColor = System.Drawing.Color.White;
            this.ibMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibMinimize.IconSize = 34;
            this.ibMinimize.Location = new System.Drawing.Point(1152, 9);
            this.ibMinimize.Name = "ibMinimize";
            this.ibMinimize.Size = new System.Drawing.Size(34, 32);
            this.ibMinimize.TabIndex = 2;
            this.ibMinimize.UseVisualStyleBackColor = true;
            this.ibMinimize.Click += new System.EventHandler(this.ibMinimize_Click);
            // 
            // ibMaximize
            // 
            this.ibMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ibMaximize.FlatAppearance.BorderSize = 0;
            this.ibMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.ibMaximize.IconColor = System.Drawing.Color.White;
            this.ibMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibMaximize.IconSize = 34;
            this.ibMaximize.Location = new System.Drawing.Point(1190, 9);
            this.ibMaximize.Name = "ibMaximize";
            this.ibMaximize.Size = new System.Drawing.Size(34, 32);
            this.ibMaximize.TabIndex = 3;
            this.ibMaximize.UseVisualStyleBackColor = true;
            this.ibMaximize.Click += new System.EventHandler(this.ibMaximize_Click);
            // 
            // ibExit
            // 
            this.ibExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ibExit.FlatAppearance.BorderSize = 0;
            this.ibExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibExit.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.ibExit.IconColor = System.Drawing.Color.White;
            this.ibExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibExit.IconSize = 34;
            this.ibExit.Location = new System.Drawing.Point(1227, 9);
            this.ibExit.Name = "ibExit";
            this.ibExit.Size = new System.Drawing.Size(34, 32);
            this.ibExit.TabIndex = 1;
            this.ibExit.UseVisualStyleBackColor = true;
            this.ibExit.Click += new System.EventHandler(this.ibExit_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(11)))), ((int)(((byte)(29)))));
            this.panelLeft.Controls.Add(this.panelMenu2);
            this.panelLeft.Controls.Add(this.panelMenu1);
            this.panelLeft.Controls.Add(this.panelPicture);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(240, 704);
            this.panelLeft.TabIndex = 1;
            // 
            // panelMenu2
            // 
            this.panelMenu2.Controls.Add(this.ibSocialNetworks);
            this.panelMenu2.Controls.Add(this.ibMoreInformation);
            this.panelMenu2.Controls.Add(this.ibUs);
            this.panelMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu2.Location = new System.Drawing.Point(0, 323);
            this.panelMenu2.Name = "panelMenu2";
            this.panelMenu2.Size = new System.Drawing.Size(240, 178);
            this.panelMenu2.TabIndex = 5;
            // 
            // ibSocialNetworks
            // 
            this.ibSocialNetworks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ibSocialNetworks.FlatAppearance.BorderSize = 0;
            this.ibSocialNetworks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSocialNetworks.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSocialNetworks.ForeColor = System.Drawing.Color.White;
            this.ibSocialNetworks.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            this.ibSocialNetworks.IconColor = System.Drawing.Color.White;
            this.ibSocialNetworks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSocialNetworks.IconSize = 38;
            this.ibSocialNetworks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSocialNetworks.Location = new System.Drawing.Point(48, 120);
            this.ibSocialNetworks.Name = "ibSocialNetworks";
            this.ibSocialNetworks.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ibSocialNetworks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ibSocialNetworks.Size = new System.Drawing.Size(192, 54);
            this.ibSocialNetworks.TabIndex = 2;
            this.ibSocialNetworks.Text = "Redes sociales";
            this.ibSocialNetworks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSocialNetworks.UseVisualStyleBackColor = true;
            // 
            // ibMoreInformation
            // 
            this.ibMoreInformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ibMoreInformation.FlatAppearance.BorderSize = 0;
            this.ibMoreInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibMoreInformation.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibMoreInformation.ForeColor = System.Drawing.Color.White;
            this.ibMoreInformation.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.ibMoreInformation.IconColor = System.Drawing.Color.White;
            this.ibMoreInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibMoreInformation.IconSize = 38;
            this.ibMoreInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibMoreInformation.Location = new System.Drawing.Point(48, 60);
            this.ibMoreInformation.Name = "ibMoreInformation";
            this.ibMoreInformation.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ibMoreInformation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ibMoreInformation.Size = new System.Drawing.Size(192, 54);
            this.ibMoreInformation.TabIndex = 1;
            this.ibMoreInformation.Text = "Mas Informacion";
            this.ibMoreInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibMoreInformation.UseVisualStyleBackColor = true;
            // 
            // ibUs
            // 
            this.ibUs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ibUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibUs.FlatAppearance.BorderSize = 0;
            this.ibUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibUs.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibUs.ForeColor = System.Drawing.Color.White;
            this.ibUs.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.ibUs.IconColor = System.Drawing.Color.White;
            this.ibUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibUs.IconSize = 40;
            this.ibUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibUs.Location = new System.Drawing.Point(0, 0);
            this.ibUs.Name = "ibUs";
            this.ibUs.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ibUs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ibUs.Size = new System.Drawing.Size(240, 54);
            this.ibUs.TabIndex = 0;
            this.ibUs.Text = "Nosotros";
            this.ibUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibUs.UseVisualStyleBackColor = true;
            // 
            // panelMenu1
            // 
            this.panelMenu1.Controls.Add(this.ibaAddArticles);
            this.panelMenu1.Controls.Add(this.ibviewArticles);
            this.panelMenu1.Controls.Add(this.ibArticles);
            this.panelMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu1.Location = new System.Drawing.Point(0, 145);
            this.panelMenu1.Name = "panelMenu1";
            this.panelMenu1.Size = new System.Drawing.Size(240, 178);
            this.panelMenu1.TabIndex = 4;
            // 
            // ibaAddArticles
            // 
            this.ibaAddArticles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ibaAddArticles.FlatAppearance.BorderSize = 0;
            this.ibaAddArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibaAddArticles.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibaAddArticles.ForeColor = System.Drawing.Color.White;
            this.ibaAddArticles.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibaAddArticles.IconColor = System.Drawing.Color.White;
            this.ibaAddArticles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibaAddArticles.IconSize = 38;
            this.ibaAddArticles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibaAddArticles.Location = new System.Drawing.Point(45, 120);
            this.ibaAddArticles.Name = "ibaAddArticles";
            this.ibaAddArticles.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ibaAddArticles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ibaAddArticles.Size = new System.Drawing.Size(195, 54);
            this.ibaAddArticles.TabIndex = 2;
            this.ibaAddArticles.Text = "Agregar ";
            this.ibaAddArticles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibaAddArticles.UseVisualStyleBackColor = true;
            this.ibaAddArticles.Click += new System.EventHandler(this.ibaAddArticles_Click);
            // 
            // ibviewArticles
            // 
            this.ibviewArticles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ibviewArticles.FlatAppearance.BorderSize = 0;
            this.ibviewArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibviewArticles.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibviewArticles.ForeColor = System.Drawing.Color.White;
            this.ibviewArticles.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ibviewArticles.IconColor = System.Drawing.Color.White;
            this.ibviewArticles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibviewArticles.IconSize = 38;
            this.ibviewArticles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibviewArticles.Location = new System.Drawing.Point(48, 60);
            this.ibviewArticles.Name = "ibviewArticles";
            this.ibviewArticles.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ibviewArticles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ibviewArticles.Size = new System.Drawing.Size(195, 54);
            this.ibviewArticles.TabIndex = 1;
            this.ibviewArticles.Text = "Ver ";
            this.ibviewArticles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibviewArticles.UseVisualStyleBackColor = true;
            this.ibviewArticles.Click += new System.EventHandler(this.ibviewArticles_Click);
            // 
            // ibArticles
            // 
            this.ibArticles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ibArticles.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibArticles.FlatAppearance.BorderSize = 0;
            this.ibArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibArticles.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibArticles.ForeColor = System.Drawing.Color.White;
            this.ibArticles.IconChar = FontAwesome.Sharp.IconChar.MobileScreenButton;
            this.ibArticles.IconColor = System.Drawing.Color.White;
            this.ibArticles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibArticles.IconSize = 40;
            this.ibArticles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibArticles.Location = new System.Drawing.Point(0, 0);
            this.ibArticles.Name = "ibArticles";
            this.ibArticles.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ibArticles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ibArticles.Size = new System.Drawing.Size(240, 54);
            this.ibArticles.TabIndex = 0;
            this.ibArticles.Text = "Articulos disponibles";
            this.ibArticles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibArticles.UseVisualStyleBackColor = true;
            // 
            // panelPicture
            // 
            this.panelPicture.Controls.Add(this.pictureBox1);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(240, 145);
            this.panelPicture.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tp_WinForm_Grupo_19.Properties.Resources.compras_movilesBlanco;
            this.pictureBox1.Location = new System.Drawing.Point(60, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelHome
            // 
            this.panelHome.BackgroundImage = global::Tp_WinForm_Grupo_19.Properties.Resources.degradadoAzulVioleta;
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHome.Controls.Add(this.pictureBox3);
            this.panelHome.Controls.Add(this.lbltitulo);
            this.panelHome.Controls.Add(this.pictureBox2);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(240, 50);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1024, 704);
            this.panelHome.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Tp_WinForm_Grupo_19.Properties.Resources.bandera_argentina;
            this.pictureBox3.Location = new System.Drawing.Point(818, 385);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(121, 383);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(712, 64);
            this.lbltitulo.TabIndex = 3;
            this.lbltitulo.Text = "Bienvenidos a la tienda de articulos numero 1 de Argentina";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Tp_WinForm_Grupo_19.Properties.Resources.logotienda;
            this.pictureBox2.Location = new System.Drawing.Point(367, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // viewPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 754);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBorderStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "viewPrincipal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewPrincipal";
            this.panelBorderStyle.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelMenu2.ResumeLayout(false);
            this.panelMenu1.ResumeLayout(false);
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorderStyle;
        private FontAwesome.Sharp.IconButton ibMinimize;
        private FontAwesome.Sharp.IconButton ibMaximize;
        private FontAwesome.Sharp.IconButton ibExit;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu2;
        private FontAwesome.Sharp.IconButton ibMoreInformation;
        private FontAwesome.Sharp.IconButton ibUs;
        private System.Windows.Forms.Panel panelMenu1;
        private FontAwesome.Sharp.IconButton ibaAddArticles;
        private FontAwesome.Sharp.IconButton ibviewArticles;
        private FontAwesome.Sharp.IconButton ibArticles;
        private FontAwesome.Sharp.IconButton ibSocialNetworks;
        private FontAwesome.Sharp.IconButton ibHome;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

