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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ibSearch = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(834, 762);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(15, 15);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowpanelArticles
            // 
            this.flowpanelArticles.AutoScroll = true;
            this.flowpanelArticles.BackColor = System.Drawing.Color.Transparent;
            this.flowpanelArticles.Location = new System.Drawing.Point(22, 164);
            this.flowpanelArticles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowpanelArticles.Name = "flowpanelArticles";
            this.flowpanelArticles.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.flowpanelArticles.Size = new System.Drawing.Size(1804, 906);
            this.flowpanelArticles.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(22, 87);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.ibSearch.Location = new System.Drawing.Point(559, 70);
            this.ibSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ibSearch.Name = "ibSearch";
            this.ibSearch.Size = new System.Drawing.Size(70, 66);
            this.ibSearch.TabIndex = 3;
            this.ibSearch.UseVisualStyleBackColor = false;
            // 
            // viewVerArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 1093);
            this.Controls.Add(this.ibSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowpanelArticles);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "viewVerArticulos";
            this.Text = "viewVerArticulos";
            this.Load += new System.EventHandler(this.viewVerArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowpanelArticles;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ibSearch;
    }
}