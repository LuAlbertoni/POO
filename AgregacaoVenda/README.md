## Enunciado

- A comissão do vendedor é gerada correspondendo a 2% do preço do produto vendido.
- Na instância de um comprador, conceda um valor de verba.
- Ao realizar uma venda, subtraia o valor da verba.
- É necessário realizar mais de uma venda para utilizar o vetor/lista de produtos.
- No cadastro de produtos, o código inicial é 500.
- Utilize encapsulamento completo (com tratamento de valores digitados) para os atributos da classe Produto.
- Realize instâncias necessárias para testar as classes.

## Classes

```
+---------------------------------+
|             Produto             |
+---------------------------------+
| - int codigo                    |
| - string nome                   |
| - double preco                  |
+---------------------------------+
| + MostrarAtributos()            |
+---------------------------------+

+---------------------------------+
|            Vendedor             |
+---------------------------------+
| - double comissao               |
+---------------------------------+
| + MostrarAtributo()             |
+---------------------------------+

+---------------------------------+
|            Comprador            |
+---------------------------------+
| - double verba                  |
+---------------------------------+
| + MostrarAtributo()             |
+---------------------------------+

+---------------------------------+
|             Venda               |
+---------------------------------+
| - Comprador comp                |
| - Produto vetProd               |
| - Vendedor vend                 |
+---------------------------------+
| + MostarAtributos()             |
+---------------------------------+
```