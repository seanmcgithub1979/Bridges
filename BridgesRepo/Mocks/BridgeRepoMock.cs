namespace BridgesRepo.Mocks;

public class BridgeRepoMock : IBridgeRepo
{
    public IEnumerable<Bridge> GetAllBridges()
    {
        return GetMockBridges();
    }

    public IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx)
    {
        return GetMockBridges().Skip(startIdx).Take(noOfBridges);
    }

    public Bridge GetBridgeById(int id)
    {
        return GetMockBridges().FirstOrDefault(x => x.Id == id);
    }

    public Bridge GetBridgeByName(string name)
    {
        return GetMockBridges().FirstOrDefault(x => x.Name == name);
    }

    public void Add(Bridge bridge)
    {
    }

    public void Delete(Bridge bridge)
    {
    }

    public void Update(Bridge bridge)
    {
    }

    private static IList<Bridge> GetMockBridges()
    {
        var n = 40;
        IList<Bridge> retVal = new List<Bridge>(n);

        for (var i = 1; i <= n; i++)
        {
            retVal.Add(new Bridge() 
            { 
                Id = i, 
                Name = $"Bridge{i}",
                Filename = $"Image{i}.jpg",
                FileBytes = null,
                Description = "Some desc here...",
                Lat = 54.9098616 - i/100,
                Lng = -1.3826032,
                DistanceToMouthMiles = n - i,
                DistanceFromSourceMiles = i,
                Height = 1222, 
                Zoom = 14.25
            });
        }

        return retVal;
    }
}