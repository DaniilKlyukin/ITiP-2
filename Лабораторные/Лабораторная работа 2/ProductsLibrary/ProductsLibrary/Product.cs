namespace ProductsLibrary;

// Класс для представления продукта
public class Product : ICloneable, IEquatable<Product>
{
    public string ProductID { get; private set; }
    public string Name { get; private set; }
    public double Price { get; private set; }
    public int StockQuantity { get; private set; }

    public Product(string productId, string name, double price, int stockQuantity)
    {
        ProductID = productId;
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public void AddStock(int quantity)
    {
        StockQuantity += quantity;
    }

    public bool RemoveStock(int quantity)
    {
        if (StockQuantity >= quantity)
        {
            StockQuantity -= quantity;
            return true;
        }
        else
        {
            return false;
        }
    }

    public double CalculateTotalPrice(int quantity)
    {
        return Price * quantity;
    }

    public string GetProductSummary()
    {
        return $"{Name} (ID: {ProductID}) - Цена: {Price}, Остаток: {StockQuantity}";
    }

    public override string ToString()
    {
        return GetProductSummary();
    }

    public object Clone()
    {
        return MemberwiseClone();
    }

    public bool Equals(Product? other)
    {
        if (other == null)
            return false;

        return other.ProductID == ProductID;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Product);
    }

    public override int GetHashCode()
    {
        return ProductID.GetHashCode();
    }
}
