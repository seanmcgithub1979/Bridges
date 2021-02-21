using System.Collections.Generic;
using BridgesDomain.Model;

namespace BridgesRepo.Interfaces
{
    public interface IBridgeRepo
    {
        void Add(Bridge bridge);
        void Delete(Bridge bridge);
        void Update(Bridge bridge);
        IList<Bridge> GetAllBridges();
        IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx);
        Bridge FindBridgeNyName(string name);
    }
}
