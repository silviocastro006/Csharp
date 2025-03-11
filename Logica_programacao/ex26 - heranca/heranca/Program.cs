using System;

    class Pessoa
    {
        string nome;
        int idade;
        char sexo;

        public Pessoa(string nome, int idade, char sexo){
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

        public void fazerAniversario(){
            this.idade +=1;
            Console.WriteLine("Parabéns!");
        }

    }

    class Aluno : Pessoa{
        
        

        public Aluno(string nome, int idade, char sexo) : base(nome, idade, sexo) {

        }
    }