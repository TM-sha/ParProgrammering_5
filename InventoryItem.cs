using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_5
{
    abstract class InventoryItem
    {
        public string Navn { get; }

        public int Antall { get; }

        public double Pris { get; }

        protected InventoryItem(string navn, int antall, double pris)
        {
            Navn = navn;
            Antall = antall;
            Pris = pris;
        }

        public virtual double PrisKalkulasjon()
        {
            var antall = Antall;
            var pris = Pris;
            var totalPris = antall * pris;
            Console.WriteLine($"TotalPris: {totalPris:C},-");
            return Antall * Pris;
        }

        public virtual void PrintItems()
        {
            Console.WriteLine($"Vare: {Navn}\n" +
                              $"Antall: {Antall}\n" +
                              $"Pris: {Pris:C}");
        }
    }
}
