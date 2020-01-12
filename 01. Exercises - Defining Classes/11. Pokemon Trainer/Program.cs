using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inp = Console.ReadLine();
            var container = new List<Trainer>();

            while (inp.ToLower() != "tournament")
            {
                var line = inp.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var pokemon = new Pokemon(line[1], line[2],int.Parse(line[3]));

                var trainer = new Trainer(line[0]);

                var count = 0;

                foreach (var li in container)
                {
                    if (li.TrainerName== line[0])
                    {
                        li.listPokemon.Add(pokemon);
                        count++;
                        break;
                    }
                }
                if (count==0)
                {
                    trainer.listPokemon.Add(pokemon);
                    container.Add(trainer);
                }

                inp = Console.ReadLine();
            }

            var cmd = Console.ReadLine();

            while (cmd.ToLower() != "end")
            {
                 foreach (var trainer in container)
                 {
                     var count = 0;

                     foreach (var li in trainer.listPokemon)
                     {
                         if (li.Element == cmd)
                         {
                             count++;
                         }
                     }
                     if (count > 0)
                     {
                         trainer.Badges++;
                     }
                     else
                     {
                         foreach (var li in trainer.listPokemon)
                         {
                             li.Health -= 10;
                         }
                     }

                    var removePokemon = new List<Pokemon>();
                    foreach (var pokemon in trainer.listPokemon)
                    {
                        if (pokemon.Health <= 0)
                        {
                            removePokemon.Add(pokemon);
                        }
                    }
                    foreach (var item in removePokemon)
                    {
                        trainer.listPokemon.Remove(item);
                    }
                       
                }
                cmd = Console.ReadLine();
            }

            

            foreach (var li in container.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine(li.TrainerName + " " + li.Badges + " " + li.listPokemon.Count);
            }
        }
    }
}
