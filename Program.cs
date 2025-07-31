using System;
using System.Collections.Generic;


namespace treino_curso_nelio
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Produto> produto1 = new HashSet<Produto>();

            produto1.Add(new Produto("TV", 1500.00));
            produto1.Add(new Produto("SOM", 500.00));

            HashSet<Ponto> j = new HashSet<Ponto>();

            j.Add(new Ponto(55, 10));
            j.Add(new Ponto(90, 4));


            Produto produto2 = new Produto( "TV", 1500.00);

            Console.WriteLine(  produto1.Contains(produto2) );

        }

        static void MainPrintaiai<T>(IEnumerable<T> argumento)
        {
            foreach (T j in argumento)
            {
                Console.WriteLine(j);
            }
        }
    }


    struct Ponto
    {

        public int Pontoa{ get; set; }
        public int Pontob { get; set; }

        public Ponto(int pontoa, int pontob)
        { Pontoa = pontoa; Pontob = pontob; }
    
    }

}
