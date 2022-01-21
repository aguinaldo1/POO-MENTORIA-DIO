using System;
using POO_MENTORIA_DIO.src.Entities;

namespace POO_MENTORIA_DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi arus = new Heroi("Arus", "Guerreiro");
            Mago wedge = new Mago("Wedge", "Mago negro");
            Inimigo KingMummy = new Inimigo ("King Mummy", "Zumbi");
            
            System.Console.WriteLine(arus.Atacar());
            System.Console.WriteLine(KingMummy.Atacar());

            if(arus.ValorUltimoAtaque == KingMummy.ValorUltimoAtaque)
            {
                System.Console.WriteLine($"Empate, ambos deram dano de {arus.ValorUltimoAtaque}");
            }
            else if(arus.ValorUltimoAtaque > KingMummy.ValorUltimoAtaque)
            {
                KingMummy.ReceberDano(arus.ValorUltimoAtaque - KingMummy.ValorUltimoAtaque);
                System.Console.WriteLine(arus.Nome + " Venceu esse round");
            }
            else
            {
                arus.ReceberDano(KingMummy.ValorUltimoAtaque - arus.ValorUltimoAtaque);
                System.Console.WriteLine(KingMummy.Nome + " Venceu esse round");
            }

            Console.WriteLine(arus.ValorUltimoAtaque);
            System.Console.WriteLine(wedge.ValorUltimoAtaque);
        }
    }
}
