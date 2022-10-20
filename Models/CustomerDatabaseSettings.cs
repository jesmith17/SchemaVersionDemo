namespace SchemaVersionDemo.Models;

public class CustomerDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string CustomerCollectionName { get; set; } = null!;
}