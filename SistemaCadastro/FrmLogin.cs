using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnFecharAdicionarGenero_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {   
            ConectaBanco conecta = new ConectaBanco();
            if (conecta.verifica(txtUserLogin.Text, txtSenhaLogin.Text) == true )
            {
                Sistema formSistema = new Sistema();
                this.Hide();
                formSistema.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Usuário ou senha incorretos");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
