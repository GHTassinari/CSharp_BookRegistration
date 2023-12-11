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
    public partial class FrmAddGenero : Form
    {
        public FrmAddGenero()
        {
            InitializeComponent();
        }

        private void BtnCadastrarNovoGenero_Click(object sender, EventArgs e)
        {
                ConectaBanco con = new ConectaBanco();
                

                bool retorno = con.insereGenero(txtAddGenero.Text);

                if (retorno == false)
                    MessageBox.Show(con.mensagem);
                else
                {
                    MessageBox.Show("Genero adicionado com sucesso!");
                    txtAddGenero.Clear();
                    txtAddGenero.Focus();
                    
                }
        }

        private void btnFecharAdicionarGenero_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Sistema formSistema = new Sistema();
            formSistema.ShowDialog();
            this.Close();

        }
    }
}
