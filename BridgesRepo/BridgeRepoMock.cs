using System.Collections.Generic;
using System.Linq;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class BridgeRepoMock : IBridgeRepo
    {
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

        public IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx)
        {
            return GetMockBridges().Skip(startIdx).Take(noOfBridges);
        }

        public Bridge FindBridgeId(int id)
        {
            return GetMockBridges().FirstOrDefault(x => x.Id == id);
        }

        private static IList<Bridge> GetMockBridges()
        {
            var n = 62;
            IList<Bridge> retVal = new List<Bridge>(n);

            for (var i = 1; i <= n; i++)
            {
                retVal.Add(new Bridge {Id = i, Filename = $"Image{i}.jpg", Name = $"Image {i}"});
            }

            return retVal;
        }
    }
}