using System;

namespace Estoque
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, string codigo, decimal preco, int quantidade)
        {
            Nome = nome;
            Codigo = codigo;
            Preco = preco;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Código: {Codigo}, Preço: {Preco:C}, Quantidade: {Quantidade}";
        }
    }
}
