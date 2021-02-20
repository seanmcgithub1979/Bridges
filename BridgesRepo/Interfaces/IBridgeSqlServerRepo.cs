using System.Collections.Generic;
using BridgesDomain.Model;

namespace BridgesRepo.Interfaces
{
    public interface IBridgeSqlServerRepo
    {
        void Add(Bridge bridge);
        void Delete(Bridge bridge);
        void Update(Bridge bridge);
        IList<Bridge> GetAllBridges();
        Bridge FindBridgeNyName(string name);
    }
}
