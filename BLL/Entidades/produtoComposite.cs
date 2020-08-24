using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Entidades
{
    public class ProdutoComposite : IProduto
    {
        
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public decimal Preco {
            get {
                decimal total = 0m;
                foreach (IProduto p in lista)
                {
                    total += p.Preco;
                }
                return total - (total * 10 / 100m);
            }
            set { } 
        }

        private List<IProduto> lista = new List<IProduto>();

        public void adicionarProduto(IProduto prod)
        {
            lista.Add(prod);
        }

        public override string ToString()
        {
            String prods = " (";
            foreach (IProduto p in lista) prods += p.Nome + ", ";


            return "Produto { Cod: " + Codigo + " Nome: " + Nome +
                " Preco Unitario: " + Preco + prods + ")}";
        }

    }
}
