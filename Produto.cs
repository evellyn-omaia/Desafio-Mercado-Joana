using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_08._12
{
}

public class Produtos
{


    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
    public void ExibirEstoque(List<Produtos> listaProduto)
    {
        Console.WriteLine($"lista de produtos");
        Console.WriteLine("Nome  Quantidade  Preço");
        Console.WriteLine("");
        for (int i = 0; i < listaProduto.Count; i++)
        {

            Console.WriteLine($" {listaProduto[i].Nome},  {listaProduto[i].Quantidade},  {listaProduto[i].Preco}");
        }

    }

    public void VerificarEstoque(List<Produtos> listaProduto)
    {

        foreach (var percorrer in listaProduto)
        {
            if (percorrer.Quantidade < 5)
            {
                Console.WriteLine($"O produto {percorrer.Nome} esta com o estoque acabando. Você precisa repor o estoque");
            }
            else
            {
                Console.WriteLine("Os estoques estão cheios!");
            }
        }
    }

    public void Vender()
    {

    }
    public void Relatorio(List<Produtos> relatorioVenda)
    {
        {
            Console.WriteLine("Relatório de vendas:");
            Console.WriteLine("");

            double precoTotal = 0;
            int quantidadeVendido = 0;

            foreach (var p in relatorioVenda)
            {
                Console.WriteLine($"Produto: {p.Nome} | Quantidade vendida: {p.Quantidade} | Preço unitário: {p.Preco}");
                precoTotal += p.Preco * p.Quantidade;
                quantidadeVendido += p.Quantidade;

            }

            Console.WriteLine("");
            Console.Write("Quantidade total de produtos vendidos: ");
            Console.WriteLine(quantidadeVendido);
            Console.WriteLine($"Preço total de produtos vendidos: ${precoTotal}");
            Console.WriteLine("");
        }
    }

    public void CancelarVenda(List<Produtos> listaProduto)
    {
        Console.WriteLine("Selecione o produto que você deseja remover");
        int indice3 = 0;
        foreach (var p in listaProduto)
        {
            Console.WriteLine($"{indice3 + 1} - {p.Nome} (Estoque: {p.Quantidade})");

            indice3++;

        }
        Console.Write("Opção: ");
        int escolha3 = int.Parse(Console.ReadLine()) - 1;

        listaProduto.Remove(listaProduto[escolha3 - 1]);
    }




}
