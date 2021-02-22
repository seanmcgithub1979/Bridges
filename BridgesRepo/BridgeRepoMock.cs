using System.Collections.Generic;
using System.Linq;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class BridgeRepoMock : IBridgeRepo
    {
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
        
        public IList<Bridge> GetAllBridges()
        {
            return GetMockBridges();
        }
        
        private static IList<Bridge> GetMockBridges()
        {
            var n = 62;
            IList<Bridge> retVal = new List<Bridge>(n);

            for (var i = 1; i <= n; i++)
            {
                retVal.Add(new() 
                { 
                    Id = i, 
                    Name = $"Bridge{i}", 
                    Filename  = $"Image{i}.jpg", 
                    Description = "Some desc here...", 
                    Lat = 50m,
                    Lng = 50m, 
                    Height = 1222m, 
                    Zoom = 14.25m
                });
            }

            return retVal;
        }
    }
}