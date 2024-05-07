namespace Tp_WinForm_Grupo_19.Views
{
    partial class viewEliminarCategorias
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
            this.eliminar_Categoria = new System.Windows.Forms.Button();
            this.Id_Categoria_Eliminar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eliminar_Categoria
            // 
            this.eliminar_Categoria.Location = new System.Drawing.Point(46, 83);
            this.eliminar_Categoria.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar_Categoria.Name = "eliminar_Categoria";
            this.eliminar_Categoria.Size = new System.Drawing.Size(91, 21);
            this.eliminar_Categoria.TabIndex = 25;
            this.eliminar_Categoria.Text = "Eliminar";
            this.eliminar_Categoria.UseVisualStyleBackColor = true;
            this.eliminar_Categoria.Click += new System.EventHandler(this.eliminar_Categoria_Click);
            // 
            // Id_Categoria_Eliminar
            // 
            this.Id_Categoria_Eliminar.Location = new System.Drawing.Point(74, 45);
            this.Id_Categoria_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Id_Categoria_Eliminar.Name = "Id_Categoria_Eliminar";
            this.Id_Categoria_Eliminar.Size = new System.Drawing.Size(56, 20);
            this.Id_Categoria_Eliminar.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Eliminar categoria";
            // 
            // viewEliminarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 115);
            this.Controls.Add(this.eliminar_Categoria);
            this.Controls.Add(this.Id_Categoria_Eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "viewEliminarCategorias";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminar_Categoria;
        private System.Windows.Forms.TextBox Id_Categoria_Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}