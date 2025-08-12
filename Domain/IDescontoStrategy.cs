using System;

namespace treinoDDDstrategy.Domain
{
    public interface IDescontoStrategy
    {
        double CalcularDesconto(Produto produto);

    }
}