using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_5
{
    internal class InventoryItem
    {
        public string Navn { get; set; }

        public int Antall { get; set; }

        public double Pris { get; set; }

        protected InventoryItem(string navn, int antall, double pris)
        {
            Navn = navn;
            Antall = antall;
            Pris = pris;
        }

        public virtual void PrintItems()
        {
            Console.WriteLine($"Vare: {Navn}\n" +
                              $"Antall: {Antall}\n" +
                              $"Pris: {Pris:C}");
        }
    }
}
