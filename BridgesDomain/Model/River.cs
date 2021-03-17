namespace BridgesDomain.Model
{
    public class River
    {
        public double MouthLat { get; set; }
        public double MouthLng { get; set; }
        public double SourceLat { get; set; }
        public double SourceLng { get; set; }
        
        public River(double mouthLat, double mouthLng, double sourceLat, double sourceLng)
        {
            MouthLat = mouthLat;
            MouthLng = mouthLng;
            SourceLat = sourceLat;
            SourceLng = sourceLng;
        }
    }
}