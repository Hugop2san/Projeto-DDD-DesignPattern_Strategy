# Projeto 
Este projeto foi desenvolvido seguindo princípios do Domain-Driven Design (DDD), separando as responsabilidades em camadas (/Domain, /Application, /Services) e aplicando o padrão Strategy para encapsular diferentes regras de desconto.

# 🎯 Objetivo do exercício
Aplicar o padrão Strategy para realizar diferentes tipos de cálculo de desconto em produtos, com base em diferentes estratégias.

# 🧠 Contexto do domínio
Você tem uma loja virtual (console, por enquanto) com uma lista de produtos. Dependendo do tipo do produto ou campanha do momento, o desconto aplicado muda.

# 🧱 Estrutura de diretórios sugerida
/Domain
├── Produto.cs
├── Enums
│ └── TipoProduto.cs
└── Interfaces
└── IDescontoStrategy.cs

/Services
├── DescontoFixo.cs
├── DescontoPorcentagem.cs
└── SemDesconto.cs

/Application
└── DescontoService.cs

Program.cs


## 📂 Descrição das Pastas

- **/Domain**
  - Contém as entidades, enums e interfaces que representam o núcleo do domínio.
  - **Produto.cs** → Entidade principal do sistema.
  - **Enums/TipoProduto.cs** → Enumeração para tipos de produtos.
  - **Interfaces/IDescontoStrategy.cs** → Contrato para implementação das estratégias de desconto.

- **/Services**
  - Contém as implementações concretas das estratégias de desconto.
  - **DescontoFixo.cs** → Estratégia de desconto fixo em valor monetário.
  - **DescontoPorcentagem.cs** → Estratégia de desconto percentual.
  - **SemDesconto.cs** → Implementação que aplica zero desconto.

- **/Application**
  - Camada de aplicação que orquestra as regras de negócio do domínio.
  - **DescontoService.cs** → Serviço que utiliza as estratégias para calcular descontos.

- **Program.cs**
  - Ponto de entrada da aplicação.
