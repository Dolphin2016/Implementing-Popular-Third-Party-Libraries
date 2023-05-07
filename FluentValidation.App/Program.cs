using FluentValidation.Models; // Order
using FluentValidation.Validators; // OrderValidation
using FluentValidation.Results; // ValidationResult

Order order = new()
{
    // start with an invalid order
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
