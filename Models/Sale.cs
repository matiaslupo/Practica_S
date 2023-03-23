namespace Practica_S.Models;

public class Sale : ISale
{
    private readonly Pastry _pastry;
    public int PastryAmount { get; set; }

    public Sale(Pastry pastry, int amount)
    {
        _pastry = pastry;
        PastryAmount = amount;
    }

    public double Total()
    {
        return _pastry.Price * PastryAmount;
    }

    public string GetPastry()
    {
        return _pastry.Name;
    }
}
