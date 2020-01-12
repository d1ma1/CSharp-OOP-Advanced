using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var list = new List<ISoldier>();
            var privates = new List<Private>();
           // var general = new List<LieutenantGeneral>();

            while (input != "End")
            {
                var line = input.Split();

                if (line[0]=="Private")
                {
                    list.Add(new Private(line[1],line[2],line[3],decimal.Parse(line[4])));
                    privates.Add(new Private(line[1], line[2], line[3], decimal.Parse(line[4])));
                }
                if (line[0] == "Spy")
                {
                    list.Add(new Spy(line[1], line[2], line[3], int.Parse(line[4])));
                }
                if (line[0] == "LieutenantGeneral")
                {
                    var listPrivateIds = new List<string>();
                    var leit = new LieutenantGeneral(line[1], line[2], line[3], decimal.Parse(line[4]));

                    if (line.Length > 4)
                    {

                        for (int i = 5; i < line.Length; i++)
                        {
                            foreach (var item in privates)
                            {
                                if (item.Id == line[i])
                                {
                                    leit.Privates.Add(item);
                                }
                            }
                        }
                    
                        leit.ListPrivateIds.AddRange(listPrivateIds);

                    }
                    list.Add(leit);
                }

                if (line[0] == "Engineer")
                {
                    var eng = new Engineer(line[1], line[2], line[3], decimal.Parse(line[4]), line[5]);
                    var repaits = new List<Repair>();

                    for (int i = 6; i < line.Length; i=i+2)
                    {
                        repaits.Add(new Repair(line[i], int.Parse(line[i + 1])));
                    }

                    eng.Repairs.AddRange(repaits);
                    if (line[5] == "Airforces" || line[5] == "Marines")
                    {
                        list.Add(eng);
                    }
                }

                if (line[0] == "Commando")
                {
                    var comm = new Commando(line[1], line[2], line[3], decimal.Parse(line[4]), line[5]);
                    var currList = new List<Mission>();

                    for (int i = 6; i < line.Length; i = i + 2)
                    {
                        if (line[i+1] == "inProgress" || line[i+1] == "Finished")
                        {
                            currList.Add(new Mission(line[i], line[i + 1]));
                        }
                        
                    }

                    comm.Mission.AddRange(currList);
                    if (line[5] == "Airforces" || line[5]== "Marines")
                    {
                        list.Add(comm);
                    }
                    
                }
                input = Console.ReadLine();
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
