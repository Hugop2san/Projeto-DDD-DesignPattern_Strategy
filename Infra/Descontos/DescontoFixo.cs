// Implementar persistência (ex.: repositórios que salvam e buscam Produto no banco, ou até em memória para simulação).
// Aqui você não coloca regra de negócio, apenas como os dados são armazenados, carregados ou enviados.
// Implementar concretamente as interfaces definidas no domínio (ex.: IProdutoRepository).

using System;
using treinoDDDstrategy.Domain;
using treinoDDDstrategy.Domain.Enums;
namespace treinoDDDstrategy.Infra.Descontos
{
    public class DescontoFixo : IDescontoStrategy
    {
        
        public double CalcularDesconto(Produto produto )
        {
           
            // desconto fixo caso o tipo seja ELETRONICO
            if(produto.TipoProduto == TipoProduto.Eletronico )//Eletronico
            {
                return produto.Price - 50.00;
            }


          return produto.Price;
        }

    }
}