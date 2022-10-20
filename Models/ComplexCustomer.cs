using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SchemaVersionDemo.Models;

//[BsonDiscriminator("ComplexCustomer")]
public class ComplexCustomer : Customer
{

 [BsonElement]
public List<Phone> Phone { get; set; } = null!;

}