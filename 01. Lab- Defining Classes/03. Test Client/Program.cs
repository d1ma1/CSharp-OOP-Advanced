using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var dict = new Dictionary<int, BankAccount>();

        var line = Console.ReadLine();

        while (line != "End")
        {
            var input = line.Split(' ');

            var acc = new BankAccount();

            if (input[0] == "Create")
            {               
                if (!dict.ContainsKey(int.Parse(input[1])))
                {  
                    acc.Id = int.Parse(input[1]);
                    dict[int.Parse(input[1])] = acc;
                }
                else
                {
                    Console.WriteLine("Account already exists");
                }
            }

            if (!dict.ContainsKey(int.Parse(input[1])))
            {
                Console.WriteLine("Account does not exist");
            }

            else
            {
                if (input[0] == "Deposit")
                {
                    dict[int.Parse(input[1])].Deposit(decimal.Parse(input[2]));
                }

                if (input[0] == "Withdraw")
                {
                    if (dict[int.Parse(input[1])].Balance < decimal.Parse(input[2]))
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    else
                    {
                        dict[int.Parse(input[1])].Withdraw(decimal.Parse(input[2]));
                    }
                }

                if (input[0] == "Print")
                {
                    Console.WriteLine($"Account ID{int.Parse(input[1])}, balance {dict[int.Parse(input[1])].Balance:F2}");
                }
            }

            line = Console.ReadLine();
        }
    }
}
