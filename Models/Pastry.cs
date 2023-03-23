namespace Practica_S.Models;

public class Pastry
{
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; } 

    public Pastry(string name, double price)
    {
        Name = name;
        Price = price;
    }

}
