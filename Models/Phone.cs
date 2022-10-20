using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SchemaVersionDemo.Models;

public class Phone
{


    public string type { get; set; } = null!;
    public string number { get; set; } = null!;
    public int country_prefix { get; set; } = 1!;
    
    
}