namespace BridgesService.Interfaces;

public interface IBridgesService
{
    IEnumerable<Bridge> GetAllBridges();
    IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx);
        
    Bridge GetBridgeById(int id);
    Bridge GetBridgeByName(string name);
        
    void Add(Bridge bridge);
    void Update(Bridge bridge, bool addImage = false);
    void Delete(Bridge bridge);
        
    string GetFilenamesForBackgroundCycle();
        
    string ExportToCsv();
    string ExportToTxt(string delim = "\t");
    string ExportToHtml();
    string ExportToXml();
    string GetHexColor(double distance);
}