using CRUD2_0.Model;
using CRUD2_0.Service;
using CRUD2_0.View;
using System;
using System.Windows.Forms;

namespace CRUD2_0
{
    public partial class btnListar : Form
    {
        public btnListar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var produto = new Produto( txtNomeProduto.Text, numVenda.Value, numCusto.Value);



            var sucesso = new CadastrarProduto().Cadastrar(produto);

            if (sucesso)
            {
                MessageBox.Show("Dados gravados com sucesso");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        { 

            

             var textDateTime = dtPTeste.Value.ToString();
            var testeComboBox =  cbTeste.SelectedIndex.ToString();
            if (checkTeste.Checked)
            {
                Console.WriteLine("Marcado");
            }

            Console.WriteLine($"{textDateTime}, ComboBox:{testeComboBox}");


            var form = new ListarProdutos();
            form.ShowDialog();
        }
    }
}
