using System.Collections.Generic;
using System.Linq;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class BridgeRepoMock : IBridgeSqlServerRepo
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

        private static IList<Bridge> GetMockBridges()
        {
            var n = 62;
            IList<Bridge> retVal = new List<Bridge>(n);

            for (var i = 1; i <= n; i++)
            {
                retVal.Add(new Bridge {Filename = $"Image{i}.jpg", Name = $"Image {i}"});
            }

            return retVal;
        }

        public Bridge FindBridgeNyName(string name)
        {
            return GetMockBridges().FirstOrDefault(x => x.Name == name);
        }
    }
}