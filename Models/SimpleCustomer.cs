using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SchemaVersionDemo.Models;

//[BsonDiscriminator("SimpleCustomer")]
public class SimpleCustomer : Customer
{


 [BsonElement]
public string Phone { get; set; } = null!;


}