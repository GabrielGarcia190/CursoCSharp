using CRUD2_0.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD2_0.View
{
    public partial class ListarProdutos : Form
    {
        public ListarProdutos()
        {
            InitializeComponent();
        }

        private void ListarProdutos_Load(object sender, EventArgs e)
        {
            var dados = new BuscarProduto().Buscar();

            dgListProds.DataSource = dados;
        }
    }
}
