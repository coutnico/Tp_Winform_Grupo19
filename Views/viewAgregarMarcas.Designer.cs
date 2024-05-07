namespace Tp_WinForm_Grupo_19.Views
{
    partial class viewAgregarMarcas
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
            this.ibAgregarMarca = new FontAwesome.Sharp.IconButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ibAgregarMarca
            // 
            this.ibAgregarMarca.BackColor = System.Drawing.Color.Transparent;
            this.ibAgregarMarca.FlatAppearance.BorderSize = 0;
            this.ibAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAgregarMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ibAgregarMarca.ForeColor = System.Drawing.Color.White;
            this.ibAgregarMarca.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ibAgregarMarca.IconColor = System.Drawing.Color.Lime;
            this.ibAgregarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAgregarMarca.Location = new System.Drawing.Point(138, 106);
            this.ibAgregarMarca.Name = "ibAgregarMarca";
            this.ibAgregarMarca.Size = new System.Drawing.Size(145, 48);
            this.ibAgregarMarca.TabIndex = 75;
            this.ibAgregarMarca.Text = "Agregar";
            this.ibAgregarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAgregarMarca.UseVisualStyleBackColor = false;
            this.ibAgregarMarca.Click += new System.EventHandler(this.ibAgregarArticulo_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.BlueViolet;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(149, 67);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(203, 25);
            this.txtDescripcion.TabIndex = 72;
 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 70;
            this.label1.Text = "Agregar Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "Descripcion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // viewAgregarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 164);
            this.Controls.Add(this.ibAgregarMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "viewAgregarMarcas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibAgregarMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}