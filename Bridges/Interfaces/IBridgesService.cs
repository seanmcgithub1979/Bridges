using System.Collections.Generic;
using BridgesDomain.Model;

namespace Bridges.Interfaces
{
    public interface IBridgesService
    {
        IEnumerable<Bridge> GetAllBridges();
        Bridge GetBridge(string name);
    }
}