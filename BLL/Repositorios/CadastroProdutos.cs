using BLL.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositorios
{
    public class CadastroProdutos
    {
        private List<IProduto> lista;

        private static CadastroProdutos instance;

        private CadastroProdutos()
        {
            lista = new List<IProduto>();
        }

        public static CadastroProdutos getInstance()
        {
            if (instance == null)
                instance = new CadastroProdutos();
            return instance;
        }

        public void add(IProduto p)
        {
            lista.Add(p);
        }

        public List<IProduto> getAll()
        {
            return lista;
        }

        public IProduto find(int umCodigo)
        {
            foreach (IProduto prod in lista)
                if (prod.Codigo == umCodigo)
                    return prod;
            return null;

        }


        
    }
}
