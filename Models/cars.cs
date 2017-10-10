using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private string _make;
    private int _price;
    private int _miles;

    private static List<string> _instances = new List<string> {};

    public Car (string make, int price, int miles)
    {
      _make = make;
      _price = price;
      _miles = miles;
    }
    public string GetMake()
    {
      return _make;
    }
    public void SetMake(string newMake)
    {
      _make = newMake;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(_make+ " "+_price+" "+_miles);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
