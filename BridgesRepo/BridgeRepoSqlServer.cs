using System.Collections.Generic;
using System.Linq;
using BridgesDomain.Model;
using BridgesRepo.Data;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class BridgeRepoSqlServer : IBridgeRepo
    {
        private readonly BridgesDbContext context;

        public BridgeRepoSqlServer(BridgesDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Bridge> GetAllBridges()
        {
            return context.Bridges.OrderBy(o => o.DistanceFromSourceMiles);
        }

        // Used in paging
        public IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx)
        {
            return GetAllBridges()
                .Skip(startIdx)
                .Take(noOfBridges);
        }

        public Bridge GetBridgeById(int id)
        {
            return context.Bridges.FirstOrDefault(x => x.Id == id);
        }

        public Bridge GetBridgeByName(string name)
        {
            return context.Bridges.FirstOrDefault(x => x.Name == name);
        }

        public void Add(Bridge bridge)
        {
            context.Bridges.Add(bridge);
            context.SaveChanges();
        }

        public void Delete(Bridge bridge)
        {
            context.Bridges.Remove(bridge);
            context.SaveChanges();
        }

        public void Update(Bridge bridge)
        {
            context.Bridges.Update(bridge);
            context.SaveChanges();
        }
    }
}