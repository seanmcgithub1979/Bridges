using System;
using System.Collections.Generic;
using System.IO;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;
using BridgesService.Interfaces;

namespace BridgesService.Services
{
    public class BridgesService : IBridgesService
    {
        private readonly IBridgeRepo repo;
        
        public BridgesService(IBridgeRepo repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Bridge> GetAllBridges()
        {
            return repo.GetAllBridges();
        }

        public IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx)
        {
            return repo.GetBridgesInRange(noOfBridges, startIdx);
        }

        public Bridge GetBridgeById(int id)
        {
            return repo.GetBridgeById(id);
        }

        public Bridge GetBridgeByName(string name)
        {
            return repo.GetBridgeByName(name);
        }

        public void Add(Bridge bridge)
        {
            repo.Add(bridge);
        }

        public void Update(Bridge bridge)
        {
            repo.Update(bridge);
        }

        public void Delete(Bridge bridge)
        {
            repo.Delete(bridge);
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