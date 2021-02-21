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

        public Bridge GetBridge(string name)
        {
            return repo.FindBridgeNyName(name);
        }

        public void Update(Bridge bridge)
        {
            repo.Update(bridge);
        }

        public void ExportToCsv()
        {
            try
            {
                var filename = $"{DateTime.Now:yyyymmdd}_Bridges.csv";

                StreamWriter sw = new(filename, false);

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