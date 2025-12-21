public class Product
{
    private string _nameOfProduct;
    private int _productId;
    private int _pricePerUnit;
    private int _quantityOfProduct;

    public Product(string nameOfProduct, int productId, int pricePerUnit, int quantityOfProduct)
    {
        _nameOfProduct = nameOfProduct;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantityOfProduct = quantityOfProduct;
    }

    public string GetNameOfProduct()
    {
        return _nameOfProduct;
    }
    public int GetProductId()
    {
        return _productId;
    }
    public int GetPricePerUnit()
    {
        return _pricePerUnit;
    }
    
    public int GetQuantityOfProduct()
    {
        return _quantityOfProduct;
    }

}