/*
Esse arquivo, se for do domínio, deve conter somente a regra de negócio do desconto.

Por exemplo: se desconto é percentual, fixo, progressivo etc., essa decisão e cálculo ficam no domínio.

O Infra só chamaria essa lógica quando necessário (ex.: ao carregar um produto, verificar se precisa aplicar desconto, 
mas usando a regra do domínio).
*/



using System;
using treinoDDDstrategy.Domain.Enums;
using treinoDDDstrategy.Domain.Interfaces;

namespace treinoDDDstrategy.Domain
{
    public class SemDesconto : IDescontoStrategy
    {
        public double CalcularDesconto(Produto produto )
        {
         // INFLAMAVEL
            return produto.Price;
        }

    }
}