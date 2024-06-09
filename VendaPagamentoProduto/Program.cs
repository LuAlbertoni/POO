using POO;

while (true)
{
    Console.WriteLine("\n=-=-=-=-=- MENU =-=-=-=-=\n1. Cadastrar Produto\n2. Realizar Venda\n3. Sair\n=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.Write("Escolha uma opção: ");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Produto.CadastrarProduto();
            break;
        case 2:
            Venda.RealizarVenda(Produto.produtos, Venda.Vendas);
            break;
        case 3:
            return;
    }
}