namespace HotelReservation
{
    public class PriceCalculator
    {
        public double PricePerDay { get; set; }
        public int NumberOfDays { get; set; }
        public Season Season { get; set; }
        public DiscountType DiscountType { get; set; }

        public PriceCalculator(double pricePerDay, int numberOfDays, Season season)
        {
            this.PricePerDay = pricePerDay;
            this.NumberOfDays = numberOfDays;
            this.Season = season;
            this.DiscountType = 0;
        }

        public double Calculate()
        {
            var total = PricePerDay*(int)Season* NumberOfDays;

            var totalPrice = total * (1-(double)DiscountType/100);

            return totalPrice;
        }
    }
}
