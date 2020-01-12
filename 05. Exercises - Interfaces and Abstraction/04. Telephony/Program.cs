using System;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var phones = Console.ReadLine().Split();
            
            foreach (var phone in phones)
            {
                try
                {
                    var obj = new SmartPhone();
                     obj.PhoneNumber = phone;
                    Console.WriteLine(obj.Calling());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var urls = Console.ReadLine().Split();

            foreach (var url in urls)
            {
                try
                {
                    var obj = new SmartPhone();
                    obj.Www = url;
                    Console.WriteLine(obj.Browsig());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
