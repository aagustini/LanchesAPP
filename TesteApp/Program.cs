using BLL.Entidades;
using BLL.Fachada;
using System;
using System.Collections.Generic;

namespace TesteApp
{
    class Program
    {
        static void Main0(string[] args)
        {
            Produto p1 = new Produto()
            {
                Codigo = 1,
                Nome = "Refrigerante lata",
                Preco = 5m
            };
            Produto p2 = new Produto()
            {
                Codigo = 2,
                Nome = "Super bauru",
                Preco = 25m
            };
            Produto p3 = new Produto()
            {
                Codigo = 3,
                Nome = "Torrada americana",
                Preco = 15m
            };
            Produto p4 = new Produto()
            {
                Codigo = 4,
                Nome = "Barra Chocolate",
                Preco = 6m
            };
            Produto p5 = new Produto()
            {
                Codigo = 5,
                Nome = "Cafe com leite",
                Preco = 4m
            };
            Produto p6 = new Produto()
            {
                Codigo = 6,
                Nome = "Fritas",
                Preco = 10m
            };
          
            Venda venda1 = new Venda();
            venda1.inserir(1, p1);
            venda1.inserir(1, p2);
            venda1.inserir(1, p6);
            venda1.fechar();
            Console.WriteLine(venda1.gerarNota());

            ProdutoComposite p100 = new ProdutoComposite() { 
                Codigo = 100, 
                Nome = "Combo1" };

            p100.adicionarProduto(p1);
            p100.adicionarProduto(p2);
            p100.adicionarProduto(p6);

            Console.WriteLine("Combo1: " + p100.ToString());
            Console.WriteLine("Combo1-codigo: " + p100.Codigo);
            Console.WriteLine("Combo1-nome: " + p100.Nome);
            Console.WriteLine("Combo1-preco: " + p100.Preco);

            ProdutoComposite superCombo = new ProdutoComposite()
            {
                Codigo = 700,
                Nome = "Super combo"
            };

            superCombo.adicionarProduto(p100);
            superCombo.adicionarProduto(p100);

            Console.WriteLine("SuperCombo: " + superCombo);
            Venda venda2 = new Venda();
            //venda2.inserir(1, p100);
            //venda2.inserir(2, p4);
            venda2.inserir(1, superCombo);
            venda2.fechar();

            Console.WriteLine();
            Console.WriteLine(venda2.gerarNota());
        }

        
        static void Main(string[] args)
        {
            FachadaProdutos fachadaProd = new FachadaProdutos();

            fachadaProd.adicionar(1, "Refrigerante lata", 5m);
            fachadaProd.adicionar(2, "Super bauru", 25m);
            fachadaProd.adicionar(3, "Torrada americana", 15m);
            fachadaProd.adicionar(4, "Barra Chocolate", 6m);
            fachadaProd.adicionar(5, "Cafe com leite", 4m);
            fachadaProd.adicionar(6, "Fritas", 10m);

            fachadaProd.adicionar(100, "Combo 1", new List<int>() { 1, 2, 6 });

            Console.WriteLine("Produtos cadastrados");
            foreach (IProduto prod in fachadaProd.buscarProdutos())
            {
                Console.WriteLine(prod);
            }


            FachadaVendas fachada = new FachadaVendas();
            int venda1 = fachada.iniciarVenda();
            fachada.pedido(venda1, 1, 1);
            fachada.pedido(venda1, 2, 1);
            fachada.pedido(venda1, 6, 1);
            
            fachada.fecharVenda(venda1);
            Console.WriteLine();
            Console.WriteLine(fachada.nota(venda1));

            int venda2 = fachada.iniciarVenda();
            fachada.pedido(venda2, 100, 1);
            fachada.pedido(venda2, 4, 2);
            
            fachada.fecharVenda(venda2);
            Console.WriteLine();
            Console.WriteLine(fachada.nota(venda2));     
        }
    }
}
