using System;
using System.Collections.Generic;
using System;
using System.IO;

using System;
using treinoDDDstrategy.Domain;
using treinoDDDstrategy.Domain.Enums;
using treinoDDDstrategy.Infra.Descontos;
using treinoDDDstrategy.Application;

namespace treinoDDDstrategy
{
    class Program
    {
        static void Main(string[] args)
        {
          
      
        var produto1 = new Produto { Name = "Maçã", Price = 10.00, TipoProduto = TipoProduto.Perecivel };
        var produto2 = new Produto { Name = "TV", Price = 5000.90, TipoProduto = TipoProduto.Eletronico };

        var calculadora = new DescontoService();

        Console.WriteLine($"Desconto para {produto1.Name}: R$ {calculadora.CalcularPrecoFinal(produto1)}");
        Console.WriteLine($"Desconto para {produto2.Name}: R$ {calculadora.CalcularPrecoFinal(produto2)}");
    
        }
    }
}
