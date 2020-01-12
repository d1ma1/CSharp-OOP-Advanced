using System;
using System.Linq;

namespace StorageMaster
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var storageMaster = new StorageMaster();
            var output = "";

            while (input!="END")
            {
                var line = input.Split();
                var cmd = line[0];

                try
                {
                    if (cmd == "AddProduct")
                    {
                        output = storageMaster.AddProduct(line[1], double.Parse(line[2]));
                    }
                    if (cmd == "RegisterStorage")
                    {
                        output = storageMaster.RegisterStorage(line[1], line[2]);
                    }
                    if (cmd == "SelectVehicle")
                    {
                        output = storageMaster.SelectVehicle(line[1], int.Parse(line[2]));
                    }
                    if (cmd == "LoadVehicle")
                    {
                        output = storageMaster.LoadVehicle(line.Skip(1));
                    }
                    if (cmd == "SendVehicleTo")
                    {
                        output = storageMaster.SendVehicleTo(line[1], int.Parse(line[2]), line[3]);
                    }
                    if (cmd == "UnloadVehicle")
                    {
                        output = storageMaster.UnloadVehicle(line[1], int.Parse(line[2]));
                    }
                    if (cmd == "GetStorageStatus")
                    {
                        output = storageMaster.GetStorageStatus(line[1]);
                    }
                }
                catch (InvalidOperationException ex)
                {
                    output = "Error: " + ex.Message;
                }
                Console.WriteLine(output);
                input = Console.ReadLine();
            }

            output = storageMaster.GetSummary();
            Console.WriteLine(output);
        }
    }
}
