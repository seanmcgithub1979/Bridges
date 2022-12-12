﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BridgesDomain.Model;
using BridgesRepo.Interfaces;
using BridgesService.Interfaces;

namespace BridgesService.Services
{
    public class BridgesService : IBridgesService
    {
        private readonly IBridgeRepo _repo;
        private readonly ICoordsService _coordsService;
        private IDictionary<int, string> _colorMap;

        public BridgesService(IBridgeRepo repo, ICoordsService coordsService)
        {
            _repo = repo;
            _coordsService = coordsService;
            BuildColourMap();
        }
        
        public IEnumerable<Bridge> GetAllBridges()
        {
            return _repo.GetAllBridges();
        }

        public IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx)
        {
            return _repo.GetBridgesInRange(noOfBridges, startIdx);
        }

        public Bridge GetBridgeById(int id)
        {
            return _repo.GetBridgeById(id);
        }

        public Bridge GetBridgeByName(string name)
        {
            return _repo.GetBridgeByName(name);
        }
        
        public void Add(Bridge bridge)
        {
            StampModifiedDate(bridge);
            _repo.Add(bridge);
        }

        public void Update(Bridge bridge, bool addImage = false)
        {
            if (addImage)
            {
                AddImageToBridge(bridge);
            }
            
            StampCalculatedDistances(bridge);
            StampModifiedDate(bridge);
            
            _repo.Update(bridge);
        }
        
        public void Delete(Bridge bridge)
        {
            _repo.Delete(bridge);
        }

        public string GetFilenamesForBackgroundCycle()
        {
            StringBuilder bob = new StringBuilder();
            {
                DirectoryInfo dir = new(@"wwwroot\Images\Thumbs");
                foreach (FileInfo fi in dir.GetFiles())
                {
                    bob.Append($"Images/Thumbs/{fi.Name},");
                }

                bob.Remove(bob.Length - 1, 1);
            }

            return bob.ToString();

        }

        private void AddImageToBridge(Bridge bridge)
        {
            try
            {
                using Stream sr = new FileStream($@"wwwroot\Images\Original\{bridge.Filename}", FileMode.Open);
                using BinaryReader br = new(sr);
                bridge.FileBytes = br.ReadBytes((int)sr.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void StampModifiedDate(Bridge bridge)
        {
            bridge.LastModified = DateTime.UtcNow;
        }


        private void StampCalculatedDistances(Bridge bridge)
        {
            bridge.DistanceToMouthMiles = _coordsService.DistanceBetween(bridge.Lat, bridge.Lng, bridge.River.MouthLat, bridge.River.MouthLng);
            bridge.DistanceFromSourceMiles = _coordsService.DistanceBetween(bridge.Lat, bridge.Lng, bridge.River.SourceLat, bridge.River.SourceLng);
        }

        public string ExportToCsv()
        {
            try
            {
                var filename = $"{DateTime.Now:yyyyMMddHHmm}_Bridges.csv";

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
                var filename = $"{DateTime.Now:yyyyMMddHHmm}_Bridges.txt";

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
                var filename = $"{DateTime.Now:yyyyMMddHHmm}_Bridges.html";

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
                var filename = $"{DateTime.Now:yyyyMMddHHmm}_Bridges.xml";

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

        public string GetHexColor(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            else if (distance > 60)
            {
                distance = 60;
            }

            distance = distance / 4;

            return _colorMap[(int)distance];
        }

        private void BuildColourMap()
        {
            _colorMap = new Dictionary<int, string>();

            _colorMap.Add(new KeyValuePair<int, string>(0, "#053a56"));
            _colorMap.Add(new KeyValuePair<int, string>(1, "#064667"));
            _colorMap.Add(new KeyValuePair<int, string>(2, "#075179"));
            _colorMap.Add(new KeyValuePair<int, string>(3, "#085d8a"));
            _colorMap.Add(new KeyValuePair<int, string>(4, "#09699b"));
            _colorMap.Add(new KeyValuePair<int, string>(5, "#0a75ad"));
            _colorMap.Add(new KeyValuePair<int, string>(6, "#2282b5"));
            _colorMap.Add(new KeyValuePair<int, string>(8, "#539ec5"));
            _colorMap.Add(new KeyValuePair<int, string>(7, "#3a90bd"));
            _colorMap.Add(new KeyValuePair<int, string>(9, "#6caccd"));
            _colorMap.Add(new KeyValuePair<int, string>(10, "#84bad6"));
            _colorMap.Add(new KeyValuePair<int, string>(11, "#9dc7de"));
            _colorMap.Add(new KeyValuePair<int, string>(12, "#b5d5e6"));
            _colorMap.Add(new KeyValuePair<int, string>(13, "#cee3ee"));
            _colorMap.Add(new KeyValuePair<int, string>(14, "#e6f1f6"));
            _colorMap.Add(new KeyValuePair<int, string>(15, "#ffffff"));
        }
    }
}