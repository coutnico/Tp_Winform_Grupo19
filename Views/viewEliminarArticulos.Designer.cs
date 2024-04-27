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
            this.crear_Articulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Id_Articulo_Eliminar
            // 
            this.Id_Articulo_Eliminar.Location = new System.Drawing.Point(148, 65);
            this.Id_Articulo_Eliminar.Name = "Id_Articulo_Eliminar";
            this.Id_Articulo_Eliminar.Size = new System.Drawing.Size(100, 29);
            this.Id_Articulo_Eliminar.TabIndex = 8;
            this.Id_Articulo_Eliminar.TextChanged += new System.EventHandler(this.codigo_Articulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Articulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eliminar articulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // crear_Articulo
            // 
            this.crear_Articulo.Location = new System.Drawing.Point(97, 134);
            this.crear_Articulo.Name = "crear_Articulo";
            this.crear_Articulo.Size = new System.Drawing.Size(166, 39);
            this.crear_Articulo.TabIndex = 17;
            this.crear_Articulo.Text = "Eliminar";
            this.crear_Articulo.UseVisualStyleBackColor = true;
            this.crear_Articulo.Click += new System.EventHandler(this.crear_Articulo_Click);
            // 
            // EliminarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 198);
            this.Controls.Add(this.crear_Articulo);
            this.Controls.Add(this.Id_Articulo_Eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EliminarArticulos";
            this.Text = "EliminarArticulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_Articulo_Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button crear_Articulo;
    }
}