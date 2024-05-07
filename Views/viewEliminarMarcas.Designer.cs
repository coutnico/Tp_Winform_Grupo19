namespace Tp_WinForm_Grupo_19.Views
{
    partial class viewEliminarMarcas
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
            this.eliminar_Marca = new System.Windows.Forms.Button();
            this.Id_Marca_Eliminar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eliminar_Marca
            // 
            this.eliminar_Marca.Location = new System.Drawing.Point(45, 77);
            this.eliminar_Marca.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar_Marca.Name = "eliminar_Marca";
            this.eliminar_Marca.Size = new System.Drawing.Size(91, 21);
            this.eliminar_Marca.TabIndex = 21;
            this.eliminar_Marca.Text = "Eliminar";
            this.eliminar_Marca.UseVisualStyleBackColor = true;
            this.eliminar_Marca.Click += new System.EventHandler(this.eliminar_Marca_Click);
            // 
            // Id_Marca_Eliminar
            // 
            this.Id_Marca_Eliminar.Location = new System.Drawing.Point(73, 39);
            this.Id_Marca_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Id_Marca_Eliminar.Name = "Id_Marca_Eliminar";
            this.Id_Marca_Eliminar.Size = new System.Drawing.Size(56, 20);
            this.Id_Marca_Eliminar.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Eliminar marca";
            // 
            // viewEliminarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 111);
            this.Controls.Add(this.eliminar_Marca);
            this.Controls.Add(this.Id_Marca_Eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "viewEliminarMarcas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.viewEliminarMarcas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminar_Marca;
        private System.Windows.Forms.TextBox Id_Marca_Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}