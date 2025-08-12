/*
Orquestrar casos de uso (ex.: “Aplicar desconto em todos os produtos de uma categoria”).
Chamar os serviços de domínio e infra, mantendo o fluxo da aplicação.
Transformar dados de entrada (DTOs) em entidades do domínio antes de passar para a lógica.
Chamar métodos do domínio (Produto.AplicarDesconto()), mas não implementar a regra aqui.
*/

using System;
using treinoDDDstrategy.Domain;
using treinoDDDstrategy.Domain.Enums;
using treinoDDDstrategy.Infra.Descontos;

namespace treinoDDDstrategy.Application
{
    public class DescontoService 
    {
        public double CalcularPrecoFinal(Produto produto)
        {
            IDescontoStrategy strategy = produto.TipoProduto switch

            {
                TipoProduto.Perecivel => new DescontoPorcentagem(), //"se TipoProduto for Perecivel, retorne new DescontoPorcentagem()".
                TipoProduto.Eletronico=> new DescontoFixo(),
                TipoProduto.Inflamavel => new SemDesconto(),
                _ => throw new ArgumentOutOfRangeException()
                
            };

            return strategy.CalcularDesconto(produto) ;

        }


    }

}

