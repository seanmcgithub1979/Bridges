using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;
using BridgesService.Interfaces;

namespace BridgesService.Services
{
    public class BridgesService : IBridgesService
    {
        private readonly IBridgeRepo repo;
        private readonly ICoordsService coordsService;

        private readonly River river = new(54.9136984, -1.3697736, 54.75, -2.2225);

        public BridgesService(IBridgeRepo repo)
        {
            this.repo = repo;
            coordsService = new CoordService();;
        }

        public IEnumerable<Bridge> GetAllBridges()
        {
            var allBridges = repo.GetAllBridges().ToList();
            
            AssignRiverToBridges(allBridges);

            return allBridges;
        }

        public IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx)
        {
            var bridgesInRange = repo.GetBridgesInRange(noOfBridges, startIdx).ToList();
            
            AssignRiverToBridges(bridgesInRange);
            
            return bridgesInRange;
        }

        public Bridge GetBridgeById(int id)
        {
            return repo.GetBridgeById(id);
        }

        public Bridge GetBridgeByName(string name)
        {
            Bridge bridge = repo.GetBridgeByName(name);
            
            bridge.AssignRiver(river);
            
            return bridge;
        }
        
        public void Add(Bridge bridge)
        {
            repo.Add(bridge);
        }

        public void Update(Bridge bridge)
        {
            object syncObj = new();
            lock (syncObj)
            {
                AddImageToBridge(bridge);
                StampCalculatedDistances(bridge);
                StampModifiedDate(bridge);
            }

            repo.Update(bridge);
        }


        public void Delete(Bridge bridge)
        {
            repo.Delete(bridge);
        }

        private void AddImageToBridge(Bridge bridge)
        {
            var filename = bridge.Filename;

            using Stream sr = new FileStream($@"wwwroot\Images\Original\{filename}", FileMode.Open);
            using BinaryReader br = new(sr);

            var bytes = br.ReadBytes((int)sr.Length);

            bridge.FileBytes = bytes;
        }

        private void StampModifiedDate(Bridge bridge)
        {
            bridge.LastModified = DateTime.UtcNow;
        }


        private void StampCalculatedDistances(Bridge bridge)
        {
            bridge.DistanceToMouthKm = coordsService.DistanceBetween(bridge.Lat, bridge.Lng, bridge.River.MouthLat, bridge.River.MouthLng);
            bridge.DistanceFromSourceKm = coordsService.DistanceBetween(bridge.Lat, bridge.Lng, bridge.River.SourceLat, bridge.River.SourceLng);
        }

        // TODO: Remove hack
        private void AssignRiverToBridges(IEnumerable<Bridge> allBridges)
        {
            foreach (Bridge bridge in allBridges)
            {
                bridge.AssignRiver(river);
            }
        }

        public string ExportToCsv()
        {
            try
            {
                var filename = $"{DateTime.Now:yyyyMMddhhmm}_Bridges.csv";

                using StreamWriter sw = new(filename, false);
                sw.WriteLine("Id,Filennme,Name,Desc,Lng,Lat,Zoom,Height");
                foreach (Bridge bridge in GetAllBridges())
                {
                    sw.WriteLine($"{@bridge.Id},{@bridge.Filename},{@bridge.Name},{@bridge.Description},{@bridge.Lng},{@bridge.Lat},{@bridge.Zoom},{@bridge.Height}");
                }

                return filename;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string ExportToTxt(string delim = "\t")
        {
            try
            {
                var filename = $"{DateTime.Now:yyyyMMddhhmm}_Bridges.txt";

                using StreamWriter sw = new(filename, false);
                sw.WriteLine($"Id{delim}Filennme{delim}Name{delim}Desc{delim}Lng{delim}Lat{delim}Zoom{delim}Height");
                foreach (Bridge bridge in GetAllBridges())
                {
                    sw.WriteLine($"{@bridge.Id}{delim}{@bridge.Filename}{delim}{@bridge.Name}{delim}{@bridge.Description}{delim}{@bridge.Lng}{delim}{@bridge.Lat}{delim}{@bridge.Zoom}{delim}{@bridge.Height}");
                }

                return filename;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string ExportToHtml()
        {
            try
            {
                var filename = $"{DateTime.Now:yyyyMMddhhmm}_Bridges.html";

                using StreamWriter sw = new(filename, false);
                sw.WriteLine("<html><body><table>");
                sw.WriteLine("<td>Id</td><td>Filename</td><td>Name</td><td>Desc</td><td>Lng</td><td>Lat</td><td>Zoom</td><td>Height</td>");
                foreach (Bridge bridge in GetAllBridges())
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine(
                        $"<td>{@bridge.Id}</td>" +
                        $"<td>{@bridge.Filename}</td>" +
                        $"<td>{@bridge.Name}</td>" +
                        $"<td>{@bridge.Description}</td>" + 
                        $"<td>{@bridge.Lng}</td>" +
                        $"<td>{ @bridge.Lat}</td>" + 
                        $"<td>{@bridge.Zoom}</td>" +
                        $" < td >{ @bridge.Height}");
                    sw.WriteLine("</tr>");
                }
                sw.WriteLine("</table></body></html>");

                return filename;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string ExportToXml()
        {
            try
            {
                var filename = $"{DateTime.Now:yyyyMMddhhmm}_Bridges.xml";

                using StreamWriter sw = new(filename, false);
                sw.WriteLine("<xml>");
                foreach (Bridge bridge in GetAllBridges())
                {
                    sw.WriteLine("<Bridge>");
                    sw.WriteLine(
                        $"<Id>{@bridge.Id}</Id>" +
                        $"<Filename>{@bridge.Filename}</Filename>" +
                        $"<Name>{@bridge.Name}</Name>" +
                        $"<Description>{@bridge.Description}</Description>" +
                        $"<Lat>{@bridge.Lat}</Lat>" +
                        $"<Lng>{ @bridge.Lng}<Lng>" +
                        $"<Zoom>{@bridge.Zoom}</Zoom>" +
                        $"<Height>{ @bridge.Height}</Height>");
                    sw.WriteLine("</Bridge>");
                }
                sw.WriteLine("</xml>");

                return filename;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}