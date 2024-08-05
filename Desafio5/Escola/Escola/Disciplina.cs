using System;
using System.Collections.Generic;

namespace Escola
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public List<Aluno> AlunosMatriculados { get; set; }

        public Disciplina(string nome)
        {
            Nome = nome;
            AlunosMatriculados = new List<Aluno>();
        }

        public void MatricularAluno(Aluno aluno)
        {
            AlunosMatriculados.Add(aluno);
        }

        public override string ToString()
        {
            return Nome;
        }

        public void ExibirAlunos()
        {
            Console.WriteLine($"Alunos matriculados na disciplina {Nome}:");
            foreach (var aluno in AlunosMatriculados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
