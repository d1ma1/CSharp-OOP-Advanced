using System;

namespace HotelReservation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var priceCalc =
                new PriceCalculator(double.Parse(input[0]),
                int.Parse(input[1]),
                Enum.Parse<Season>(input[2]));

            if (input.Length == 4)
            {
                priceCalc.DiscountType = Enum.Parse<DiscountType>(input[3]);
            }

            Console.WriteLine($"{priceCalc.Calculate():F2}");
        }
    }
}
