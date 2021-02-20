using System.Collections.Generic;
using System.Linq;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class BridgeSqlServerRepo : IBridgeSqlServerRepo
    {
        private readonly IBridgesDbContext context;

        public BridgeSqlServerRepo(IBridgesDbContext context)
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

        public Bridge FindBridgeNyName(string name)
        {
            return context.Bridges.FirstOrDefault(x => x.Name == name);
        }
    }
}