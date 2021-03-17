using System.Collections.Generic;
using BridgesDomain.Model;

namespace BridgesRepo.Interfaces
{
    public interface IBridgeRepo
    {
        IEnumerable<Bridge> GetAllBridges();
        
        IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx);

        Bridge GetBridgeById(int id);
        Bridge GetBridgeByName(string name);

        void Add(Bridge bridge);
        void Delete(Bridge bridge);
        void Update(Bridge bridge);
    }
}
