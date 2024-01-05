using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_5
{
    internal interface ISellable
    {
        public string Navn { get; set; }

        public int Antall { get; set; }

        public double Pris { get; set; }
        public double PrisKalkulasjon();

        public void PrintItems()
        {
            Console.WriteLine($"Vare: {Navn}\n" +
                              $"Antall: {Antall}\n" +
                              $"Pris: {Pris:C}");
        }
    }
}
