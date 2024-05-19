## Enunciado

Exercício de Polimorfismo:
- Complete o projeto fornecido (as classes `Funcionario`, `Secretario`, `Gerente` e `Diretor` já foram desenvolvidas).
- Implemente a classe `GerenciadorBonificacao`, que por meio da associação de dependência (relacionamento fraco, ocorre por meio da passagem de parâmetro) com `Funcionario`, somará o atributo `totalBonificacao`, utilizando o método `TotalizadorBonificacao`.

`TotalizadorBonificacao` deve receber um parâmetro de um objeto de uma das classes `Funcionario`, `Secretario`, `Gerente` ou `Diretor`, ou seja, implemente 4 métodos, cada um com um parâmetro referente a uma das classes. Isso demonstrará o polimorfismo estático, utilizando um objeto diferente para cada classe (4 classes no total).

Exemplo do método:
```csharp
public void TotalizadorBonificacao(Diretor diretor) {
    this.totalBonificacao += diretor.CalcularBonificacao();
}
```

Este método deve conter a lógica de somar, através do atributo `totalBonificacao`, a bonificação de cada tipo de funcionário.