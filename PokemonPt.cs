//Pokémon and All Respective Names are Trademark & © of Nintendo 1996-2020
using System;

namespace Pokemon
{
    public enum Genero
       {
           Macho,
           Hembra
       } 
    class PokemonPt : Pokemon
    { 
       Genero genero;

       public PokemonPt(string name, int id, Genero genero) : base(name, id) 
       {
          this.genero = genero;
       }
       public override string ToString()
    {
        return name + id + genero;
    }
    }
}
