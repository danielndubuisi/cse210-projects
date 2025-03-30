public class Product
{
    // attributes
    private string _productName;
    private string _productId;
    private double _productPrice;
    private int _productQuantity;

    // constructor
    public Product(string productName, string productId, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    // getters
    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    private double GetPrice()
    {
        return _productPrice;
    }

    private int GetQuantity()
    {
        return _productQuantity;
    }

    // method
    public double GetProductTotal()
    {
        double price = GetPrice();
        int quantity = GetQuantity();
        return price * quantity;
    }
}