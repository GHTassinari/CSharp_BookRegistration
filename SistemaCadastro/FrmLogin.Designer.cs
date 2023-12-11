namespace SistemaCadastro
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnFecharAdicionarGenero = new System.Windows.Forms.Button();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFecharAdicionarGenero
            // 
            this.btnFecharAdicionarGenero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFecharAdicionarGenero.Location = new System.Drawing.Point(634, 57);
            this.btnFecharAdicionarGenero.Name = "btnFecharAdicionarGenero";
            this.btnFecharAdicionarGenero.Size = new System.Drawing.Size(75, 23);
            this.btnFecharAdicionarGenero.TabIndex = 16;
            this.btnFecharAdicionarGenero.Text = "X";
            this.btnFecharAdicionarGenero.UseVisualStyleBackColor = false;
            this.btnFecharAdicionarGenero.Click += new System.EventHandler(this.btnFecharAdicionarGenero_Click);
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserLogin.Location = new System.Drawing.Point(249, 129);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(276, 29);
            this.txtUserLogin.TabIndex = 17;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSenhaLogin.Location = new System.Drawing.Point(249, 189);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(276, 29);
            this.txtSenhaLogin.TabIndex = 18;
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfirmaAlteracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracao.Image")));
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(331, 247);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(111, 49);
            this.btnConfirmaAlteracao.TabIndex = 23;
            this.btnConfirmaAlteracao.Text = "Acessar";
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblUsuarioLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(245, 105);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(70, 21);
            this.lblUsuarioLogin.TabIndex = 24;
            this.lblUsuarioLogin.Text = "Usuário:";
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblSenhaLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblSenhaLogin.Location = new System.Drawing.Point(245, 165);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(63, 21);
            this.lblSenhaLogin.TabIndex = 25;
            this.lblSenhaLogin.Text = "Senha:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSenhaLogin);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.btnConfirmaAlteracao);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.btnFecharAdicionarGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecharAdicionarGenero;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btnConfirmaAlteracao;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.Label lblSenhaLogin;
    }
}