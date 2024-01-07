using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_5
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        public string Størrelse { get; }

        public string Farge { get; }

        public ClothingItem(string størrelse, string farge, string navn, int antall, double pris) : base(navn, antall, pris)
        {
            Størrelse = størrelse;
            Farge = farge;
        }

        public override double PrisKalkulasjon()
        {
            base.PrisKalkulasjon();
            return Antall * Pris;
        }

        public override void PrintItems()
        {
            base.PrintItems();
            Console.WriteLine($"Størrelse: {Størrelse}\n" +
                              $"Farge: {Farge}\n");
        }
    }
}
