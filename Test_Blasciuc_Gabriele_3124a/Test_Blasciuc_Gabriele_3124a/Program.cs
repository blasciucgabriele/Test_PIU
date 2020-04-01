using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Blasciuc_Gabriele_3124a
{
    class Program
    {
        static void Main(string[] args)
        {
            Nomenclator nom = new Nomenclator();
            do
            {
                Console.Clear();
                Console.WriteLine("A-adaugare racheta\nL-afisare date despre rachete\nC-afisare raport calculat\nT-afisare tip combustibil(necesar model)\nI-info autor\nX-exit");
                Console.Write("Introduceti o optiune: ");
                string opt = Console.ReadLine();
                switch (opt)
                {
                    case "A":
                        Console.Clear();
                        nom.adaugare_tastatura();
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case "L":
                        Console.Clear();
                        nom.afisare_rachete();
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case "C":
                        Console.Clear();
                        nom.afisare_raport();
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case "T":
                        Console.Clear();
                        nom.afisare_tip_combustibil();
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case "I":
                        Console.Clear();
                        Console.WriteLine("Blasciuc Gabriele-Andrea, 3124a");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                    case "X":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorect!");
                        Console.ReadKey();
                        break;
                }
            } while (true);
        }
    }
}
