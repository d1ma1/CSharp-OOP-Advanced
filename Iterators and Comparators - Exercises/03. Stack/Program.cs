using System;

namespace _03.Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<string>();

            while (input!= "END")
            {
                var line = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (line[0]=="Push")
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        stack.Push(line[i]);
                    }
                }
                if (line[0]=="Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, stack));

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
