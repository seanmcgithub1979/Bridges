using System.Collections.Generic;
using BridgesDomain.Model;

namespace BridgesRepo.Interfaces
{
    public interface IBridgeRepo
    {
        IList<Bridge> GetAllBridges();
        
        IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx);
        
        Bridge FindBridgeId(int id);
        
        void Add(Bridge bridge);
        void Delete(Bridge bridge);
        void Update(Bridge bridge);
    }
}
