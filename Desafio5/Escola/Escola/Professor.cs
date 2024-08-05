using System;
using System.Collections.Generic;

namespace Escola
{
    public class Professor
    {
        public string Nome { get; set; }
        public List<Disciplina> DisciplinasLecionadas { get; set; }

        public Professor(string nome)
        {
            Nome = nome;
            DisciplinasLecionadas = new List<Disciplina>();
        }

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            DisciplinasLecionadas.Add(disciplina);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Disciplinas: {string.Join(", ", DisciplinasLecionadas)}";
        }
    }
}
