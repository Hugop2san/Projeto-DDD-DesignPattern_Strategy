# 🎯 Objetivo do exercício
Aplicar o padrão Strategy para realizar diferentes tipos de cálculo de desconto em produtos, com base em diferentes estratégias.

# 🧠 Contexto do domínio
Você tem uma loja virtual (console, por enquanto) com uma lista de produtos. Dependendo do tipo do produto ou campanha do momento, o desconto aplicado muda.

# Você pode usar Strategy dentro de um projeto com DDD quando:
O domínio possui variações de regras que mudam dependendo de um contexto (tipo de cliente, tipo de produto, tipo de cálculo, etc.).
Essas variações precisam ser trocadas em tempo de execução ou escolhidas dinamicamente.
Você quer evitar if/else ou switch gigantes na lógica de negócio.

# 🧱 Estrutura de diretórios sugerida
/Domain
  └── Produto.cs
  └── IDescontoStrategy.cs
  └── Enums
        └── TipoProduto.cs

/Application
  └── DescontoService.cs

/Infra
  └── Descontos/
        ├── DescontoFixo.cs
        ├── DescontoPorcentagem.cs
        ├── SemDesconto.cs        

/Program.cs
