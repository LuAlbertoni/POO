using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Ana", 1000);
Console.WriteLine("Bonificação do funcionário: " + f.CalcularBonificacao());

Secretario s = new Secretario(2, "Bel", 1000);
Console.WriteLine("Bonificação do secretario: " + s.CalcularBonificacao());

Gerente g = new Gerente(3,"Bia",1000);
Console.WriteLine("Bonificação do gerente: " + g.CalcularBonificacao());

Diretor d = new Diretor(4, "Leo", 1000);
Console.WriteLine("Bonificação do diretor: " + d.CalcularBonificacao());

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

gerenciador.TotalizadorBonificacao(f);
gerenciador.TotalizadorBonificacao(s);
gerenciador.TotalizadorBonificacao(g);
gerenciador.TotalizadorBonificacao(d);

Console.WriteLine($"Total de bonificação: {gerenciador.GetTotaldeBonificacao()}");