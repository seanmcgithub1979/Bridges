namespace BridgesService.Interfaces;

public interface ICoordsService
{
    public double DistanceBetween(double startLat, double startLng, double endLat, double endLng);
}