﻿namespace Tp_WinForm_Grupo_19.Views
{
    partial class viewVistaDetallada
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
            this.pbImageArticle = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblMar = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.ibFlechaIzq = new FontAwesome.Sharp.IconButton();
            this.ibFlechaDerecha = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageArticle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImageArticle
            // 
            this.pbImageArticle.BackColor = System.Drawing.Color.Transparent;
            this.pbImageArticle.Location = new System.Drawing.Point(9, 20);
            this.pbImageArticle.Name = "pbImageArticle";
            this.pbImageArticle.Size = new System.Drawing.Size(414, 558);
            this.pbImageArticle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageArticle.TabIndex = 0;
            this.pbImageArticle.TabStop = false;
            this.pbImageArticle.Click += new System.EventHandler(this.pbImageArticle_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(429, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(238, 40);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre Articulo";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BackColor = System.Drawing.Color.Transparent;
            this.lblCat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.White;
            this.lblCat.Location = new System.Drawing.Point(431, 130);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(105, 25);
            this.lblCat.TabIndex = 2;
            this.lblCat.Text = "Categoria: ";
            // 
            // lblMar
            // 
            this.lblMar.AutoSize = true;
            this.lblMar.BackColor = System.Drawing.Color.Transparent;
            this.lblMar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMar.ForeColor = System.Drawing.Color.White;
            this.lblMar.Location = new System.Drawing.Point(429, 202);
            this.lblMar.Name = "lblMar";
            this.lblMar.Size = new System.Drawing.Size(71, 25);
            this.lblMar.TabIndex = 3;
            this.lblMar.Text = "Marca:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(718, 565);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(212, 40);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Precio Articulo";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(4, 14);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(101, 25);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Contenido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(429, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripcion:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(99)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Location = new System.Drawing.Point(429, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 143);
            this.panel1.TabIndex = 7;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.ibFlechaIzq);
            this.panelPrincipal.Controls.Add(this.ibFlechaDerecha);
            this.panelPrincipal.Controls.Add(this.label6);
            this.panelPrincipal.Controls.Add(this.pbImageArticle);
            this.panelPrincipal.Controls.Add(this.lblPrice);
            this.panelPrincipal.Controls.Add(this.lblName);
            this.panelPrincipal.Controls.Add(this.lblMar);
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Controls.Add(this.lblCat);
            this.panelPrincipal.Location = new System.Drawing.Point(31, 35);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(931, 607);
            this.panelPrincipal.TabIndex = 8;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // ibFlechaIzq
            // 
            this.ibFlechaIzq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibFlechaIzq.FlatAppearance.BorderSize = 0;
            this.ibFlechaIzq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ibFlechaIzq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ibFlechaIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibFlechaIzq.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.ibFlechaIzq.IconColor = System.Drawing.Color.Black;
            this.ibFlechaIzq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibFlechaIzq.Location = new System.Drawing.Point(14, 244);
            this.ibFlechaIzq.Name = "ibFlechaIzq";
            this.ibFlechaIzq.Size = new System.Drawing.Size(66, 56);
            this.ibFlechaIzq.TabIndex = 9;
            this.ibFlechaIzq.UseVisualStyleBackColor = true;
            this.ibFlechaIzq.Click += new System.EventHandler(this.ibFlechaIzq_Click);
            this.ibFlechaIzq.MouseLeave += new System.EventHandler(this.ibFlechaIzq_MouseLeave);
            this.ibFlechaIzq.MouseHover += new System.EventHandler(this.ibFlechaIzq_MouseHover);
            // 
            // ibFlechaDerecha
            // 
            this.ibFlechaDerecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibFlechaDerecha.FlatAppearance.BorderSize = 0;
            this.ibFlechaDerecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ibFlechaDerecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ibFlechaDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibFlechaDerecha.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.ibFlechaDerecha.IconColor = System.Drawing.Color.Black;
            this.ibFlechaDerecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibFlechaDerecha.Location = new System.Drawing.Point(352, 244);
            this.ibFlechaDerecha.Name = "ibFlechaDerecha";
            this.ibFlechaDerecha.Size = new System.Drawing.Size(66, 56);
            this.ibFlechaDerecha.TabIndex = 8;
            this.ibFlechaDerecha.UseVisualStyleBackColor = true;
            this.ibFlechaDerecha.Click += new System.EventHandler(this.ibFlechaDerecha_Click);
            this.ibFlechaDerecha.MouseLeave += new System.EventHandler(this.ibFlechaDerecha_MouseLeave);
            this.ibFlechaDerecha.MouseHover += new System.EventHandler(this.ibFlechaDerecha_MouseHover);
            // 
            // viewVistaDetallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tp_WinForm_Grupo_19.Properties.Resources.degradadoAzulVioleta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 654);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "viewVistaDetallada";
            this.Text = "viewVistaDetallada";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageArticle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImageArticle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblMar;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrincipal;
        private FontAwesome.Sharp.IconButton ibFlechaDerecha;
        private FontAwesome.Sharp.IconButton ibFlechaIzq;
    }
}