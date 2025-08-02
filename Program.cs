using System;
using System.Collections.Generic;


namespace treino_curso_nelio
{
    class Program
    {
        static void Main(string[] args)
        {



            HashSet<Aluno> alunoscursoA = new HashSet<Aluno>( );

           Console.WriteLine("how many students for the course A ?");
            int pergunta1= int.Parse(Console.ReadLine( ));

            for(int i=0; i <pergunta1 ; i++)
            {
                Console.Write($"Matricula estudante n°{i+1} :");
                alunoscursoA.Add( new Aluno (int.Parse(Console.ReadLine( ))) );
            }

            


            Console.WriteLine("how many students for the course B ?");
            int pergunta2= int.Parse(Console.ReadLine( ));

            for(int i=0; i <pergunta2 ; i++)
            {
                Console.Write($"Matricula estudante n°{i+1} :");
                alunoscursoA.Add( new Aluno (int.Parse(Console.ReadLine( ))) );
            }

            


            Console.WriteLine("how many students for the course C ?");
            int pergunta3= int.Parse(Console.ReadLine( ));

            for(int i=0; i <pergunta3 ; i++)
            {
                Console.Write($"Matricula estudante n°{i+1} :");
                alunoscursoA.Add( new Aluno (int.Parse(Console.ReadLine( ))) );
            }

            
            Console.WriteLine($"Total matriculas sem repetir: {alunoscursoA.Count()}"  );
            //MainPrintaiai(alunoscursoA);
            




        }

        static void MainPrintaiai<T>(IEnumerable<T> argumento)
        {
            //Console.WriteLine("Matriculas :");
            
            foreach (T j in argumento)
            {
                Console.WriteLine(j);
            }
        }
    }
}
