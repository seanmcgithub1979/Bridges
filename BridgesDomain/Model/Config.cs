using System;
using BridgesDomain.Interfaces;

namespace BridgesDomain.Model
{
    public class Config : IConfig
    {
        public string Environment { get; set; }
        public string EmailAddress => "seanmccann@hotmail.com";
        public string ConnectionString { get; set; }
        public DateTime LastRefreshed => DateTime.Now;
        public bool IsDevelopment => Environment.ToLowerInvariant() == "development";
    }
}