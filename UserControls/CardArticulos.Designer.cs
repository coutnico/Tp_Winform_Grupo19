﻿namespace Tp_WinForm_Grupo_19.UserControls
{
    partial class CardArticulos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ibVistaDetallada = new FontAwesome.Sharp.IconButton();
            this.ibUpdate = new FontAwesome.Sharp.IconButton();
            this.ibTrash = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(127, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::Tp_WinForm_Grupo_19.Properties.Resources.ImagenNoCargada;
            this.pbImagen.Location = new System.Drawing.Point(0, 24);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(124, 137);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(130, 82);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(227, 34);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(127, 139);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 17);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(285, 161);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 21);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(3, 165);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 17);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(127, 119);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 17);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion:";
            // 
            // ibVistaDetallada
            // 
            this.ibVistaDetallada.FlatAppearance.BorderSize = 0;
            this.ibVistaDetallada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibVistaDetallada.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.ibVistaDetallada.IconColor = System.Drawing.Color.Black;
            this.ibVistaDetallada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibVistaDetallada.IconSize = 35;
            this.ibVistaDetallada.Location = new System.Drawing.Point(364, 0);
            this.ibVistaDetallada.Name = "ibVistaDetallada";
            this.ibVistaDetallada.Size = new System.Drawing.Size(32, 35);
            this.ibVistaDetallada.TabIndex = 8;
            this.ibVistaDetallada.UseVisualStyleBackColor = true;
            this.ibVistaDetallada.Click += new System.EventHandler(this.ibVistaDetallada_Click);
            // 
            // ibUpdate
            // 
            this.ibUpdate.FlatAppearance.BorderSize = 0;
            this.ibUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibUpdate.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.ibUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ibUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibUpdate.IconSize = 35;
            this.ibUpdate.Location = new System.Drawing.Point(330, 0);
            this.ibUpdate.Name = "ibUpdate";
            this.ibUpdate.Size = new System.Drawing.Size(32, 35);
            this.ibUpdate.TabIndex = 9;
            this.ibUpdate.UseVisualStyleBackColor = true;
            this.ibUpdate.Click += new System.EventHandler(this.ibUpdate_Click);
            // 
            // ibTrash
            // 
            this.ibTrash.FlatAppearance.BorderSize = 0;
            this.ibTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibTrash.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibTrash.IconColor = System.Drawing.Color.Brown;
            this.ibTrash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibTrash.IconSize = 32;
            this.ibTrash.Location = new System.Drawing.Point(291, 0);
            this.ibTrash.Name = "ibTrash";
            this.ibTrash.Size = new System.Drawing.Size(32, 35);
            this.ibTrash.TabIndex = 10;
            this.ibTrash.UseVisualStyleBackColor = true;
            this.ibTrash.Click += new System.EventHandler(this.ibTrash_Click);
            // 
            // CardArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ibTrash);
            this.Controls.Add(this.ibUpdate);
            this.Controls.Add(this.ibVistaDetallada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbImagen);
            this.Margin = new System.Windows.Forms.Padding(25, 10, 3, 3);
            this.Name = "CardArticulos";
            this.Size = new System.Drawing.Size(396, 186);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibVistaDetallada;
        private FontAwesome.Sharp.IconButton ibUpdate;
        private FontAwesome.Sharp.IconButton ibTrash;
    }
}
