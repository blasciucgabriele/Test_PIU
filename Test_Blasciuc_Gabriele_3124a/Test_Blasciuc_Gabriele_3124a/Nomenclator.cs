using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Blasciuc_Gabriele_3124a
{
    class Nomenclator
    {
        Racheta[] rachete = new Racheta[20];
        public int nr_rachete = 0;
        public const double MINIM = 0;
        public const double MAXIM = 50000;



        public bool isEmpty()
        {
            return nr_rachete == 0 ? true : false;
        }
        public bool isFull()
        {
            return nr_rachete == 20 ? true : false;
        }
        public void adaugare_tastatura()
        {
            int nr = 0;
            if (!isFull())
            {
                rachete[nr_rachete] = new Racheta(nr);
                if (rachete[nr_rachete].CapacitateTone > MINIM && rachete[nr_rachete].CapacitateTone < MAXIM && rachete[nr_rachete].SarcinaUtilTone > MINIM && rachete[nr_rachete].SarcinaUtilTone < MAXIM)
                    nr_rachete++;
                else Console.WriteLine("Date incorecte!");
            }
            else Console.WriteLine("Baza de date este plina!");
        }
        public void afisare_rachete()
        {
            if (!isEmpty())
            {
                for (int i = 0; i < nr_rachete; i++)
                {
                    Console.WriteLine(rachete[i].ConversieLaSir());
                }
            }
            else Console.WriteLine("Nu exista rachete!");
        }

        public void afisare_raport()
        {
            if (!isEmpty())
            {
                Console.WriteLine("RAPORTURI SarcinaUtilTone/CapacitateTone");
                for (int i = 0; i < nr_rachete; i++)
                {
                    Console.WriteLine(Convert.ToString(i + 1) +".\t"+rachete[i].CalculRaport());
                }
            }
            else Console.WriteLine("Nu exista rachete!");
        }
        public void afisare_tip_combustibil()
        {
            Console.Write("Introduceti modelul: ");
            string _model = Console.ReadLine();
            for (int i = 0; i < nr_rachete; i++)
            {
                if (String.Compare(rachete[i].Model, _model) == 0)
                {
                    Console.WriteLine("Modelul {0} are tipul de combustibil: {1}", rachete[i].Model, rachete[i].Combustibil);
                }
            }
        }
    }
}
