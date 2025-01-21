public class Address{

    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country){
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA(){
        return _country.Equals("USA") ? true : false;
    }

    public string GetDisplayAddress(){
        return $"Street: {_street}\nCity: {_city}\nState/Province: {_stateProvince}\nCountry: {_country}";
    }
}