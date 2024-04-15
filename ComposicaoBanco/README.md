## Enunciado

Exercício de Composição
- Seguir o diagrama de classes
- Criar as classes de acordo com o diagrama
- Usar encapsulamento completo (com tratamento de valores digitados) para o atributo saldo da classe Poupança
- Usar construtor
- Realizar instâncias necessárias para testar as classes

## Classes

```
+---------------------------------+
|         Conta Corrente          |
+---------------------------------+
| - double saldo                  |
| - chequeEspecial                |
+---------------------------------+
| + Depositar()                   |
| + Sacar()                       |
| + GerarExtrato()                |
+---------------------------------+

+---------------------------------+
|             Banco               |
+---------------------------------+
| - Poupanca poups[]              |
| - ContaCorrente contas[]        |
+---------------------------------+
| + IniciarBanco()                |
| + AbrirConta()                  |
| + AbrirPoupanca()               |
| + DecretarFalencia()            |
+---------------------------------+

+---------------------------------+
|            Poupanca             |
+---------------------------------+
| - saldo                         |
+---------------------------------+
| + Depositar()                   |
| + Sacar()                       |
| + GerarRendimento()             |
+---------------------------------+
```
