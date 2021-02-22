﻿using System.Collections.Generic;
using System.Linq;
using BridgesDomain.Model;
using BridgesRepo.Data;
using BridgesRepo.Interfaces;

namespace BridgesRepo
{
    public class BridgeRepoSqlServer : IBridgeRepo
    {
        private readonly BridgesDbContext context;

        public BridgeRepoSqlServer(BridgesDbContext context)
        {
            this.context = context;
        }

        public void Add(Bridge bridge)
        {
            context.Bridges.Add(bridge);
            context.SaveChanges();
        }
        
        public void Delete(Bridge bridge)
        {
            context.Bridges.Remove(bridge);
            context.SaveChanges();
        }

        public void Update(Bridge bridge)
        {
            context.Bridges.Update(bridge);
            context.SaveChanges();
        }

        public IList<Bridge> GetAllBridges()
        {
            return context.Bridges.ToList();
        }

        public IEnumerable<Bridge> GetBridgesInRange(int noOfBridges, int startIdx)
        {
            return GetAllBridges().Skip(startIdx).Take(noOfBridges);
        }

        public Bridge FindBridgeId(int id)
        {
            return context.Bridges.FirstOrDefault(x => x.Id == id);
        }
    }
}