using Microsoft.AspNetCore.Mvc;
using SchemaVersionDemo.Models;
using SchemaVersionDemo.Services;

namespace SchemaVersionDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    
    private readonly ILogger<CustomerController> _logger;
    private readonly CustomerService _customerService;

    public CustomerController(ILogger<CustomerController> logger, CustomerService customerService) {
        _logger = logger;
        _customerService = customerService;

    } 

    [HttpGet]
    public List<Customer> Get() => _customerService.Get();


    [HttpPost]
    public Customer Save(SimpleCustomer customer){
        _logger.LogInformation("The customer information is " + customer.ToString());
        _customerService.Save(customer) ;
        return customer;
    }


    [HttpPost]
    [Route("complex")]
    public Customer Save(ComplexCustomer customer){
        _logger.LogInformation("The customer information is " + customer.GetPhones());
        _customerService.Save(customer) ;
        return customer;
    }



}
    
