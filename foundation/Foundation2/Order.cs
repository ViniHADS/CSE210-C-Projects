using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    private const decimal DomesticShippingCost = 5.00m;
    private const decimal InternationalShippingCost = 35.00m;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal total = 0;

        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        total += _customer.LivesInUSA() ? DomesticShippingCost : InternationalShippingCost;
        return total;
    }

    public string PackingLabel()
    {
        var label = new System.Text.StringBuilder();
        foreach (var product in _products)
        {
            label.AppendLine($"{product.Name} (ID: {product.ProductId})");
        }
        return label.ToString().Trim();
    }

    public string ShippingLabel()
    {
        return $"Name: {_customer.Name}\n{_customer.Address.FullAddress()}";
    }
}
