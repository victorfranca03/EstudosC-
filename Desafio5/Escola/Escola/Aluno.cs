using System;
using System.Collections.Generic;

namespace Escola
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<decimal> Notas { get; set; }

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Notas = new List<decimal>();
        }

        public void AdicionarNota(decimal nota)
        {
            Notas.Add(nota);
        }

        public decimal CalcularMedia()
        {
            if (Notas.Count == 0)
                return 0;

            decimal soma = 0;
            foreach (var nota in Notas)
            {
                soma += nota;
            }

            return soma / Notas.Count;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Média: {CalcularMedia():0.00}";
        }
    }
}
