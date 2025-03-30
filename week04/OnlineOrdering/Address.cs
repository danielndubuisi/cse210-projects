public class Address
{
    // attributes
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    
    // getters
    private string GetStreet()
    {
        return _street;
    }
    private string GetCity()
    {
        return _city;
    }
    private string GetState()
    {
        return _state;
    }
    private string GetCountry()
    {
        return _country;
    }

    // methods
    public string DisplayFullAddress()
    {
        string street = GetStreet();
        string city = GetCity();
        string state = GetState();
        string country = GetCountry();

        // format and return the full address
        return $"{street}, {city}, {state}, {country}";
    }

    public bool IsUSResident()
    {
        // Check if the address is in the US
        return GetCountry().ToLower() == "usa" ? true : false;
    }
}