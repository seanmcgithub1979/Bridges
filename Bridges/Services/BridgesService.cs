using System;
using System.Collections.Generic;
using System.IO;
using Bridges.Interfaces;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;

namespace Bridges.Services
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
            return repo.FindBridgeId(id);
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

        public void ExportToCsv()
        {
            try
            {
                var filename = $"{DateTime.Now:yyyymmdd}_Bridges.csv";

                using StreamWriter sw = new(filename, false);
                sw.WriteLine("Id,Filennme,Name,Desc,Lng,Lat,Zoom,Height");
                foreach (Bridge bridge in GetAllBridges())
                {
                    sw.WriteLine($"{@bridge.Id},{@bridge.Filename},{@bridge.Name},{@bridge.Description},{@bridge.Lng},{@bridge.Lat},{@bridge.Zoom},{@bridge.Height}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void ExportToTxt(string? delim = "\t")
        {
            try
            {
                var filename = $"{DateTime.Now:yyyymmdd}_Bridges.txt";

                using StreamWriter sw = new(filename, false);
                sw.WriteLine($"Id{delim}Filennme{delim}Name{delim}Desc{delim}Lng{delim}Lat{delim}Zoom{delim}Height");
                foreach (Bridge bridge in GetAllBridges())
                {
                    sw.WriteLine($"{@bridge.Id}{delim}{@bridge.Filename}{delim}{@bridge.Name}{delim}{@bridge.Description}{delim}{@bridge.Lng}{delim}{@bridge.Lat}{delim}{@bridge.Zoom}{delim}{@bridge.Height}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void ExportToHtml()
        {
            try
            {
                var filename = $"{DateTime.Now:yyyymmdd}_Bridges.html";

                using StreamWriter sw = new(filename, false);
                sw.WriteLine("Id,Filennme,Name,Desc,Lng,Lat,Zoom,Height");
                foreach (Bridge bridge in GetAllBridges())
                {
                    sw.WriteLine($"{@bridge.Id},{@bridge.Filename},{@bridge.Name},{@bridge.Description},{@bridge.Lng},{@bridge.Lat},{@bridge.Zoom},{@bridge.Height}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void ExportToXml()
        {
            try
            {
                var filename = $"{DateTime.Now:yyyymmdd}_Bridges.xml";

                using StreamWriter sw = new(filename, false);
                sw.WriteLine("Id,Filennme,Name,Desc,Lng,Lat,Zoom,Height");
                foreach (Bridge bridge in GetAllBridges())
                {
                    sw.WriteLine($"{@bridge.Id},{@bridge.Filename},{@bridge.Name},{@bridge.Description},{@bridge.Lng},{@bridge.Lat},{@bridge.Zoom},{@bridge.Height}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}