using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_5
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        public string Forsikring { get; set; }

        public string Spenning { get; set; }

        public ElectronicItem(string navn, int antall, double pris, string forsikring, string spenning) : base(navn, antall, pris)
        {
            Forsikring = forsikring;
            Spenning = spenning;
        }
        public double PrisKalkulasjon()
        {
            var antall = Antall;
            var pris = Pris;
            var totalPris = antall * pris;
            Console.WriteLine($"TotalPris: {totalPris:C},-");
            return Antall * Pris;
        }

        public override void PrintItems()
        {
            base.PrintItems();
            Console.WriteLine($"Forsikring: {Forsikring} mnd\n" +
                              $"Spenning: {Spenning} watt\n");
        }
    }
}
