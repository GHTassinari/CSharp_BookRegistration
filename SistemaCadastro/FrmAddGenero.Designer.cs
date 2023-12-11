namespace SistemaCadastro
{
    partial class FrmAddGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddGenero));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdicionarGenero = new System.Windows.Forms.Label();
            this.txtAddGenero = new System.Windows.Forms.TextBox();
            this.lblNomeGeneroAdicionar = new System.Windows.Forms.Label();
            this.BtnCadastrarNovoGenero = new System.Windows.Forms.Button();
            this.btnFecharAdicionarGenero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 450);
            this.panel1.TabIndex = 1;
            // 
            // lblAdicionarGenero
            // 
            this.lblAdicionarGenero.AutoSize = true;
            this.lblAdicionarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdicionarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarGenero.Location = new System.Drawing.Point(312, 85);
            this.lblAdicionarGenero.Name = "lblAdicionarGenero";
            this.lblAdicionarGenero.Size = new System.Drawing.Size(224, 31);
            this.lblAdicionarGenero.TabIndex = 2;
            this.lblAdicionarGenero.Text = "Adicionar Gênero";
            // 
            // txtAddGenero
            // 
            this.txtAddGenero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddGenero.Location = new System.Drawing.Point(292, 140);
            this.txtAddGenero.Name = "txtAddGenero";
            this.txtAddGenero.Size = new System.Drawing.Size(276, 29);
            this.txtAddGenero.TabIndex = 10;
            // 
            // lblNomeGeneroAdicionar
            // 
            this.lblNomeGeneroAdicionar.AutoSize = true;
            this.lblNomeGeneroAdicionar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNomeGeneroAdicionar.ForeColor = System.Drawing.Color.DimGray;
            this.lblNomeGeneroAdicionar.Location = new System.Drawing.Point(215, 143);
            this.lblNomeGeneroAdicionar.Name = "lblNomeGeneroAdicionar";
            this.lblNomeGeneroAdicionar.Size = new System.Drawing.Size(61, 21);
            this.lblNomeGeneroAdicionar.TabIndex = 11;
            this.lblNomeGeneroAdicionar.Text = "Nome:";
            // 
            // BtnCadastrarNovoGenero
            // 
            this.BtnCadastrarNovoGenero.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarNovoGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarNovoGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCadastrarNovoGenero.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCadastrarNovoGenero.Image = global::SistemaCadastro.Properties.Resources.adicionar;
            this.BtnCadastrarNovoGenero.Location = new System.Drawing.Point(356, 175);
            this.BtnCadastrarNovoGenero.Name = "BtnCadastrarNovoGenero";
            this.BtnCadastrarNovoGenero.Size = new System.Drawing.Size(131, 49);
            this.BtnCadastrarNovoGenero.TabIndex = 14;
            this.BtnCadastrarNovoGenero.Text = "&Cadastrar";
            this.BtnCadastrarNovoGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastrarNovoGenero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCadastrarNovoGenero.UseVisualStyleBackColor = true;
            this.BtnCadastrarNovoGenero.Click += new System.EventHandler(this.BtnCadastrarNovoGenero_Click);
            // 
            // btnFecharAdicionarGenero
            // 
            this.btnFecharAdicionarGenero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFecharAdicionarGenero.Location = new System.Drawing.Point(702, 41);
            this.btnFecharAdicionarGenero.Name = "btnFecharAdicionarGenero";
            this.btnFecharAdicionarGenero.Size = new System.Drawing.Size(75, 23);
            this.btnFecharAdicionarGenero.TabIndex = 15;
            this.btnFecharAdicionarGenero.Text = "X";
            this.btnFecharAdicionarGenero.UseVisualStyleBackColor = false;
            this.btnFecharAdicionarGenero.Click += new System.EventHandler(this.btnFecharAdicionarGenero_Click);
            // 
            // FrmAddGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFecharAdicionarGenero);
            this.Controls.Add(this.BtnCadastrarNovoGenero);
            this.Controls.Add(this.lblNomeGeneroAdicionar);
            this.Controls.Add(this.txtAddGenero);
            this.Controls.Add(this.lblAdicionarGenero);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddGenero";
            this.Text = "FrmAddGenero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdicionarGenero;
        private System.Windows.Forms.TextBox txtAddGenero;
        private System.Windows.Forms.Label lblNomeGeneroAdicionar;
        private System.Windows.Forms.Button BtnCadastrarNovoGenero;
        private System.Windows.Forms.Button btnFecharAdicionarGenero;
    }
}