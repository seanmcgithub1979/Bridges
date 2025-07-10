namespace BridgesDomain.Interfaces;

public interface IConfig
{
    string ConnectionString { get; set; }
    string Environment { get; set; }
    string EmailAddress { get; }
    DateTime LastRefreshed { get; }
    bool IsDevelopment { get; }
}