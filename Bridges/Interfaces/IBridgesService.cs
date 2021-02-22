using System.Collections.Generic;
using BridgesDomain.Model;

namespace Bridges.Interfaces
{
    public interface IBridgesService
    {
        IEnumerable<Bridge> GetAllBridges();
        IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx);
        Bridge GetBridgeById(int id);
        void Add(Bridge bridge);
        void Update(Bridge bridge);
        void Delete(Bridge bridge);
        void ExportToCsv();
        void ExportToTxt(string? delim = "\t");
        void ExportToHtml();
        void ExportToXml();
    }
}