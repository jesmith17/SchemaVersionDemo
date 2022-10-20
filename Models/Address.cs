using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SchemaVersionDemo.Models;

public class Address
{


    public string Street { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string PostCode { get; set; } = null!;
    public string Country { get; set; } = null!;
    
}