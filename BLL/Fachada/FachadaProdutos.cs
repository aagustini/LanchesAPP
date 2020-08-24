using BLL.Entidades;
using BLL.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Fachada
{
    public class FachadaProdutos
    {
        public void adicionar(int c, String n, decimal p)
        {
            IProduto prod = ProdutosFactory.criar(c, n, p);
            CadastroProdutos.getInstance().add(prod);
        
       }
        public void adicionar(int c, String n, List<int> lista)
        {
            IProduto prod = ProdutosFactory.criar(c, n, lista);
            CadastroProdutos.getInstance().add(prod);
        }

        // deprecated
        public void adicionar(int c, String n, List<IProduto> lista)
        {
            IProduto prod = ProdutosFactory.criar(c, n, lista);
            CadastroProdutos.getInstance().add(prod);
        }
        public List<IProduto> buscarProdutos()
        {
            return CadastroProdutos.getInstance().getAll();
        }
    }
}
