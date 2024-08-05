using System;

namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias de alunos
            Aluno aluno1 = new Aluno("Maria", 15);
            Aluno aluno2 = new Aluno("João", 16);
            aluno1.AdicionarNota(8.5m);
            aluno1.AdicionarNota(9.0m);
            aluno2.AdicionarNota(7.0m);
            aluno2.AdicionarNota(6.5m);

            // Criando instância de disciplina
            Disciplina disciplinaMatematica = new Disciplina("Matemática");
            disciplinaMatematica.MatricularAluno(aluno1);
            disciplinaMatematica.MatricularAluno(aluno2);

            // Criando instância de professor
            Professor professor1 = new Professor("Carlos");
            professor1.AdicionarDisciplina(disciplinaMatematica);

            // Exibindo informações
            Console.WriteLine(professor1);
            disciplinaMatematica.ExibirAlunos();
        }
    }
}
