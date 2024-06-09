# Enunciado

- Crie um menu interativo para cadastro e gerenciamento de Produtos, Itens de Venda, Vendas e Pagamentos
- Implemente as formas de pagamento: Espécie, Cheque e Cartão
- Aplique desconto para vendas no atacado (50 produtos ou mais com 20% de desconto)
- Seguir o diagrama de classes fornecido

## Estrutura do diagrama de classes

### Classes e Atributos

1. **Produto**
   - **Atributos:**
     - `codigo`: long
     - `nome`: string
     - `preco`: double
     - `estoque`: int
   - **Descrição:**
     - Representa um produto disponível para venda.

2. **ItemVenda**
   - **Atributos:**
     - `quantidade`: int
     - `preco`: double
     - `subtotal`: double
   - **Associações:**
     - `Produto`: Cada `ItemVenda` está associado a um `Produto`.
   - **Descrição:**
     - Representa um item específico dentro de uma venda, incluindo a quantidade vendida, preço unitário e subtotal do item.

3. **Venda**
   - **Atributos:**
     - `data`: Date
     - `total`: double
   - **Associações:**
     - Contém uma coleção de `ItemVenda`.
     - É paga por um `Pagamento`.
   - **Descrição:**
     - Representa uma venda realizada, contendo a data e o total da venda. Inclui múltiplos itens vendidos.

4. **Pagamento**
   - **Atributos:**
     - `data`: Date
     - `total`: double
   - **Descrição:**
     - Classe base abstrata para representar um pagamento. Pode ser especializada em diferentes formas de pagamento.

5. **Especie** (herda de `Pagamento`)
   - **Atributos:**
     - `quantia`: double
     - `troco`: double
   - **Descrição:**
     - Representa um pagamento em dinheiro, incluindo a quantia recebida e o troco dado.

6. **Cheque** (herda de `Pagamento`)
   - **Atributos:**
     - `numero`: long
     - `dataDeposito`: Date
     - `situacao`: int
   - **Descrição:**
     - Representa um pagamento por cheque, incluindo o número do cheque, data de depósito e situação do cheque.

7. **Cartao** (herda de `Pagamento`)
   - **Atributos:**
     - `dadosTransacao`: string
     - `resultadoTransacao`: int
   - **Descrição:**
     - Representa um pagamento com cartão, incluindo dados da transação e o resultado da transação.

### Associações e Composições

- **Venda** contém uma coleção de **ItemVenda** (`1..*`), representando os itens incluídos na venda.
- **ItemVenda** está associado a um **Produto** (`1`), indicando o produto específico que está sendo vendido.
- **Venda** é paga por **Pagamento** (`0..1`), que pode ser de diferentes tipos (`Especie`, `Cheque`, `Cartao`), representando a forma de pagamento utilizada.