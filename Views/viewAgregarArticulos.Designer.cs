namespace Tp_WinForm_Grupo_19.Views
{
    partial class viewAgregarArticulos
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
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.cbMarcas = new System.Windows.Forms.ComboBox();
            this.ibAgregarArticulo = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ibAddMarca = new FontAwesome.Sharp.IconButton();
            this.ibTrashMarca = new FontAwesome.Sharp.IconButton();
            this.ibUpdateMarca = new FontAwesome.Sharp.IconButton();
            this.ibTrashCategoria = new FontAwesome.Sharp.IconButton();
            this.ibUpdateCategoria = new FontAwesome.Sharp.IconButton();
            this.ibAddCategoria = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudPrecio
            // 
            this.nudPrecio.BackColor = System.Drawing.Color.BlueViolet;
            this.nudPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nudPrecio.ForeColor = System.Drawing.Color.White;
            this.nudPrecio.Location = new System.Drawing.Point(802, 520);
            this.nudPrecio.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 29);
            this.nudPrecio.TabIndex = 64;
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.Transparent;
            this.pbImagen.Image = global::Tp_WinForm_Grupo_19.Properties.Resources.ImagenNoCargada;
            this.pbImagen.Location = new System.Drawing.Point(54, 93);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(323, 525);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 63;
            this.pbImagen.TabStop = false;
            // 
            // cbCategorias
            // 
            this.cbCategorias.BackColor = System.Drawing.Color.BlueViolet;
            this.cbCategorias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorias.ForeColor = System.Drawing.Color.White;
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(507, 446);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(156, 25);
            this.cbCategorias.TabIndex = 62;
            // 
            // cbMarcas
            // 
            this.cbMarcas.BackColor = System.Drawing.Color.BlueViolet;
            this.cbMarcas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarcas.ForeColor = System.Drawing.Color.White;
            this.cbMarcas.FormattingEnabled = true;
            this.cbMarcas.Location = new System.Drawing.Point(507, 396);
            this.cbMarcas.Name = "cbMarcas";
            this.cbMarcas.Size = new System.Drawing.Size(156, 25);
            this.cbMarcas.TabIndex = 61;
            // 
            // ibAgregarArticulo
            // 
            this.ibAgregarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.ibAgregarArticulo.FlatAppearance.BorderSize = 0;
            this.ibAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAgregarArticulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ibAgregarArticulo.ForeColor = System.Drawing.Color.White;
            this.ibAgregarArticulo.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibAgregarArticulo.IconColor = System.Drawing.Color.Lime;
            this.ibAgregarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAgregarArticulo.Location = new System.Drawing.Point(591, 561);
            this.ibAgregarArticulo.Name = "ibAgregarArticulo";
            this.ibAgregarArticulo.Size = new System.Drawing.Size(145, 48);
            this.ibAgregarArticulo.TabIndex = 60;
            this.ibAgregarArticulo.Text = "Agregar";
            this.ibAgregarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAgregarArticulo.UseVisualStyleBackColor = false;
            this.ibAgregarArticulo.Click += new System.EventHandler(this.ibAgregarArticulo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(734, 522);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.BlueViolet;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(496, 266);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(257, 74);
            this.txtDescripcion.TabIndex = 57;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.BlueViolet;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(496, 201);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 25);
            this.txtNombre.TabIndex = 56;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.BlueViolet;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(496, 131);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 25);
            this.txtCodigo.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 37);
            this.label1.TabIndex = 54;
            this.label1.Text = "Agregar Articulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Marca";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(396, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(396, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(396, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Codigo";
            // 
            // ibAddMarca
            // 
            this.ibAddMarca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ibAddMarca.BackColor = System.Drawing.Color.Transparent;
            this.ibAddMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibAddMarca.FlatAppearance.BorderSize = 0;
            this.ibAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAddMarca.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibAddMarca.ForeColor = System.Drawing.Color.Transparent;
            this.ibAddMarca.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibAddMarca.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibAddMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAddMarca.IconSize = 38;
            this.ibAddMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAddMarca.Location = new System.Drawing.Point(282, 6);
            this.ibAddMarca.Name = "ibAddMarca";
            this.ibAddMarca.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ibAddMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ibAddMarca.Size = new System.Drawing.Size(51, 33);
            this.ibAddMarca.TabIndex = 65;
            this.ibAddMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAddMarca.UseVisualStyleBackColor = false;
            this.ibAddMarca.Click += new System.EventHandler(this.ibAgregarMarca_Click);
            // 
            // ibTrashMarca
            // 
            this.ibTrashMarca.BackColor = System.Drawing.Color.Transparent;
            this.ibTrashMarca.FlatAppearance.BorderSize = 0;
            this.ibTrashMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibTrashMarca.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibTrashMarca.IconColor = System.Drawing.Color.Brown;
            this.ibTrashMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibTrashMarca.IconSize = 32;
            this.ibTrashMarca.Location = new System.Drawing.Point(354, 3);
            this.ibTrashMarca.Name = "ibTrashMarca";
            this.ibTrashMarca.Size = new System.Drawing.Size(32, 35);
            this.ibTrashMarca.TabIndex = 68;
            this.ibTrashMarca.UseVisualStyleBackColor = false;
            this.ibTrashMarca.Click += new System.EventHandler(this.ibTrashMarca_Click);
            // 
            // ibUpdateMarca
            // 
            this.ibUpdateMarca.BackColor = System.Drawing.Color.Transparent;
            this.ibUpdateMarca.FlatAppearance.BorderSize = 0;
            this.ibUpdateMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibUpdateMarca.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.ibUpdateMarca.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ibUpdateMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibUpdateMarca.IconSize = 35;
            this.ibUpdateMarca.Location = new System.Drawing.Point(416, 3);
            this.ibUpdateMarca.Name = "ibUpdateMarca";
            this.ibUpdateMarca.Size = new System.Drawing.Size(32, 35);
            this.ibUpdateMarca.TabIndex = 67;
            this.ibUpdateMarca.UseVisualStyleBackColor = false;
            this.ibUpdateMarca.Click += new System.EventHandler(this.ibUpdateMarca_Click);
            // 
            // ibTrashCategoria
            // 
            this.ibTrashCategoria.BackColor = System.Drawing.Color.Transparent;
            this.ibTrashCategoria.FlatAppearance.BorderSize = 0;
            this.ibTrashCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibTrashCategoria.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibTrashCategoria.IconColor = System.Drawing.Color.Brown;
            this.ibTrashCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibTrashCategoria.IconSize = 32;
            this.ibTrashCategoria.Location = new System.Drawing.Point(354, 4);
            this.ibTrashCategoria.Name = "ibTrashCategoria";
            this.ibTrashCategoria.Size = new System.Drawing.Size(32, 35);
            this.ibTrashCategoria.TabIndex = 71;
            this.ibTrashCategoria.UseVisualStyleBackColor = false;
            this.ibTrashCategoria.Click += new System.EventHandler(this.ibTrashCategoria_Click);
            // 
            // ibUpdateCategoria
            // 
            this.ibUpdateCategoria.BackColor = System.Drawing.Color.Transparent;
            this.ibUpdateCategoria.FlatAppearance.BorderSize = 0;
            this.ibUpdateCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibUpdateCategoria.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.ibUpdateCategoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ibUpdateCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibUpdateCategoria.IconSize = 35;
            this.ibUpdateCategoria.Location = new System.Drawing.Point(416, 2);
            this.ibUpdateCategoria.Name = "ibUpdateCategoria";
            this.ibUpdateCategoria.Size = new System.Drawing.Size(32, 35);
            this.ibUpdateCategoria.TabIndex = 70;
            this.ibUpdateCategoria.UseVisualStyleBackColor = false;
            this.ibUpdateCategoria.Click += new System.EventHandler(this.ibUpdateCategoria_Click);
            // 
            // ibAddCategoria
            // 
            this.ibAddCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ibAddCategoria.BackColor = System.Drawing.Color.Transparent;
            this.ibAddCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibAddCategoria.FlatAppearance.BorderSize = 0;
            this.ibAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAddCategoria.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibAddCategoria.ForeColor = System.Drawing.Color.Transparent;
            this.ibAddCategoria.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibAddCategoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibAddCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAddCategoria.IconSize = 38;
            this.ibAddCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAddCategoria.Location = new System.Drawing.Point(282, 4);
            this.ibAddCategoria.Name = "ibAddCategoria";
            this.ibAddCategoria.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ibAddCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ibAddCategoria.Size = new System.Drawing.Size(51, 33);
            this.ibAddCategoria.TabIndex = 69;
            this.ibAddCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAddCategoria.UseVisualStyleBackColor = false;
            this.ibAddCategoria.Click += new System.EventHandler(this.ibAddCategoria_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.ibUpdateMarca);
            this.panel1.Controls.Add(this.ibTrashMarca);
            this.panel1.Controls.Add(this.ibAddMarca);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(400, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 41);
            this.panel1.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.ibAddCategoria);
            this.panel2.Controls.Add(this.ibTrashCategoria);
            this.panel2.Controls.Add(this.ibUpdateCategoria);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(400, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 41);
            this.panel2.TabIndex = 73;
            // 
            // viewAgregarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 654);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.cbMarcas);
            this.Controls.Add(this.ibAgregarArticulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "viewAgregarArticulos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.viewAgregarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.ComboBox cbMarcas;
        private FontAwesome.Sharp.IconButton ibAgregarArticulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ibAddMarca;
        private FontAwesome.Sharp.IconButton ibTrashMarca;
        private FontAwesome.Sharp.IconButton ibUpdateMarca;
        private FontAwesome.Sharp.IconButton ibTrashCategoria;
        private FontAwesome.Sharp.IconButton ibUpdateCategoria;
        private FontAwesome.Sharp.IconButton ibAddCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}