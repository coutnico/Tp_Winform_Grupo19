namespace Tp_WinForm_Grupo_19.Views
{
    partial class viewModificarMarcas
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo_Marca_a_modificar = new System.Windows.Forms.TextBox();
            this.descripcion_Marca_a_modificar = new System.Windows.Forms.TextBox();
            this.modificar_Marcas = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "Modificar marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(148, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // codigo_Marca_a_modificar
            // 
            this.codigo_Marca_a_modificar.BackColor = System.Drawing.Color.BlueViolet;
            this.codigo_Marca_a_modificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigo_Marca_a_modificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_Marca_a_modificar.ForeColor = System.Drawing.Color.White;
            this.codigo_Marca_a_modificar.Location = new System.Drawing.Point(183, 66);
            this.codigo_Marca_a_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.codigo_Marca_a_modificar.Name = "codigo_Marca_a_modificar";
            this.codigo_Marca_a_modificar.Size = new System.Drawing.Size(62, 25);
            this.codigo_Marca_a_modificar.TabIndex = 32;
            this.codigo_Marca_a_modificar.TextChanged += new System.EventHandler(this.codigo_Marca_a_modificar_TextChanged);
            // 
            // descripcion_Marca_a_modificar
            // 
            this.descripcion_Marca_a_modificar.BackColor = System.Drawing.Color.BlueViolet;
            this.descripcion_Marca_a_modificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcion_Marca_a_modificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_Marca_a_modificar.ForeColor = System.Drawing.Color.White;
            this.descripcion_Marca_a_modificar.Location = new System.Drawing.Point(183, 122);
            this.descripcion_Marca_a_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.descripcion_Marca_a_modificar.Name = "descripcion_Marca_a_modificar";
            this.descripcion_Marca_a_modificar.Size = new System.Drawing.Size(203, 25);
            this.descripcion_Marca_a_modificar.TabIndex = 33;
            // 
            // modificar_Marcas
            // 
            this.modificar_Marcas.BackColor = System.Drawing.Color.Transparent;
            this.modificar_Marcas.FlatAppearance.BorderSize = 0;
            this.modificar_Marcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_Marcas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.modificar_Marcas.ForeColor = System.Drawing.Color.White;
            this.modificar_Marcas.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.modificar_Marcas.IconColor = System.Drawing.Color.Gold;
            this.modificar_Marcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modificar_Marcas.Location = new System.Drawing.Point(183, 168);
            this.modificar_Marcas.Name = "modificar_Marcas";
            this.modificar_Marcas.Size = new System.Drawing.Size(145, 48);
            this.modificar_Marcas.TabIndex = 45;
            this.modificar_Marcas.Text = "Modificar";
            this.modificar_Marcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modificar_Marcas.UseVisualStyleBackColor = false;
            this.modificar_Marcas.Click += new System.EventHandler(this.modificar_Marcas_Click);
            // 
            // viewModificarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 238);
            this.Controls.Add(this.modificar_Marcas);
            this.Controls.Add(this.descripcion_Marca_a_modificar);
            this.Controls.Add(this.codigo_Marca_a_modificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "viewModificarMarcas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo_Marca_a_modificar;
        private System.Windows.Forms.TextBox descripcion_Marca_a_modificar;
        private FontAwesome.Sharp.IconButton modificar_Marcas;
    }
}