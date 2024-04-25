namespace Tp_WinForm_Grupo_19.Views
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
            ((System.ComponentModel.ISupportInitialize)(this.pbImageArticle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImageArticle
            // 
            this.pbImageArticle.BackColor = System.Drawing.Color.Transparent;
            this.pbImageArticle.Location = new System.Drawing.Point(40, 47);
            this.pbImageArticle.Name = "pbImageArticle";
            this.pbImageArticle.Size = new System.Drawing.Size(456, 589);
            this.pbImageArticle.TabIndex = 0;
            this.pbImageArticle.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(502, 68);
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
            this.lblCat.Location = new System.Drawing.Point(504, 169);
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
            this.lblMar.Location = new System.Drawing.Point(502, 241);
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
            this.lblPrice.Location = new System.Drawing.Point(769, 596);
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
            this.lblDesc.Location = new System.Drawing.Point(0, 14);
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
            this.label6.Location = new System.Drawing.Point(502, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripcion:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(99)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Location = new System.Drawing.Point(502, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 143);
            this.panel1.TabIndex = 7;
            // 
            // viewVistaDetallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tp_WinForm_Grupo_19.Properties.Resources.degradadoAzulVioleta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 665);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblMar);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbImageArticle);
            this.Controls.Add(this.panel1);
            this.Name = "viewVistaDetallada";
            this.Text = "viewVistaDetallada";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageArticle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}