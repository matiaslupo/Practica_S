namespace Practica_S.Interfaces
{
    public interface ISale
    {
        public int PastryAmount { get; set; }
        public double Total();

        public string GetPastry();
    }
}