using System;
using System.Globalization;

namespace treino_curso_nelio.Domain
{
    public class Produto
    {
        public string Name{get; set;}
        public double Price{get; set;}
        public string Type{get; set;}
        
        /*= new List<string> ()
        {
            "Inflamavel",
            "Eletronico",
            "Perecivel"
        };*/

        public Produto(){}

        public Produto(string name, double price, string type)
        {
            Name=name;
            Price=price;
            Type = type;
        }

        //PARA ME PERMITIR COMPARAR
        public override bool Equals(object obj )
        {
            if(obj is null)
            { return false;}

            Produto prod = obj as Produto;

            return Name.Equals(prod.Name) && Price.Equals(prod.Price) && Type.Equals(prod.Type);
        }
        public override int GetHashCode()
        {
            return  HashCode.Combine(Name, Price, Type);     // Name.GetHashCode() + Price.GetHashCode() + Type.GetHashCode(); SINTAXE ALTERNATIVA
        }
        public override string ToString()
        {
            return $"Product Information : \n Name: {Name} - Price: {Price.ToString("F2", CultureInfo.InvariantCulture)} - Type: {Type}";
        }
    }
}