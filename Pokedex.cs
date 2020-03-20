//Pokémon and All Respective Names are Trademark & © of Nintendo 1996-2020
using System;
using System.Collections.Generic;

namespace Pokemon
{
    class Pokedex
    {
      public List <Pokemon> registroDePokemons = new List<Pokemon>();

      public Dictionary<int, Pokemon> diccionarioId = new Dictionary<int, Pokemon>();

      public Dictionary<string, Pokemon> diccionarioName = new Dictionary<string, Pokemon>();

      public Pokedex() 
      {
            Pokemon ralts = new Pokemon("Ralts", 280);
            Pokemon kirlia = new Pokemon("Kirlia", 281);
            Pokemon gardevoir = new Pokemon("Gardevoir",282);
            Pokemon gallade = new Pokemon("Gallade", 475);
            Pokemon dratini = new Pokemon("Dratini", 147);
            Pokemon dragonair = new Pokemon("Dragonair", 148);
            Pokemon dragonite = new Pokemon("Dragonite", 149);
            Pokemon eevee = new Pokemon("Eevee", 133);
            Pokemon umbreon = new Pokemon("Umbreon", 197);

            foreach (var pokemon in registroDePokemons)
            {
              diccionarioId.Add(pokemon.id , pokemon); 
              diccionarioName.Add(pokemon.name, pokemon);        
            }
      }
      public Pokemon encontrarId(int id) 
      {
        if (diccionarioId.TryGetValue(id, out Pokemon pokemon))
        {
            return pokemon;
        }
        else
        {
          return null;
        }
      }

      public Pokemon encontrarNombre(string name)
      {
        if (diccionarioName.TryGetValue(name, out Pokemon pokemon))
        {
            return pokemon;
        }
        else
        {
          return null;
        }
      }
    }
}
