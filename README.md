# 🎯 Objetivo do exercício
Aplicar o padrão Strategy para realizar diferentes tipos de cálculo de desconto em produtos, com base em diferentes estratégias.

# 🧠 Contexto do domínio
Você tem uma loja virtual (console, por enquanto) com uma lista de produtos. Dependendo do tipo do produto ou campanha do momento, o desconto aplicado muda.

# 🧱 Estrutura de diretórios sugerida
/Domain
  └── Produto.cs
  └── IDescontoStrategy.cs
  └── ProdutoComDesconto.cs

/Application
  └── DescontoService.cs

/Infra
  └── Descontos/
        ├── DescontoFixo.cs
        ├── DescontoPorcentagem.cs
        ├── SemDesconto.cs

/Program.cs
