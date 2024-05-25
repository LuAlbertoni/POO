using Interface;
        
ContaCorrente conta = new ContaCorrente(100.0);
SeguroDeVida seguro = new SeguroDeVida();

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
totalizador.Adiciona(conta);
totalizador.Adiciona(seguro);

Console.WriteLine("Total de impostos a pagar: " + totalizador.Total);