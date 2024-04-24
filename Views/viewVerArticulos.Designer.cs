namespace Tp_WinForm_Grupo_19.Views
{
    partial class viewVerArticulos
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowpanelArticles = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.ibSearch = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(455, 413);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowpanelArticles
            // 
            this.flowpanelArticles.AutoScroll = true;
            this.flowpanelArticles.BackColor = System.Drawing.Color.Transparent;
            this.flowpanelArticles.Location = new System.Drawing.Point(12, 89);
            this.flowpanelArticles.Name = "flowpanelArticles";
            this.flowpanelArticles.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.flowpanelArticles.Size = new System.Drawing.Size(984, 491);
            this.flowpanelArticles.TabIndex = 1;
            // 
            // txtBuscador
            // 
            this.txtBuscador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscador.Location = new System.Drawing.Point(12, 47);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(287, 20);
            this.txtBuscador.TabIndex = 2;
            // 
            // ibSearch
            // 
            this.ibSearch.BackColor = System.Drawing.Color.Transparent;
            this.ibSearch.FlatAppearance.BorderSize = 0;
            this.ibSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ibSearch.IconColor = System.Drawing.Color.Black;
            this.ibSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSearch.IconSize = 30;
            this.ibSearch.Location = new System.Drawing.Point(305, 38);
            this.ibSearch.Name = "ibSearch";
            this.ibSearch.Size = new System.Drawing.Size(38, 36);
            this.ibSearch.TabIndex = 3;
            this.ibSearch.UseVisualStyleBackColor = false;
            // 
            // viewVerArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 575);
            this.Controls.Add(this.ibSearch);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.flowpanelArticles);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "viewVerArticulos";
            this.Text = "viewVerArticulos";
            this.Load += new System.EventHandler(this.viewVerArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowpanelArticles;
        private System.Windows.Forms.TextBox txtBuscador;
        private FontAwesome.Sharp.IconButton ibSearch;
    }
}