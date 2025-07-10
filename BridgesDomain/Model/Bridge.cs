namespace BridgesDomain.Model;

public class Bridge
{
    private readonly River riverWear = new (54.9136984, -1.3697736, 54.75, -2.2225);

    public Bridge()
    {
        AssignRiver(riverWear);
    }

    public Bridge(string name,
        string filename,
        string description,
        double lat,
        double lng,
        double zoom = 14.22,
        double height = 200)
    {
        Name = name;
        Filename = filename;
        Description = description;
        Lat = lat;
        Lng = lng;
        Zoom = zoom;
        Height = height;

        AssignRiver(riverWear);
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Filename { get; set; }
    public byte[] FileBytes { get; set; }
    public string Description { get; set; }
    public double Lat { get; set; }
    public double Lng { get; set; }
    public double DistanceToMouthMiles { get; set; }
    public double DistanceFromSourceMiles { get; set; }
    public double Zoom { get; set; }
    public double Height { get; set; }
    public DateTime LastModified { get; set; }
    public River River;

    public void AssignRiver(River river)
    {
        River = river;
    }
}