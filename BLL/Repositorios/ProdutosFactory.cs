using BLL.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositorios
{
    public class ProdutosFactory
    {
        public static IProduto criar(int umCodigo, string umNome, decimal umPreco)
        {
            return new Produto()
            {
                Codigo = umCodigo,
                Nome = umNome,
                Preco = umPreco
            };
        }

        public static IProduto criar(int umCodigo, string umNome, List<int> prods)
        {
            ProdutoComposite novo = new ProdutoComposite()
            {
                Codigo = umCodigo,
                Nome = umNome
            };

            foreach (int prod in prods)
            {
                // confiando que o produto estah lah
                novo.adicionarProduto(CadastroProdutos.getInstance().find(prod));
            }
            return novo;


        }

        //deprecated
        public static IProduto criar(int umCodigo, string umNome, List<IProduto> prods)
        {
            ProdutoComposite novo = new ProdutoComposite()
            {
                Codigo = umCodigo,
                Nome = umNome
            };

            foreach (IProduto prod in prods)
            {
                // confiando que o produto estah lah
                novo.adicionarProduto(prod);
            }
            return novo;


        }
    }
}
