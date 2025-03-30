public class Order
{
    // attributes
    private List<Product> _products;
    private Customer _customer;

    // constructor
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    // getters
    private string GetName()
    {
        return _customer.GetCustomerName();
    }

    private string GetAddress()
    {
        return _customer.GetAddress();
    }

    private bool GetCustomerLocation()
    {
        // check if customer lives in US
        return _customer.LivesInUSA();
    }

    private int GetShippingCost()
    {
        // If the customer lives in the USA, then the shipping cost is $5 else $35.
        return GetCustomerLocation() ? 5 : 35;
    }

    // methods
    // calculate total cost of order
    public double CalculateTotalOrder()
    {
        double totalAmount = 0;

        foreach (Product product in _products)
        {
            totalAmount += product.GetProductTotal();
        }

        // add one time shipping fee
        return totalAmount + GetShippingCost();
    }

    // list name and product ID of each product
    public string GetPackingLabel()
    {
        string packingLabel = "PRODUCTS PACKING LABEL:\n";
        // loop through each product and get the name and ID
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductId()} - {product.GetProductName()}\n";
        }

        return packingLabel;
    }
    // list the name and address of customer
    public string GetShippingLabel()
    {
        return $"Customer Name: {GetName()}\nCustomer Address: {GetAddress()}";
    }

}