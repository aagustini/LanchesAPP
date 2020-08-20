using BLL.Entidades;
using System;

namespace TesteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto()
            {
                Codigo = 1,
                Nome = "Caneta Azul",
                Preco = 2.5m
            };
            Produto p2 = new Produto()
            {
                Codigo = 2,
                Nome = "Lapis",
                Preco = 1m
            };
            Produto p3 = new Produto()
            {
                Codigo = 3,
                Nome = "Borracha",
                Preco = 2m
            };
            Produto p4 = new Produto()
            {
                Codigo = 7,
                Nome = "Chocolate",
                Preco = 10m
            };

            Venda venda1 = new Venda();
            venda1.inserir(3, p1);
            venda1.inserir(1, p3);
            venda1.inserir(1, p4);
            venda1.fechar();

            Console.WriteLine(venda1.gerarNota());
        }
    }
}
