using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14Objetos
{
    internal class Pessoa
    {
        //atribuitos
        private string nome;
        private int idade;
        public bool inadimplente = false;
        public Endereco endereco;

        //Método contrustor
        public Pessoa(string nome , int idade, string rua, string bairro , string cidade )
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = new Endereco(rua, bairro, cidade);
        }
        //métodos
        public void mostra()
        {
           
            Console.WriteLine($"Eu sou o {nome} e eu tenho {idade} anos");
            
        }

    }
}
