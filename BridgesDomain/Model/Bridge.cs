namespace BridgesDomain.Model
{
    public class Bridge
    {
        public Bridge(
            string name = "[Name]",
            string filename = "[Filename]",
            string description = "[Desc]",
            double lat = 54.9136984,      // Default to the river wear mouth
            double lng = -1.3697736,      // Default to the river wear mouth
            double zoom = 14.22,       
            double height = 1222)

        {
            Name = name;
            Filename = filename;
            Description = description;
            Lat = lat;
            Lng = lng;
            Zoom = zoom;
            Height = height;

            AssignRiver(new River(54.9136984, -1.3697736, 54.9136984, -1.3697736));  // River wear for now...;))
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Filename { get; set; }
        public byte[] FileBytes { get; set; }
        public string Description { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public double DistanceToMouthKm { get; set; }
        public double DistanceToSourceKm { get; set; }
        public double Zoom { get; set; }
        public double Height { get; set; }
        public River River;

        public void AssignRiver(River river)
        {
            River = river;
        }
    }
}