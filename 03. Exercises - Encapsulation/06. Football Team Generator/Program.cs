using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<Team>();

            Team team = new Team();

            while (input != "END")
            {
                var line = input.Split(';', StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (line[0] == "Team")
                    {
                        // team.Name = line[1];
                        list.Add(new Team(line[1], 0.0));
                    }

                    if (line[0] == "Add")
                    {
                        var count = 0;
                        foreach (var item in list)
                        {
                            if (item.Name == line[1])
                            {

                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            Console.WriteLine($"Team {line[1]} does not exist.");
                        }
                        else
                        {
                            var player =
                            new Player(line[2], int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), int.Parse(line[6]), int.Parse(line[7]));

                            foreach (var item in list)
                            {
                                if (item.Name == line[1])
                                {
                                    item.Players.Add(player);
                                }
                            }
                        }
                    }
                    if (line[0] == "Remove")
                    {
                        foreach (var item in list)
                        {
                            if (item.Name == line[1])
                            {
                                if (item.isInside(line[2]) == false)
                                {
                                    Console.WriteLine($"Player {line[2]} is not in {item.Name} team.");
                                }
                                item.Players.RemoveAll(s => s.Name == line[2]);
                            }
                        }
                    }
                    if (line[0] == "Rating")
                    {
                        var count = 0;
                        foreach (var item in list)
                        {
                            if (item.Name == line[1])
                            {

                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            Console.WriteLine($"Team {line[1]} does not exist.");
                        }
                        else
                        {
                            foreach (var item in list)
                            {
                                if (item.Name == line[1])
                                {

                                    Console.WriteLine(item.Name + " - " + item.GetTeamRaiting());
                                }
                             }
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                input = Console.ReadLine();
            }
        }
    }
}
