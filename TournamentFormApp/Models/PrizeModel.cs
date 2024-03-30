namespace TournamentFormApp.Models
{
    public class PrizeModel
    {
        public PrizeModel()
        {

        }
        public PrizeModel(string placename, string placenum, string priceamount, string priceper)
        {
            PlaceName = placename;
            int parsedPlaceNumber;
            if (int.TryParse(placenum, out parsedPlaceNumber))
            {
                PlaceNumber = parsedPlaceNumber;
            }


            decimal parsedPriceAmount;
            if (decimal.TryParse(priceamount, out parsedPriceAmount))
            {
                PriceAmount = parsedPriceAmount;
            }

            double parsedPricePercentage;
            if (double.TryParse(priceper, out parsedPricePercentage))
            {
                PricePercentage = parsedPricePercentage;
            }

        }

        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PriceAmount { get; set; }
        public double PricePercentage { get; set; }
    }

}