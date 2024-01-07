using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_5
{
    internal interface ISellable
    {
        public string Navn { get; }

        public int Antall { get; }

        public double Pris { get; }
        public double PrisKalkulasjon();

        public void PrintItems()
        {
            Console.WriteLine($"Vare: {Navn}\n" +
                              $"Antall: {Antall}\n" +
                              $"Pris: {Pris:C}");
        }
    }
}
