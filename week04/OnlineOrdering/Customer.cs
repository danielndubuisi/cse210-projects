public class Customer
{
    // attributes
    private string _customerName;
    private Address _customerAddress;

    // constructor
    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    // getters
    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return _customerAddress.DisplayFullAddress();
    }

    private bool GetCustomerUSResidency()
    {
        // checks if customer resides in the US
        return _customerAddress.IsUSResident();
    }

    // method
    public bool LivesInUSA()
    {
        return GetCustomerUSResidency();
    }
}