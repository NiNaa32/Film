using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    class Filmen
    {
        private string titel;
        private double kostnader;
        private string skådespelare;
        private double sponsring;

        public string GetSetTitel
        {
            set { titel = value; }
            get { return titel; }
        }

        public double GetSetKostnader
        {
            set { kostnader = value; }
            get { return kostnader; }
        }

        public string GetSetSkådespelare
        {
            set { skådespelare = value; }
            get { return skådespelare; }
        }

        public double GetSetSponsring
        {
            set { sponsring = value; }
            get { return sponsring; }
        }

        public Filmen()
        {
            titel = "";
            skådespelare = "";
            kostnader = 0.0;
            sponsring = 0.0;
        }

        public Filmen(string t, string s, double k, double sp)
        {
            titel = t;
            skådespelare = s;
            kostnader = k;
            sponsring = sp;
        }
        public double Beräkna(Filmen f, int antTittare, double biljettpris)
        {
            double feeFilm;
            feeFilm = (double)biljettpris * antTittare + f.GetSetSponsring - f.GetSetKostnader;
            return feeFilm;
        }

        public double FeeS(double feeFilm)
        {
            double feeS;
            feeS = feeFilm * 0.05;
            return feeS;
        }
        static void Registrering(Filmen f)
        {
            Console.WriteLine("Filmtitel: ");
            f.GetSetTitel = Console.ReadLine();
            Console.WriteLine("Filmkostnad: ");
            f.GetSetKostnader = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Huvudskådespelarens namn: ");
            f.GetSetSkådespelare = Console.ReadLine();
            Console.WriteLine("Sponsorskap: ");
            f.GetSetSponsring = Convert.ToDouble(Console.ReadLine());
        }

    }

}
