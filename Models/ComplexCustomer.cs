using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SchemaVersionDemo.Models;

[BsonDiscriminator("ComplexCustomer")]
public class ComplexCustomer : Customer

{
    private List<Phone> Phones;

     public void SetPhones(List<Phone> phones){
        this.Phones = phones;
    }

    public override List<Phone> GetPhones(){
        return this.Phones;
    }


}