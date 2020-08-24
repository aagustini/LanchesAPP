using BLL.Entidades;
using BLL.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Fachada
{
    public class FachadaVendas
    {
        CadastroVendas cadVendas = CadastroVendas.getInstance();
        CadastroProdutos cadProds = CadastroProdutos.getInstance();
        public int iniciarVenda() {
            Venda nova = new Venda();
            cadVendas.add(nova);
            return nova.NroVenda;         
        }
        public void fecharVenda(int codigo) {
            Venda venda = cadVendas.find(codigo);
            venda.fechar();
        }

        public void pedido(int umaVenda, int umProd, int umaQtde)
        {
            Venda venda = cadVendas.find(umaVenda);
            IProduto prod = cadProds.find(umProd);
            venda.inserir(umaQtde, prod);
        }

        public String nota(int umaVenda)
        {
            Venda venda = cadVendas.find(umaVenda);

            return venda.gerarNota();
        }
    }
}
