using System;

namespace POO_MENTORIA_DIO.src.Entities
{
    public class Inimigo : Heroi
    {
        public Inimigo(string Nome, string ClasseFantastica) : base(Nome, ClasseFantastica)
        {
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosDeVida = 80;
            this.PontosDeMagia = 0;
        }

        public override string Atacar()
        {
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1,15);
            this.ValorUltimoAtaque = forcaDoAtaque;
            return this.Nome + " Ataca e da " + forcaDoAtaque + " de dano";
        }
    }
}