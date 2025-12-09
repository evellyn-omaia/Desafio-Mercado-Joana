using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_08._12
{


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

       

    }





}
