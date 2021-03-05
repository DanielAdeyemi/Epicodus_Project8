using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Description { get; set; }
    public string Title { get; set; }
    public int Id { get; }
    public decimal Price { get; set; }

    public string Date { get; set; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, string date, decimal price)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return null;
    }
  }
}