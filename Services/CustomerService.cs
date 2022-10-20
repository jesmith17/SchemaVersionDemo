using SchemaVersionDemo.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Core.Events;

namespace SchemaVersionDemo.Services;

public class CustomerService
{
    private readonly IMongoCollection<Customer> _customerCollection;
    private readonly ILogger<CustomerService> _logger;

    public CustomerService(
        IOptions<CustomerDatabaseSettings> customerDatabaseSettings, ILogger<CustomerService> logger)
    {
        _logger = logger;
        var connectionUrl = new MongoUrl(customerDatabaseSettings.Value.ConnectionString);
        var mongoClientSettings = MongoClientSettings.FromUrl(connectionUrl);
            mongoClientSettings.ClusterConfigurator = cb => {
                cb.Subscribe<CommandStartedEvent>(e => {
                _logger.LogWarning($"{e.CommandName} - {e.Command.ToString()}");
            });
        };


        var mongoClient = new MongoClient(
            mongoClientSettings);

        var mongoDatabase = mongoClient.GetDatabase(
            customerDatabaseSettings.Value.DatabaseName);

        _customerCollection = mongoDatabase.GetCollection<Customer>(
            customerDatabaseSettings.Value.CustomerCollectionName);
    }

    public List<Customer> Get() {
        
        var customerList =  _customerCollection.Find(_ => true).ToList();
        return customerList;
    }


    public Customer Save(Customer customer) {
        _customerCollection.InsertOne(customer);
        return customer;
    }

}