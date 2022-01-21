using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace POO_MENTORIA_DIO.src.Entities
{
    public class Heroi
    {
        public Heroi(string Nome, string ClasseFantastica)
        {
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosDeVida = 50;
            this.PontosDeMagia = 50;
        }


        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int PontosDeVida { get; set; }
        public int PontosDeMagia { get; set; }
        public string ClasseFantastica { get; set; }
        public string NomeDoPet { get; set; }
        public int ValorUltimoAtaque { get; set; }



        public override string ToString()
        {
            return "Meu nome é: " + this.Nome + "\n"
            + "Nivel:" + this.Nivel + "\n" 
            + "Classe:" + this.ClasseFantastica + "\n"
            + "Ponto de vida:" + this.PontosDeVida + "\n"
            + "Ponto de magia:" + this.PontosDeMagia + "\n";
        }

        public virtual string Atacar()
        {
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1,20);
            this.ValorUltimoAtaque = forcaDoAtaque;

            return this.Nome + " Atacar com a sua espada e da " + forcaDoAtaque + " de dano";
        }

        public void ReceberDano(int danoRecebido)
        {
            this.PontosDeVida = this.PontosDeVida - danoRecebido;
        }
    }
}