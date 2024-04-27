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
            this.label1 = new System.Windows.Forms.Label();
            this.lista_Marca = new System.Windows.Forms.ListBox();
            this.lista_Categoria = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo_Articulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_Articulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descripcion_Articulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.precio_Articulo = new System.Windows.Forms.TextBox();
            this.crear_Articulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregue un nuevo articulo";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lista_Marca
            // 
            this.lista_Marca.FormattingEnabled = true;
            this.lista_Marca.ItemHeight = 24;
            this.lista_Marca.Location = new System.Drawing.Point(243, 371);
            this.lista_Marca.Name = "lista_Marca";
            this.lista_Marca.Size = new System.Drawing.Size(500, 52);
            this.lista_Marca.TabIndex = 1;
            this.lista_Marca.SelectedIndexChanged += new System.EventHandler(this.lista_Marca_SelectedIndexChanged);
            // 
            // lista_Categoria
            // 
            this.lista_Categoria.FormattingEnabled = true;
            this.lista_Categoria.ItemHeight = 24;
            this.lista_Categoria.Location = new System.Drawing.Point(243, 451);
            this.lista_Categoria.Name = "lista_Categoria";
            this.lista_Categoria.Size = new System.Drawing.Size(500, 52);
            this.lista_Categoria.TabIndex = 2;
            this.lista_Categoria.SelectedIndexChanged += new System.EventHandler(this.lista_Categoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // codigo_Articulo
            // 
            this.codigo_Articulo.Location = new System.Drawing.Point(243, 144);
            this.codigo_Articulo.Name = "codigo_Articulo";
            this.codigo_Articulo.Size = new System.Drawing.Size(100, 29);
            this.codigo_Articulo.TabIndex = 5;
            this.codigo_Articulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // nombre_Articulo
            // 
            this.nombre_Articulo.Location = new System.Drawing.Point(243, 235);
            this.nombre_Articulo.Name = "nombre_Articulo";
            this.nombre_Articulo.Size = new System.Drawing.Size(100, 29);
            this.nombre_Articulo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripcion";
            // 
            // descripcion_Articulo
            // 
            this.descripcion_Articulo.Location = new System.Drawing.Point(243, 310);
            this.descripcion_Articulo.Name = "descripcion_Articulo";
            this.descripcion_Articulo.Size = new System.Drawing.Size(100, 29);
            this.descripcion_Articulo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Imagen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 592);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio";
            // 
            // precio_Articulo
            // 
            this.precio_Articulo.Location = new System.Drawing.Point(243, 588);
            this.precio_Articulo.Name = "precio_Articulo";
            this.precio_Articulo.Size = new System.Drawing.Size(100, 29);
            this.precio_Articulo.TabIndex = 15;
            // 
            // crear_Articulo
            // 
            this.crear_Articulo.Location = new System.Drawing.Point(408, 654);
            this.crear_Articulo.Name = "crear_Articulo";
            this.crear_Articulo.Size = new System.Drawing.Size(166, 59);
            this.crear_Articulo.TabIndex = 16;
            this.crear_Articulo.Text = "Crear";
            this.crear_Articulo.UseVisualStyleBackColor = true;
            this.crear_Articulo.Click += new System.EventHandler(this.crear_Articulo_Click);
            // 
            // viewAgregarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 936);
            this.Controls.Add(this.crear_Articulo);
            this.Controls.Add(this.precio_Articulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descripcion_Articulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre_Articulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codigo_Articulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lista_Categoria);
            this.Controls.Add(this.lista_Marca);
            this.Controls.Add(this.label1);
            this.Name = "viewAgregarArticulos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.viewAgregarArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lista_Marca;
        private System.Windows.Forms.ListBox lista_Categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo_Articulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre_Articulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descripcion_Articulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox precio_Articulo;
        private System.Windows.Forms.Button crear_Articulo;
    }
}