using ComposicaoBanco;

Banco banco = new Banco(10, 10);

Console.WriteLine("=-=-=-=-= Abertura de contas =-=-=-=-=");
banco.AbrirContaCorrente(1000, 500);
banco.AbrirContaCorrente(500, 100);
banco.AbrirContaCorrente(100, 50);
banco.AbrirPoupanca(100);

Console.WriteLine("\n=-=-=-=-= Conta corrente =-=-=-=-=");

banco.contasCorrente[0].Depositar(500);
banco.contasCorrente[0].Sacar(100);
banco.contasCorrente[0].GerarExtrato();

Console.WriteLine("\n=-=-=-=-= Conta corrente com cheque especial =-=-=-=-=");

banco.contasCorrente[1].Depositar(100);
banco.contasCorrente[1].Sacar(700);
banco.contasCorrente[1].GerarExtrato();

Console.WriteLine("\n=-=-=-=-= Conta corrente sem saldo suficiente =-=-=-=-=");

banco.contasCorrente[2].Depositar(50);
banco.contasCorrente[2].Sacar(201);
banco.contasCorrente[2].GerarExtrato();

Console.WriteLine("\n=-=-=-=-= Conta poupança =-=-=-=-=");

banco.poupancas[0].Depositar(150);
banco.poupancas[0].Sacar(50);
banco.poupancas[0].GerarRendimento(10);

Console.WriteLine("\n=-=-=-=-= Falência =-=-=-=-=");
banco.DecretarFalencia();