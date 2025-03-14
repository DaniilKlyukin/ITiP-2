﻿using System.Collections;

namespace ProductsLibrary;

// Класс для представления заказа
public class Order : ICloneable, IEquatable<Order>, IEnumerable<Product>
{
    public string OrderID { get; private set; }
    public Customer Customer { get; private set; }
    public IReadOnlyList<Product> Products => products.AsReadOnly();
    public DateTime OrderDate { get; private set; }
    public OrderStatus Status { get; private set; }

    private List<Product> products;

    public Order(string orderId, Customer customer)
    {
        OrderID = orderId;
        Customer = customer;
        products = new List<Product>();
        OrderDate = DateTime.Now;
        Status = OrderStatus.Processing;
    }

    public bool AddProduct(Product product)
    {
        if (product.RemoveStock(1)) // Уменьшаем количе-ство товара на складе
        {
            products.Add(product);
            return true;
        }
        return false;
    }

    public void UpdateStatus(OrderStatus status)
    {
        Status = status;
    }

    public double CalculateTotalOrderValue()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.Price; // Предполагаем, что количество каждого продукта в заказе равно 1
        }
        return total;
    }

    public string GetOrderSummary()
    {
        string productDetails = string.Join(", ", products.ConvertAll(p => p.GetProductSummary()));
        return $"Заказ ID: {OrderID}, " +
            $"Клиент: {Customer.Name}, " +
            $"Товары: {productDetails}, " +
            $"Дата: {OrderDate}, " +
            $"Статус: {Status}, " +
            $"Общая сумма: {CalculateTotalOrderValue()}";
    }

    public override string ToString()
    {
        return GetOrderSummary();
    }

    public object Clone()
    {
        var order = new Order(OrderID, (Customer)Customer.Clone());

        var products = new List<Product>();

        foreach (var product in Products)
        {
            order.AddProduct((Product)product.Clone());
        }

        order.OrderDate = OrderDate;
        order.Status = Status;

        return order;
    }

    public bool Equals(Order? other)
    {
        if (other == null)
            return false;

        return other.OrderID == OrderID;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Order);
    }

    public override int GetHashCode()
    {
        return OrderID.GetHashCode();
    }

    public IEnumerator<Product> GetEnumerator()
    {
        return Products.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)Products).GetEnumerator();
    }
}
