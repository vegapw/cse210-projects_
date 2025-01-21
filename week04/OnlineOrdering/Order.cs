
public class Order{

    Customer _customer;
    List<Product> _products = new List<Product>();

    public Order(Customer customer){
        _customer = customer;
    }

    public void AddProductToOrder(Product product){
        _products.Add(product);
    }

    public double CalculateTotalCost(){
        double cost = 0;
        foreach (Product item in _products)
        {
            cost += item.TotalCost();
        }
        cost += CalculateShippingCost();
        return cost;
    }

    private double CalculateShippingCost()
    {
        return _customer.LiveInUSA() ? 5.00 : 35.00;
    }

    public string PackingLabel(){
        string label = "";
        foreach (Product item in _products)
        {
            label += $"Product Name: {item.GetName()} - Product Id: {item.GetId()}\n";
        }
        return label;
    }

    public string ShippingLabel(){
        return _customer.GetDisplayCustomer();
    }
}