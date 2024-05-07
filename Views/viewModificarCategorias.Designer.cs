namespace Tp_WinForm_Grupo_19.Views
{
    partial class viewModificarCategorias
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
            this.modificar_Categorias = new FontAwesome.Sharp.IconButton();
            this.descripcion_Categoria_a_modificar = new System.Windows.Forms.TextBox();
            this.codigo_Categoria_a_modificar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modificar_Categorias
            // 
            this.modificar_Categorias.BackColor = System.Drawing.Color.Transparent;
            this.modificar_Categorias.FlatAppearance.BorderSize = 0;
            this.modificar_Categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_Categorias.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.modificar_Categorias.ForeColor = System.Drawing.Color.White;
            this.modificar_Categorias.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.modificar_Categorias.IconColor = System.Drawing.Color.Gold;
            this.modificar_Categorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modificar_Categorias.Location = new System.Drawing.Point(122, 179);
            this.modificar_Categorias.Name = "modificar_Categorias";
            this.modificar_Categorias.Size = new System.Drawing.Size(145, 48);
            this.modificar_Categorias.TabIndex = 51;
            this.modificar_Categorias.Text = "Modificar";
            this.modificar_Categorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modificar_Categorias.UseVisualStyleBackColor = false;
            this.modificar_Categorias.Click += new System.EventHandler(this.modificar_Categorias_Click);
            // 
            // descripcion_Categoria_a_modificar
            // 
            this.descripcion_Categoria_a_modificar.BackColor = System.Drawing.Color.BlueViolet;
            this.descripcion_Categoria_a_modificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcion_Categoria_a_modificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_Categoria_a_modificar.ForeColor = System.Drawing.Color.White;
            this.descripcion_Categoria_a_modificar.Location = new System.Drawing.Point(122, 133);
            this.descripcion_Categoria_a_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.descripcion_Categoria_a_modificar.Name = "descripcion_Categoria_a_modificar";
            this.descripcion_Categoria_a_modificar.Size = new System.Drawing.Size(203, 25);
            this.descripcion_Categoria_a_modificar.TabIndex = 50;
            // 
            // codigo_Categoria_a_modificar
            // 
            this.codigo_Categoria_a_modificar.BackColor = System.Drawing.Color.BlueViolet;
            this.codigo_Categoria_a_modificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigo_Categoria_a_modificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_Categoria_a_modificar.ForeColor = System.Drawing.Color.White;
            this.codigo_Categoria_a_modificar.Location = new System.Drawing.Point(122, 77);
            this.codigo_Categoria_a_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.codigo_Categoria_a_modificar.Name = "codigo_Categoria_a_modificar";
            this.codigo_Categoria_a_modificar.Size = new System.Drawing.Size(62, 25);
            this.codigo_Categoria_a_modificar.TabIndex = 49;
            this.codigo_Categoria_a_modificar.TextChanged += new System.EventHandler(this.codigo_Categoria_a_modificar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 37);
            this.label1.TabIndex = 47;
            this.label1.Text = "Modificar Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Descripcion";
            // 
            // viewModificarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 246);
            this.Controls.Add(this.modificar_Categorias);
            this.Controls.Add(this.descripcion_Categoria_a_modificar);
            this.Controls.Add(this.codigo_Categoria_a_modificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "viewModificarCategorias";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton modificar_Categorias;
        private System.Windows.Forms.TextBox descripcion_Categoria_a_modificar;
        private System.Windows.Forms.TextBox codigo_Categoria_a_modificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}