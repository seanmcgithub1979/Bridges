namespace Bridges.Models
{
    public class Bridge
    {
        public Bridge(string filename, string name, string description)
        {
            Filename = filename;
            Name = name;
            Description = description;
        }

        public string Filename { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
