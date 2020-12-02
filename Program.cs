using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Tsukamoto";
            objetoPersonagem1.idade = 32;
            objetoPersonagem1.armadura = "Voadora";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "João";
            objetoPersonagem2.idade = 18;
            objetoPersonagem2.armadura = "De Guerra";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem.Defender()}");
        }

    }
}
