namespace Bridges.Models
{
    public class Bridge
    {
        public Bridge(string filename, string name, string description, double lat = 0.0d, double lng = 0.0d)
        {
            Filename = filename;
            Name = name;
            Description = description;
            Lat = lat;
            Lng = lng;
        }

        public string Filename { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}