using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        int idAlterar;
        public Sistema()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }
        

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }







        private void Sistema_Load(object sender, EventArgs e)
        {
            listaCBGeneros();
            listagridLivros();
        }

        void listagridLivros()
        {
            ConectaBanco con = new ConectaBanco();
            dgLivros.DataSource = con.listaLivros();

            dgLivros.Columns["idlivros"].Visible = false;
            dgLivros.Columns["titulo"].HeaderText = "Título";
            dgLivros.Columns["paginas"].HeaderText = "Páginas";
            dgLivros.Columns["autor"].HeaderText = "Autor";
            dgLivros.Columns["genero"].HeaderText = "Gênero";
        }

        public void listaCBGeneros()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();

            // Adiciona uma opção padrão ao DataTable
            tabelaDados.Columns.Add("genero");
            tabelaDados.Columns.Add("idgenero");
            tabelaDados.Rows.Add("Selecione um gênero", DBNull.Value);

            // Carrega os dados do banco de dados
            DataTable generosDoBanco = con.listaGeneros();

            // Adiciona os gêneros do banco à tabela
            foreach (DataRow row in generosDoBanco.Rows)
            {
                tabelaDados.ImportRow(row);
            }

            cbGenero.DataSource = tabelaDados;
            cbGenero.DisplayMember = "genero";
            cbGenero.ValueMember = "idgenero";

            cbAlteraGenero.DataSource = tabelaDados;
            cbAlteraGenero.DisplayMember = "genero";
            cbAlteraGenero.ValueMember = "idgenero";

            // Seleciona a opção padrão
            cbGenero.SelectedIndex = 0;
        }



        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgLivros.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("titulo like '{0}%'", txtBusca.Text);
        }

        private void btnRemoveBanda_Click(object sender, EventArgs e)
        {
            int linha = dgLivros.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgLivros.Rows[linha].Cells["idlivros"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remover livro", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaLivro(id);
                if (retorno == true)
                {
                    MessageBox.Show("Livro excluido com sucesso!");
                    listagridLivros();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dgLivros.CurrentRow.Index;// pega a linha selecionada
            idAlterar = Convert.ToInt32(
              dgLivros.Rows[linha].Cells["idlivros"].Value.ToString());
            txtAlteraTitulo.Text =
                 dgLivros.Rows[linha].Cells["titulo"].Value.ToString();
            txtAlteraAutor.Text =
                dgLivros.Rows[linha].Cells["autor"].Value.ToString();
            txtAlteraPaginas.Text =
                dgLivros.Rows[linha].Cells["paginas"].Value.ToString();
            cbAlteraGenero.Text =
                dgLivros.Rows[linha].Cells["genero"].Value.ToString();
            tabControl1.SelectedTab = tabAlterar;// muda aba
        }

         private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {

            ConectaBanco con = new ConectaBanco();
            livro novoLivro = new livro();
            novoLivro.Titulo = txtAlteraTitulo.Text;
            novoLivro.Autor = txtAlteraAutor.Text;
            novoLivro.Paginas = Convert.ToInt32(txtAlteraPaginas.Text);
            novoLivro.Genero = Convert.ToInt32(cbAlteraGenero.SelectedValue.ToString());

            bool retorno = con.alteraLivro(novoLivro, idAlterar);

            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
            { 
                MessageBox.Show("Alteração realizada com sucesso!");

                limpaAlteraCampos();
                listagridLivros();
            }

        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {
            FrmAddGenero formGenero = new FrmAddGenero();
            this.Hide();
            formGenero.ShowDialog();
            this.Close();
        }
        
        void limpaCampos()
        {
            txtTitulo.Clear();
            cbGenero.Text = "";
            txtAutor.Clear();
            txtPaginas.Clear();
            txtTitulo.Focus();

        }

        void limpaAlteraCampos()
        {
            txtAlteraTitulo.Clear();
            cbAlteraGenero.Text = "";
            txtAlteraAutor.Clear();
            txtAlteraPaginas.Clear();
            txtAlteraTitulo.Focus();

        }

        private bool CamposPreenchidos()
        {
            return !string.IsNullOrWhiteSpace(txtTitulo.Text) &&
                   !string.IsNullOrWhiteSpace(txtAutor.Text) &&
                   !string.IsNullOrWhiteSpace(txtPaginas.Text) &&
                   cbGenero.SelectedItem != null &&
                   !string.IsNullOrWhiteSpace(cbGenero.SelectedItem.ToString()) &&
                   !cbGenero.SelectedItem.ToString().Equals("Selecione um gênero");
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {

           // Verificar se todos os campos necessários foram preenchidos
            if (CamposPreenchidos())
            {
                ConectaBanco con = new ConectaBanco();
                livro novoLivro = new livro();
                novoLivro.Titulo = txtTitulo.Text;
                novoLivro.Autor = txtAutor.Text;

                if (int.TryParse(txtPaginas.Text, out int paginas))
                {
                    novoLivro.Paginas = paginas;
                }
                else
                {
                    // Tratar o caso em que a conversão falha
                    MessageBox.Show("O campo 'Páginas' deve ser um valor numérico.");
                    return;
                }

                if (txtAutor.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("O campo 'Autor' não pode conter números.");
                    return;
                }

                if (int.TryParse(cbGenero.SelectedValue?.ToString(), out int generoId))
                {
                    novoLivro.Genero = generoId;
                }
                else
                {
                    // Tratar o caso em que a conversão falha
                    MessageBox.Show("Selecione um gênero para o livro.");
                    return;
                }


                bool retorno = con.insereLivro(novoLivro);

                if (retorno)
                {
                    MessageBox.Show("Livro cadastrado com sucesso!");
                    limpaCampos();

                    cbGenero.SelectedIndex = 0;

                    listagridLivros();
                }
                else
                {
                    MessageBox.Show(con.mensagem);
                }
            }
            else
            {
                // Mostrar apenas os campos que não foram preenchidos
                string camposFaltando = "Por favor, insira valores nos seguintes campos:\n";

                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                    camposFaltando += "- Título do livro\n";

                if (string.IsNullOrWhiteSpace(txtAutor.Text))
                    camposFaltando += "- Autor do livro\n";

                if (string.IsNullOrWhiteSpace(txtPaginas.Text))
                    camposFaltando += "- Número de páginas\n";

                MessageBox.Show(camposFaltando);
            }
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtranking_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
