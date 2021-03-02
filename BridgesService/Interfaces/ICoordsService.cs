namespace BridgesService.Interfaces
{
    public interface ICoordsService
    {
        public double DistanceBetween(double StartLat, double StartLng, double EndLat, double EndLng);
    }
}
