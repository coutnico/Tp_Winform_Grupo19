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
            this.ibClose = new FontAwesome.Sharp.IconButton();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // eliminar_Marca
            // 
            this.eliminar_Marca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eliminar_Marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_Marca.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.eliminar_Marca.ForeColor = System.Drawing.Color.White;
            this.eliminar_Marca.Location = new System.Drawing.Point(130, 137);
            this.eliminar_Marca.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar_Marca.Name = "eliminar_Marca";
            this.eliminar_Marca.Size = new System.Drawing.Size(91, 36);
            this.eliminar_Marca.TabIndex = 21;
            this.eliminar_Marca.Text = "Eliminar";
            this.eliminar_Marca.UseVisualStyleBackColor = true;
            this.eliminar_Marca.Click += new System.EventHandler(this.eliminar_Marca_Click);
            // 
            // Id_Marca_Eliminar
            // 
            this.Id_Marca_Eliminar.BackColor = System.Drawing.Color.BlueViolet;
            this.Id_Marca_Eliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Id_Marca_Eliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Id_Marca_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Id_Marca_Eliminar.Location = new System.Drawing.Point(158, 94);
            this.Id_Marca_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Id_Marca_Eliminar.Name = "Id_Marca_Eliminar";
            this.Id_Marca_Eliminar.Size = new System.Drawing.Size(112, 25);
            this.Id_Marca_Eliminar.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID Marca";
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
            this.ibClose.Location = new System.Drawing.Point(300, 3);
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
            this.panelSuperior.Size = new System.Drawing.Size(335, 38);
            this.panelSuperior.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 83;
            this.label1.Text = "Eliminar Marca";
            // 
            // viewEliminarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(335, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.eliminar_Marca);
            this.Controls.Add(this.Id_Marca_Eliminar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewEliminarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.viewEliminarMarcas_Load);
            this.panelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminar_Marca;
        private System.Windows.Forms.TextBox Id_Marca_Eliminar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ibClose;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
    }
}