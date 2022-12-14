using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SchemaVersionDemo.Models;

[BsonDiscriminator(RootClass = true)]
[BsonKnownTypes(typeof(SimpleCustomer),typeof(ComplexCustomer))]

public abstract class Customer
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Suffix { get; set; } = null!;
    public string Prefix { get; set; } = null!;
    
    [BsonElement]
    public List<Phone> Phones;

    
    public abstract List<Phone> GetPhones();



    public List<Address> Addresses {get; set; } = new List<Address>();    
}