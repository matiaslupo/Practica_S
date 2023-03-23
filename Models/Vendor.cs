namespace Practica_S.Models;

public class Vendor
{
    public string Name { get; set; } = string.Empty; 

    public Vendor(string name)
    {
        Name = name;
    }

    public string Sell(ISale sale)
    {
        return $"El vendedor {Name} vendio {sale.PastryAmount} {sale.GetPastry()} por un total de {sale.Total()}.";
    }
}
