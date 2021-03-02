using System;
using BridgesService.Interfaces;

namespace BridgesService.Services
{
    public class CoordService : ICoordsService
    {
        public double DistanceBetween(double startLat, double startLng, double endLat, double endLng)
        {
            const double radsOverDegs = (Math.PI / 180.0);

            var startLatRads = startLat * radsOverDegs;
            var startLngRads = startLng * radsOverDegs;
            var endLatRads = endLat * radsOverDegs;
            var endLngRads = endLng * radsOverDegs;

            var dLongitude = endLngRads - startLngRads;
            var dLatitude = endLatRads - startLatRads;

            var x = Math.Pow(Math.Sin(dLatitude / 2.0), 2.0) +  
                    Math.Cos(startLatRads) * Math.Cos(endLatRads) *  
                    Math.Pow(Math.Sin(dLongitude / 2.0), 2.0);

            // 6329.6 radius of the earth in Km
            var retVal = 6329.6 * 2.0 * Math.Atan2(Math.Sqrt(x), Math.Sqrt(1.0 - x));

            return retVal;
        }
    }
}
