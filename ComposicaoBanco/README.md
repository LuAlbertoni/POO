## Enunciado

Exercício de composição: Dos métodos, crie a lógica que for conveniente a cada classe

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
