//Pokémon and All Respective Names are Trademark & © of Nintendo 1996-2020
using System;
using System.Collections.Generic;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pokemon Fear");

            Pokedex pokedex = new Pokedex();

            Pokemon x = pokedex.encontrarNombre("Ralts");
            
            Pokemon ralts = new Pokemon("Ralts", 280);
            Pokemon kirlia = new Pokemon("Kirlia", 281);
            Pokemon gardevoir = new Pokemon("Gardevoir",282);
            Pokemon gallade = new Pokemon("Gallade", 475);
            Pokemon dratini = new Pokemon("Dratini", 147);
            Pokemon dragonair = new Pokemon("Dragonair", 148);
            Pokemon dragonite = new Pokemon("Dragonite", 149);
            Pokemon eevee = new Pokemon("Eevee", 133);
            Pokemon umbreon = new Pokemon("Umbreon", 197);


            HashSet<string> pokemonName = new HashSet<string>();

            pokemonName.Add("Gardevoir");
            pokemonName.Add("Dragonite");
            pokemonName.Add("Umbreon");

            Console.WriteLine("Tienes " + pokemonName.Count );

            List<PokemonPt> pokemonParty = new List<PokemonPt>();

            pokemonParty.Add(new PokemonPt("Ralts ",280, Genero.Hembra));
            pokemonParty.Add(new PokemonPt("Kirlia ", 281, Genero.Hembra));
            pokemonParty.Add(new PokemonPt("Gardevoir ", 282, Genero.Hembra));
            pokemonParty.Add(new PokemonPt("Gallade ", 475, Genero.Macho));
            pokemonParty.Add(new PokemonPt("Espeon ", 196, Genero.Hembra));
            pokemonParty.Add(new PokemonPt("Umbreon" , 197, Genero.Macho));

            foreach (var pokemon in pokemonParty) 
           {
             System.Console.WriteLine(pokemon);
           }
            
        }
    }
}
