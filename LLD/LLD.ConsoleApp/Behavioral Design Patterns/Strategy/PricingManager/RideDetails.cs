namespace LLD.ConsoleApp.Strategy.PricingManager
{
    public class RideDetails
    {
        private double distance; // Distance in kilometers
        private int duration; // Duration in minutes

        public RideDetails(double distance, int duration)
        {
            this.distance = distance;
            this.duration = duration;
        }

        public double GetDistance()
        {
            return distance;
        }

        public int GetDuration()
        {
            return duration;
        }
    }
}