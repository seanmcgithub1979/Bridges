using System;

namespace BridgesDomain.Interfaces
{
    public interface IConfig
    {
        string ConnectionString { get; set; }
        string Environment { get; set; }
        string EmailAddress { get; }
        DateTime SessionStart { get; }
        bool IsDevelopment { get; }
    }
}
