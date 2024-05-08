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
            this.ibClose = new FontAwesome.Sharp.IconButton();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // eliminar_Categoria
            // 
            this.eliminar_Categoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eliminar_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_Categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.eliminar_Categoria.ForeColor = System.Drawing.Color.White;
            this.eliminar_Categoria.Location = new System.Drawing.Point(135, 134);
            this.eliminar_Categoria.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar_Categoria.Name = "eliminar_Categoria";
            this.eliminar_Categoria.Size = new System.Drawing.Size(91, 32);
            this.eliminar_Categoria.TabIndex = 25;
            this.eliminar_Categoria.Text = "Eliminar";
            this.eliminar_Categoria.UseVisualStyleBackColor = true;
            this.eliminar_Categoria.Click += new System.EventHandler(this.eliminar_Categoria_Click);
            // 
            // Id_Categoria_Eliminar
            // 
            this.Id_Categoria_Eliminar.BackColor = System.Drawing.Color.BlueViolet;
            this.Id_Categoria_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Id_Categoria_Eliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Id_Categoria_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Id_Categoria_Eliminar.Location = new System.Drawing.Point(170, 93);
            this.Id_Categoria_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Id_Categoria_Eliminar.Name = "Id_Categoria_Eliminar";
            this.Id_Categoria_Eliminar.Size = new System.Drawing.Size(127, 25);
            this.Id_Categoria_Eliminar.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID Categoria";
            // 
            // ibClose
            // 
            this.ibClose.BackColor = System.Drawing.Color.Transparent;
            this.ibClose.FlatAppearance.BorderSize = 0;
            this.ibClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.ibClose.IconColor = System.Drawing.Color.White;
            this.ibClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibClose.IconSize = 30;
            this.ibClose.Location = new System.Drawing.Point(314, 3);
            this.ibClose.Name = "ibClose";
            this.ibClose.Size = new System.Drawing.Size(35, 35);
            this.ibClose.TabIndex = 2;
            this.ibClose.UseVisualStyleBackColor = false;
            this.ibClose.Click += new System.EventHandler(this.ibClose_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Indigo;
            this.panelSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelSuperior.Controls.Add(this.ibClose);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(351, 38);
            this.panelSuperior.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 82;
            this.label1.Text = "Eliminar Categoria";
            // 
            // viewEliminarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(351, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.eliminar_Categoria);
            this.Controls.Add(this.Id_Categoria_Eliminar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewEliminarCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminar_Categoria;
        private System.Windows.Forms.TextBox Id_Categoria_Eliminar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ibClose;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
    }
}