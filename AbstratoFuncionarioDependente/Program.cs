// Método Main()
using AbstratoFuncionario;

// Adicionando funcionários
Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);

// Adicionando comissionados
Comissionado c1 = new Comissionado(3, "Teo", 1000, 20);
Comissionado c2 = new Comissionado(4, "Tais", 1000, 30);

// Adicionando funcionários ao departamento de TI
Departamento d1 = new Departamento(10, "TI");
d1.Admitir(a1);
d1.Admitir(c1);

// Adicionando funcionários ao departamento de RH
Departamento d2 = new Departamento(11, "RH");
d2.Admitir(a2);
d2.Admitir(c2);

// Adicionando dependentes aos funcionários
a1.AdicionarDependente(new Dependente("Filho1", 5));
a1.AdicionarDependente(new Dependente("Filho2", 8));
c1.AdicionarDependente(new Dependente("Esposa", 30));

// Removendo dependente
a1.RemoverDependente("Filho1");

// Listando dependentes
d1.ListarFuncionarios();
Console.WriteLine($"Total {d1.CalcularFolha(30):c}");
d1.CalcularQuantidadeDependentes();

d2.ListarFuncionarios();
Console.WriteLine($"Total {d2.CalcularFolha(30):c}");
d2.CalcularQuantidadeDependentes();