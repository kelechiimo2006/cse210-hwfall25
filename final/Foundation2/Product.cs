public class Product
{
    private string _nameOfProduct;
    private int _productId;
    private int _pricePerUnit;
    private int _quantityOfProduct;
    //private int _totalCost;

    public Product(string nameOfProduct, int productId, int pricePerUnit, int quantityOfProduct)
    {
        _nameOfProduct = nameOfProduct;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantityOfProduct = quantityOfProduct;
    }

    public void SetNameOfProduct(string nameOfProduct)
    {
        _nameOfProduct = nameOfProduct;
    }
    public string GetNameOfProduct()
    {
        return _nameOfProduct;
    }
    public void SetProductId(int productId)
    {
        _productId = productId;
    }
    public int GetProductId()
    {
        return _productId;
    }
    public void SetPricePerUnit(int pricePerUnit)
    {
        _pricePerUnit = pricePerUnit;
    }
    public int GetPricePerUnit()
    {
        return _pricePerUnit;
    }
    public void SetQuantityOfProduct(int quantityOfProduct)
    {
        _quantityOfProduct = quantityOfProduct;
    }
    public int GetQuantityOfProduct()
    {
        return _quantityOfProduct;
    }

}