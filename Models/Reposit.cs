using Practica_S.Interfaces;
using System;
namespace Practica_S.Models;

public class Reposit : IReposit
{
    private static int s_idGen = 0;
    public int Id { get ; set ; }
    public DateTime Date { get; set; }
    public Repositor Repositor { get; set; }

    public Reposit(Repositor repositor)
    {
        Id = ++s_idGen; 
        Date = DateTime.Now;
        Repositor = repositor;
    }
    public string RepositData()
    {
        return $"Se hizo una reposicion el dia {Date.ToShortDateString()} por {Repositor.Name}";
    }
}
