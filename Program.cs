using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pokemon pikachu = new Pokemon("Bob", "yellow", 3, PokemonType.Electric, 15);
            var pikachu = new Pokemon.Builder()
                                         .WithName("Bob")
                                         .WithColor("yellow")
                                         .WithAge(3)
                                         .HasType(PokemonType.Electric)
                                         .OnLevel(15);
        }
    }
}
