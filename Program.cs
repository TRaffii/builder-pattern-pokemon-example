using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pikachu = new Pokemon.Builder()
                                         .WithName("Bob")
                                         .WithColor("yellow")
                                         .WithAge(3)
                                         .HasType(PokemonType.Electric)
                                         .OnLevel(15);
        }
    }
}
