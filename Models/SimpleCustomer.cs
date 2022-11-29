using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SchemaVersionDemo.Models;

[BsonDiscriminator("SimpleCustomer")]
public class SimpleCustomer : Customer
{




    private List<Phone> Phones;
    [BsonElement]
    private string Phone;

    
    public override List<Phone> GetPhones(){
        return Phones;
    }

    public String GetPhone(){
        return "";
    }

    public void SetPhone(string phone) {
        Phone phone1 = new Phone();
        phone1.number = phone;
        phone1.type = "other";    
        
        Phones.Append(phone1);
    }

}