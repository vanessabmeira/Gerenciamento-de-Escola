using System;
using static System.Net.Mime.MediaTypeNames;

namespace Gerenciamento_de_Escola
{
    public class Pessoa
    {
        internal string nome;
        internal int idade;



        internal Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;

        }

        /// <summary>
        /// Método criado para exibir dados da classe.
        /// </summary>
        public virtual void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }
}
