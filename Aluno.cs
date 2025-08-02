using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treino_curso_nelio
{
    class Aluno
    {

        //public string Nome { get; set; }
        public int Matricula { get; set; }

        public Aluno(int matricula)
        { Matricula=matricula; }


        public override int GetHashCode()
        {
            return Matricula.GetHashCode() ;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Aluno))
            { return false; }

            Aluno? aluno = obj as Aluno;

            return Matricula.Equals(aluno.Matricula);
        }
        public override string ToString()
        {
            
            return $"> {Matricula}";
        }

    }
}
