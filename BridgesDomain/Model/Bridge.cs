using System.Runtime.CompilerServices;

namespace BridgesDomain.Model
{
    public class Bridge
    {
        public Bridge()
        {
        }

        public Bridge(
            string filename = "No filename specifed for this bridge yet.", 
            string name = "No name entered for this bridge yet.", 
            string description = "No desc entered for this bridge yet................................................................",
            decimal lng = -1.3697736m,   // Default to the river
            decimal lat = 54.9136984m,   // Default to the river
            decimal zoom = 14.25m,       // Google param
            decimal height = 1222.0m)    // Google param
        {
            Filename = filename;
            Name = name;
            Description = description;
            Lng = lng;
            Lat = lat;
            Zoom = zoom;
            Height = height;
        }

        public int Id { get; set; }
        public string Filename { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Lng { get; set; }
        public decimal Lat { get; set; }
        public decimal Zoom { get; set; }
        public decimal Height { get; set; }
    }
}