using System.Collections.Generic;
using BridgesDomain.Model;

namespace BridgesRepo.Interfaces
{
    public interface IBridgeSqlServerRepoMock
    {
        void AddBridge(Bridge bridge);
        void DeleteBridge(Bridge bridge);
        void EditBridge(Bridge bridge);
        IList<Bridge> GetAllBridges();
        Bridge FindBridgeNyName(string name);
    }
}