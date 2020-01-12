using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public string TrainerName { get; set; }
        public int Badges { get; set; }
        public  List<Pokemon> listPokemon { get; set; }

        public Trainer(string trainerName)
        {
            this.TrainerName = trainerName;
            this.Badges = 0;
            this.listPokemon = new List<Pokemon>();
        }

        //public void Remove(Pokemon pokemon)
        //{
        //    this.listPokemon.Remove(pokemon);
        //}
    }
}
