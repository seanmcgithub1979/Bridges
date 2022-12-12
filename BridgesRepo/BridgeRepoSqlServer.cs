using System.Collections.Generic;
using System.Linq;
using BridgesDomain.Model;
using BridgesRepo.Data;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class BridgeRepoSqlServer : IBridgeRepo
    {
        private readonly BridgesDbContext _context;

        public BridgeRepoSqlServer(BridgesDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Bridge> GetAllBridges()
        {
            return _context.Bridges.OrderBy(o => o.DistanceFromSourceMiles);
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
            return _context.Bridges.FirstOrDefault(x => x.Id == id);
        }

        public Bridge GetBridgeByName(string name)
        {
            return _context.Bridges.FirstOrDefault(x => x.Name == name);
        }

        public void Add(Bridge bridge)
        {
            _context.Bridges.Add(bridge);
            _context.SaveChanges();
        }

        public void Delete(Bridge bridge)
        {
            _context.Bridges.Remove(bridge);
            _context.SaveChanges();
        }

        public void Update(Bridge bridge)
        {
            _context.Bridges.Update(bridge);
            _context.SaveChanges();
        }
    }
}