public class Product{

    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity){
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost(){
        return _price * _quantity;
    }

    public string GetDisplayProduct(){
        return $"Id: {_productId}\nName: {_name}\nPrice per unit: {_price}\nQuantity: {_quantity}";
    }

    public string GetName(){
        return _name;
    }

    public int GetId(){
        return _productId;
    }
}