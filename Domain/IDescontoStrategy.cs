using System;

namespace treino_curso_nelio.Domain
{
    public interface IDescontoStrategy
    {
        double CalcularDesconto(double PrecoOriginal);

    }
}