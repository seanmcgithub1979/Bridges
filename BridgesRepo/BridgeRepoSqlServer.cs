using System.Collections.Generic;
using System.Linq;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class BridgeRepoSqlServer : IBridgeRepo
    {
        private readonly IBridgesDbContext context;

        public BridgeRepoSqlServer(IBridgesDbContext context)
        {
            this.context = context;
        }

        public void Add(Bridge bridge)
        {
            context.Bridges.Add(bridge);
        }
        
        public void Delete(Bridge bridge)
        {
            context.Bridges.Remove(bridge);
        }

        public void Update(Bridge bridge)
        {
            context.Bridges.Update(bridge);
        }

        public IList<Bridge> GetAllBridges()
        {
            return context.Bridges.ToList();
        }

        public IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx)
        {
            return GetAllBridges().Skip(startIdx).Take(noOfBridges);
        }

        public Bridge FindBridgeNyName(string name)
        {
            return context.Bridges.FirstOrDefault(x => x.Name == name);
        }
    }
}