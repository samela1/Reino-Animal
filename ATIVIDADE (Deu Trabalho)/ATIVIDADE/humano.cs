using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE
{
    class Humano : mamifero
    {
        private string cpf;

        public void sorri()
        {
        }
        public string CPF
        {
            get
            {
                if (CPF == null) 
                Console.WriteLine("O CPF não foi digitado");
                    return cpf;
            }
            private set { }

        }
public Humano(int idade, string som, float velocidade, float peso, string cpf)
        {
            Idade = idade;
            Peso = peso;
            Som = som;
            CPF = cpf;
            Velocidade = velocidade;
        }
    }
}




