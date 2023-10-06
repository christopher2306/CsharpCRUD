using System.Security.Cryptography.X509Certificates;

namespace Funcionarios
{
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!txtNome.Text.Equals("")) && (!txtCPF.Text.Equals("")) && (!txtEmail.Text.Equals("")) && (!txtEndereco.Text.Equals("")))
                {
                    CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                    cadFuncionarios.Nome = txtNome.Text;
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Cpf = txtCPF.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcionário {cadFuncionarios.Nome} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar funcionário!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtNome.Clear();
                    txtCPF.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
            }
        }
    }
}