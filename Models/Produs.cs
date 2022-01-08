using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazin.Models
{
    public class Produs
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public decimal Gramaj { get; set; }
        public decimal Pret { get; set; }
    }
}
