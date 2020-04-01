using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Blasciuc_Gabriele_3124a
{
    class Racheta
    {
        public string Model {set;get;}
        public double CapacitateTone { set; get; }
        public double SarcinaUtilTone { set; get; }

        public enum TipCombustibil
        {
            LOX=1,
            solid=2,
            hidrazina=3,
        };
        public TipCombustibil Combustibil { set; get; }

        public Racheta()
        {
            Model = string.Empty;
            CapacitateTone = SarcinaUtilTone = 0;
        }
        public Racheta(string _model,double capacitate, double sarcina)
        {
            Model = _model;
            CapacitateTone = capacitate;
            SarcinaUtilTone = sarcina;
        }
        public Racheta(int nr)
        {
            Console.Write("Introduceti modelul: ");
            Model = Console.ReadLine();
            Console.Write("Introduceti Capacitatea in tone: ");
            CapacitateTone = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduceti Sarcina in tone: ");
            SarcinaUtilTone = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduceti tipul de combustibil:\n1. LOX\n2. solid\n3. hidrazina\n");
            Combustibil = (TipCombustibil)Enum.Parse(typeof(TipCombustibil), Console.ReadLine());
        }
        
        public string ConversieLaSir()
        {
            return String.Format(Model + "\t" + CapacitateTone + "\t" + SarcinaUtilTone + "\t" + Combustibil);
        }
        public double CalculRaport()
        {
            return SarcinaUtilTone / CapacitateTone;
        }
        ~Racheta()
        {
            //destructor
        }
    }
}
