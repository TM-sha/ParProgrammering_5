using System.Data.SqlTypes;

namespace ParProgrammering_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Init();
        }

        private static void Init()
        {
            var clothingItem = new ClothingItem("XL", "Brun", "Bukse", 8, 499);
            var clothingItem1 = new ClothingItem("L", "Gul", "Genser", 1, 499);

            var electronicItem = new ElectronicItem("Fryser", 4, 3599, "Skadeforsikring 12", "240");
            var electronicItem1 = new ElectronicItem("Kjøleskap", 1, 4699, "Skadeforsikring 22", "250");

            PrintAll(clothingItem, clothingItem1, electronicItem, electronicItem1);
        }

        private static void PrintAll(ClothingItem clothingItem, ClothingItem clothingItem1, ElectronicItem electronicItem,
            ElectronicItem electronicItem1)
        {
            ConsolePrintItem(clothingItem);

            ConsolePrintItem(clothingItem1);

            ConsolePrintItem(electronicItem);

            ConsolePrintItem(electronicItem1);
        }

        private static void ConsolePrintItem(ISellable item) //Fikk hjelp med DRY Prinsipp /Interface av Johnny på teamet
        {
            item.PrintItems();
            Console.WriteLine();
            item.PrisKalkulasjon();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
//Lag en base klasse som heter “InventoryItem” hvor du har info om itemets navn, antall og pris.
//Lag to klasser til, ClothingItem og ElectronicItem. Disse skal ha informasjon om størrelse og farge f.eks på klær og f.eks forsikringsinformasjon og spenning på det elektriske.
//La disse klassene arve av baseklassen, slik at de også får bruke navn, antall og pris.


//Lag et interface ISellable som har en funksjon som kalkulerer pris.
//Implementer dette interfacet i ClothingItem og ElectronicItem


//Lag noen forskjellige items for å sjekke at det fungerer som tenkt.