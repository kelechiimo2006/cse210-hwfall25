public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetProducts(List<Product> products)
    {
        _products = products;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }

    public int CalculateTotalCost()
    {
        int shippingCost;
        int productTotalCost = 0;
        if (_customer.InUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        foreach (Product product in _products)
        {
            productTotalCost += product.GetPricePerUnit() * product.GetQuantityOfProduct();
        }
        return productTotalCost + shippingCost;
    }
    public void DipslayPackingLabel()
    {
        foreach (Product product in _products)
        {
            string packingLabel = $"Product ID: {product.GetProductId()}, Product Name: {product.GetNameOfProduct()}";
            Console.WriteLine(packingLabel);
        }
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().DisplayAddress());
    }
}