/*
Esse arquivo, se for do domínio, deve conter somente a regra de negócio do desconto.

Por exemplo: se desconto é percentual, fixo, progressivo etc., essa decisão e cálculo ficam no domínio.

O Infra só chamaria essa lógica quando necessário (ex.: ao carregar um produto, verificar se precisa aplicar desconto, 
mas usando a regra do domínio).
*/



using System;

namespace treino_curso_nelio.Domain
{
    public class ProdutoComDesconto : IDescontoStrategy
    {
        public Produto Produto{get; set; }
        public double PrecoOriginal{get; set;}
        
        public ProdutoComDesconto(){}
        // A IDEIA É TAXAR O PRODUTO PELO TIPO
        public ProdutoComDesconto(Produto produto, double precooriginal)
        {Produto = produto ; PrecoOriginal = precooriginal;}

        
        public double CalcularDesconto(double PrecoOriginal )
        {
            // desconto variavel caso o tipo seja INFLAMAVEL
            if(Produto.Type == "Inflamavel")    //
            {
                return PrecoOriginal - (PrecoOriginal * 0.1) ;
            }   
            // desconto fixo caso o tipo seja ELETRONICO
            else if(Produto.Type == "Eletronico")
            {
                return PrecoOriginal - 50.00;
            }
            // SEM desconto caso o tipo seja PERECIVEL
            else if(Produto.Type == "Eletronico")
            {
                return PrecoOriginal ;
            }

            return PrecoOriginal;
        }

        
        


    }
}