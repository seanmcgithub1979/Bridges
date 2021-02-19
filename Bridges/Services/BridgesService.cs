using System.Collections.Generic;
using Bridges.Interfaces;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;

namespace Bridges.Services
{
    public class BridgesService : IBridgesService
    {
        private readonly IBridgeSqlServerRepo repo;
        
        public BridgesService(IBridgeSqlServerRepo repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Bridge> GetAllBridges()
        {
            return repo.GetAllBridges();
        }

        public Bridge GetBridge(string name)
        {
            return repo.FindBridgeNyName(name);
        }
    }
}