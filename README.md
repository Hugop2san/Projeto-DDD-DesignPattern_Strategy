# Treino com IEnumerable, Equals, GetHashCode e HashSet

Este repositório tem como objetivo estudar e demonstrar conceitos fundamentais de C# relacionados a coleções, comparação de objetos e eficiência no armazenamento de dados.  
Esses conceitos são amplamente utilizados no desenvolvimento de aplicações reais, melhorando a legibilidade, performance e confiabilidade do código.

---

## 1. Por que usar `IEnumerable`
O `IEnumerable` é uma interface essencial no .NET, responsável por permitir a iteração sobre uma coleção de forma genérica.

### Benefícios:
- **Flexibilidade:** Pode ser usado com qualquer tipo de coleção (`List`, `Array`, `HashSet`, etc.).
- **Lazy evaluation:** Combinado com `yield` e LINQ, permite processar elementos sob demanda.
- **Abstração:** Facilita a escrita de métodos que funcionam com múltiplos tipos de coleções sem precisar conhecer sua implementação interna.

### Exemplo:
```csharp
public IEnumerable<int> NumerosPares(IEnumerable<int> numeros)
{
    foreach (var n in numeros)
    {
        if (n % 2 == 0)
            yield return n;
    }
}
