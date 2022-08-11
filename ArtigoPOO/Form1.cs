using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtigoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtribuirValores_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto do tipo produto
            Produto objetoProduto = new Produto();

            //Atribuindo valores a suas propriedades
            objetoProduto._codigo = 2055;
            objetoProduto._nome = "Refrigerante Laranja Lata 350ml";
            objetoProduto._preco_compra = 1.75m;
            objetoProduto._preco_venda = 2.5m;
            objetoProduto._quantidade_estoque = 50;
            objetoProduto._ativo = true;
            objetoProduto._data_cadastro = DateTime.Now;

            //Mostrando informações do produto na tela
            MessageBox.Show("Informações do produto:" + "\n" +
                "Código: " + objetoProduto._codigo + "\n" +
                "Nome: " + objetoProduto._nome + "\n" +
                "Preço de compra : " + objetoProduto._preco_compra + "\n" +
                "Preço de venda: " + objetoProduto._preco_venda + "\n" +
                "Qtde estoque: " + objetoProduto._quantidade_estoque + "\n" +
                "Status produto: " + (objetoProduto._ativo == true ? "Ativo" : "Inativo") + "\n" +
                "Data cadastro: " + objetoProduto._data_cadastro);                
        }
    }
}
