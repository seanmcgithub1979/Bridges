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

        public void AddBridge(Bridge bridge)
        {
            context.Bridges.Add(bridge);
        }

        public void EditBridge(Bridge bridge)
        {
            context.Bridges.Update(bridge);
        }

        public void DeleteBridge(Bridge bridge)
        {
            context.Bridges.Remove(bridge);
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