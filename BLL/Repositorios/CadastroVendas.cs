using BLL.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositorios
{
    public class CadastroVendas
    {
        private List<Venda> lista;

        private static CadastroVendas instance;

        private CadastroVendas()
        {
            lista = new List<Venda>();
        }

        public static CadastroVendas getInstance()
        {
            if (instance == null)
                instance = new CadastroVendas();
            return instance;
        }

        public void add(Venda p)
        {
            lista.Add(p);
        }

   

        public Venda find(int umCodigo)
        {
            foreach (Venda venda in lista)
                if (venda.NroVenda == umCodigo)
                    return venda;
            return null;

        }

    }
}

