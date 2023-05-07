using FluentValidation.Models; // Order
using FluentValidation.Validators; // OrderValidation
using FluentValidation.Results; // ValidationResult

Order order = new()
{
    OrderId = 10001,
    CustomerName = "Abc",
    CustomerEmail = "abc&example.com",
    CustomerLevel = (CustomerLevel)4,
    OrderDate = new(2023, 12, 1),
    ShipDate = new(2023, 11, 5),
    Total = 49.99M
};

OrderValidator validator = new();

ValidationResult result = validator.Validate(order);

WriteLine($"CustomerName:   {order.CustomerName}");
WriteLine($"CustomerEmail:  {order.CustomerEmail}");
WriteLine($"CusomerLevel:   {order.CustomerLevel}");
WriteLine($"OrderId:        {order.OrderId}");
WriteLine($"OrderDate:      {order.OrderDate}");
WriteLine($"ShipDate:       {order.ShipDate}");
WriteLine($"Total:          {order.Total}");
WriteLine();
WriteLine($"IsValid:        {result.IsValid}");
foreach( var item in result.Errors)
{
    WriteLine($" {item.Severity}: {item.ErrorMessage}\n");
}
