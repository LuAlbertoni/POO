# Enunciado

### Parte 01
- Crie uma interface chamada `ITributavel`.
- Esta interface terá o método `double CalculaTributos()`, que não recebe parâmetros e retorna um valor representando o imposto a ser pago.
- Implemente a classe `ContaCorrente`, que paga 5% do seu saldo como imposto.
- Implemente a classe `SeguroDeVida`, que retorna um valor constante de R$ 75 como imposto.
- Faça instâncias de cada classe e teste no método `main()`.
- Crie outra classe chamada `TotalizadorDeTributos`, responsável por acumular os impostos das diferentes classes tributáveis.
- Crie uma instância e teste no método `main()`.

```csharp
public class TotalizadorDeTributos {
    public double Total { get; private set; }
    
    public void Adiciona(ITributavel t) {
        this.Total += t.CalculaTributos();
    }
}
```

### Parte 02
- Crie uma interface chamada `ITributavel`.
- Esta interface terá o método `double CalculaTributos()`, que não recebe parâmetros e retorna um valor representando o imposto a ser pago.
- Implemente a classe `ContaCorrente`, que paga 5% do seu saldo como imposto.
- Implemente a classe `SeguroDeVida`, que retorna um valor constante de R$ 75 como imposto.
- Faça instâncias de cada classe e teste no método `main()`.
- Crie outra classe chamada `TotalizadorDeTributos`, responsável por acumular os impostos das diferentes classes tributáveis.
- Crie uma instância e teste no método `main()`.