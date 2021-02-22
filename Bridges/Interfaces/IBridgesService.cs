using System.Collections.Generic;
using BridgesDomain.Model;

namespace Bridges.Interfaces
{
    public interface IBridgesService
    {
        IEnumerable<Bridge> GetAllBridges();
        IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx);
        
        Bridge GetBridgeById(int id);
        
        Bridge GetBridgeByName(string name);
        
        void Add(Bridge bridge);
        void Update(Bridge bridge);
        void Delete(Bridge bridge);
        
        string ExportToCsv();
        string ExportToTxt(string? delim = "\t");
        string ExportToHtml();
        string ExportToXml();
    }
}