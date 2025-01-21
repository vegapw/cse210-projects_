public class Customer{

    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool LiveInUSA(){
        return _address.IsInUSA();
    }

    public string GetDisplayCustomer(){
        return $"Name: {_name}\nAddress:\n{_address.GetDisplayAddress()}";
    }
}