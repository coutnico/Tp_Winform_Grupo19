namespace Tp_WinForm_Grupo_19.Views
{
    partial class viewEliminarArticulos
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
            this.Id_Articulo_Eliminar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminar_Articulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Id_Articulo_Eliminar
            // 
            this.Id_Articulo_Eliminar.Location = new System.Drawing.Point(81, 35);
            this.Id_Articulo_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Id_Articulo_Eliminar.Name = "Id_Articulo_Eliminar";
            this.Id_Articulo_Eliminar.Size = new System.Drawing.Size(56, 20);
            this.Id_Articulo_Eliminar.TabIndex = 8;
            this.Id_Articulo_Eliminar.TextChanged += new System.EventHandler(this.codigo_Articulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Articulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eliminar articulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eliminar_Articulo
            // 
            this.eliminar_Articulo.Location = new System.Drawing.Point(53, 73);
            this.eliminar_Articulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eliminar_Articulo.Name = "eliminar_Articulo";
            this.eliminar_Articulo.Size = new System.Drawing.Size(91, 21);
            this.eliminar_Articulo.TabIndex = 17;
            this.eliminar_Articulo.Text = "Eliminar";
            this.eliminar_Articulo.UseVisualStyleBackColor = true;
            this.eliminar_Articulo.Click += new System.EventHandler(this.eliminar_Articulo_Click);
            // 
            // viewEliminarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 107);
            this.Controls.Add(this.eliminar_Articulo);
            this.Controls.Add(this.Id_Articulo_Eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "viewEliminarArticulos";
            this.Text = "EliminarArticulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_Articulo_Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminar_Articulo;
    }
}