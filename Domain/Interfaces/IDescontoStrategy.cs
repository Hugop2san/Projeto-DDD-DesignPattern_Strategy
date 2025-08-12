using System;

namespace treinoDDDstrategy.Domain.Interfaces
{
    public interface IDescontoStrategy
    {
        double CalcularDesconto(Produto produto);

    }
}