using System.Collections;
using Desafio_08._12;
Produtos produtos = new Produtos();

int escolha = 0;
List<Produtos> listaProduto = new List<Produtos>();
List<Produtos> relatorioVenda = new List<Produtos>();

while (escolha != 8)
{
    Console.WriteLine("");
    Console.WriteLine("=====MENU=====");
    Console.WriteLine("1. Cadastrar Produtos ");
    Console.WriteLine("2. Cadastrar venda");
    Console.WriteLine("3. Produtos em estoque");
    Console.WriteLine("4. Gerenciar estoque");
    Console.WriteLine("5. Gerar relatorio de venda");
    Console.WriteLine("6. Cancelar venda");
    Console.WriteLine("7. Remover produto do estoque");
    Console.WriteLine("8. Desligar sistema");
    Console.WriteLine("");

    Console.Write("Opção: ");
    escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.WriteLine("");
            Console.WriteLine($"Insira os dados do produto que você deseja cadastrar");
            Produtos novoProduto = new Produtos();
            Console.Write("Nome: ");
            novoProduto.Nome = Console.ReadLine();
            // listaNome.Add(nome);

            Console.Write("Quantidade em estoque: ");
            novoProduto.Quantidade = int.Parse(Console.ReadLine());
            // listaQuantidade.Add(quantidade);

            Console.Write("Preço: ");
            novoProduto.Preco = double.Parse(Console.ReadLine());
            listaProduto.Add(novoProduto);

            break;

        case 2:
            Console.WriteLine("");
            Console.WriteLine("Selecione o produto que deseja vender:");
            int indice = 0;
            // p guarda o item (nome, quantidade) enqunto    vai percorrendo o loop. 

            foreach (var p in listaProduto)
            {
                Console.WriteLine($"{indice + 1} - {p.Nome} (Estoque: {p.Quantidade})");
                // p.nome/p.quantidade = ta percorrendo a parte nome dps a quantidade para exibir
                indice++;

            }
            Console.WriteLine("");
            Console.Write("Opção: ");
            int produtoSelecionado = int.Parse(Console.ReadLine()) - 1;

            Produtos produtoVenda = listaProduto[produtoSelecionado];
            Console.WriteLine("");

            Console.Write("Quantidade que deseja vender: ");
            int qtdVenda = int.Parse(Console.ReadLine());
            Console.WriteLine("");





            if (qtdVenda <= 0)
            {
                Console.WriteLine("Quantidade inválida!");
            }
            else if (qtdVenda > produtoVenda.Quantidade)
            {
                Console.WriteLine("Erro! Estoque insuficiente.");
            }
            else
            {
                produtoVenda.Quantidade -= qtdVenda;
                Produtos venda = new Produtos();
                venda.Nome = produtoVenda.Nome;
                venda.Quantidade = qtdVenda;
                venda.Preco = produtoVenda.Preco;

                relatorioVenda.Add(venda);
                Console.WriteLine("Venda registrada com sucesso!");
            }

            if (produtoVenda.Quantidade == 0)
            {
                Console.WriteLine("Produto esgotado! Removendo do estoque...");
                listaProduto.Remove(produtoVenda);
            }



            break;

        case 3:
            Console.WriteLine("");
            produtos.ExibirEstoque(listaProduto);
            break;
        case 4:
        produtos.VerificarEstoque(listaProduto);
            break;
        case 5:
            produtos.Relatorio(relatorioVenda);

            break;
        case 6:
            Console.WriteLine("Selecione o produto que você deseja cancelar a venda");

            int indice2 = 0;
            foreach (var p in listaProduto)
            {
                Console.WriteLine($"{indice2 + 1} - {p.Nome} (Estoque: {p.Quantidade})");

                indice2++;

            }
            Console.Write("Opção: ");
            int escolha2 = int.Parse(Console.ReadLine());

            Produtos produtos1 = listaProduto[escolha2 - 1];
            Console.WriteLine("");

            Console.WriteLine("Informe a quantidade que você deseja devolver");
            int devolver = int.Parse(Console.ReadLine());

            produtos1.Quantidade += devolver;

            Console.WriteLine("Venda cancelada com sucesso!");
            Console.WriteLine("");

            produtos.ExibirEstoque(listaProduto);
            break;
        case 7:
           produtos.CancelarVenda(listaProduto);
            break;
        case 8:
            Console.WriteLine("desligando...");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sistema encerrado!");

            break;
            default:
            Console.WriteLine("");
            Console.WriteLine("Opção inválida!");

            break;
    }
}