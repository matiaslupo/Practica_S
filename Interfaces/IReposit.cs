using Practica_S.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_S.Interfaces
{
    public interface IReposit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Repositor Repositor { get; set; }
        public string RepositData();
    }
}
