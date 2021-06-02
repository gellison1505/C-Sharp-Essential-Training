using System;

public class SaleItem
{
  string _name;
  decimal _cost;

  public SaleItem(string name, decimal cost)
  {
    _name = name;
    _cost = cost;
  }

  public string Name
  {
    get => _name;   //this is async expression bodied property
    set => _name = value; //so is this
  }

  public decimal Price
  {
    get => _cost;   // and this
    set => _cost = value; // and this
  }
}

class Program
{
  static void Main(string[] args)
  {
    var item = new SaleItem("Shoes", 19.95m);
    Console.WriteLine($"{item.Name}: sells for {item.Price:C3}");
  }
}
// The example displays output like the following:
//       Shoes: sells for $19.95