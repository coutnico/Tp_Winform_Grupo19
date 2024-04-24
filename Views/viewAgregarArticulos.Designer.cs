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
            this.Lista_Categoria = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agrega un nuevo articulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lista_Marca
            // 
            this.lista_Marca.FormattingEnabled = true;
            this.lista_Marca.ItemHeight = 24;
            this.lista_Marca.Location = new System.Drawing.Point(57, 127);
            this.lista_Marca.Name = "lista_Marca";
            this.lista_Marca.Size = new System.Drawing.Size(500, 52);
            this.lista_Marca.TabIndex = 1;
            this.lista_Marca.SelectedIndexChanged += new System.EventHandler(this.lista_Marca_SelectedIndexChanged);
            // 
            // Lista_Categoria
            // 
            this.Lista_Categoria.FormattingEnabled = true;
            this.Lista_Categoria.ItemHeight = 24;
            this.Lista_Categoria.Location = new System.Drawing.Point(57, 291);
            this.Lista_Categoria.Name = "Lista_Categoria";
            this.Lista_Categoria.Size = new System.Drawing.Size(500, 52);
            this.Lista_Categoria.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(906, 371);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 3;
            // 
            // viewAgregarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 936);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Lista_Categoria);
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
        private System.Windows.Forms.ListBox Lista_Categoria;
        private System.Windows.Forms.ListBox listBox1;
    }
}