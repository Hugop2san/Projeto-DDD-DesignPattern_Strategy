using System;
using System.Globalization;
using treinoDDDstrategy.Domain.Enums;
using treinoDDDstrategy.Domain.Interfaces;

namespace treinoDDDstrategy.Domain
{
    public class Produto
    {
        public string Name{get; set;}
        public double Price{get; set;}
        public TipoProduto TipoProduto{get; set;}
        
   

        public Produto(){}

        public Produto(string name, double price, TipoProduto tipoproduto)
        {
            Name=name;
            Price=price;
            TipoProduto = tipoproduto;
        }
/*
        //PARA ME PERMITIR COMPARAR
        public override bool Equals(object obj )
        {
            if(obj is null)
            { return false;}

            Produto prod = obj as Produto;

            return Name.Equals(prod.Name) && Price.Equals(prod.Price) && TipoProduto.Equals(prod.TipoProduto);
        }
        public override int GetHashCode()
        {
            return  HashCode.Combine(Name, Price, TipoProduto);     // Name.GetHashCode() + Price.GetHashCode() + Type.GetHashCode(); SINTAXE ALTERNATIVA
        }
*/
        public override string ToString()
        {
            return $"Product Information : \n Name: {Name} - Price: {Price.ToString("F2", CultureInfo.InvariantCulture)} - Type: {TipoProduto}";
        }
    }
}