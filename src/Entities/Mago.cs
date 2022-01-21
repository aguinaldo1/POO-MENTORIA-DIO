using System;

namespace POO_MENTORIA_DIO.src.Entities
{
    public class Mago : Heroi
    {
        public Mago(string Nome, string ClasseFantastica) : base(Nome, ClasseFantastica)
        {
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosDeVida = 50;
            this.PontosDeMagia = 50;
        }

        public override string Atacar()
        {
           Random dado = new Random();
           int forcaDoAtaque = this.Nivel + dado.Next(1,10);
           this.ValorUltimoAtaque = forcaDoAtaque;
           return this.Nome + " Ataca com o seu cajado e da " + forcaDoAtaque + " de dano";
        }

        public string Atacar(int bonus)
        {
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1,10) + bonus;
            this.ValorUltimoAtaque = forcaDoAtaque;
            return this.Nome + " Ataca com bônus com seu cajado e da " + forcaDoAtaque + " de dano";
        }
    }
}