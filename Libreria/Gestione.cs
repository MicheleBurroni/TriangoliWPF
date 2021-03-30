using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Libreria
{
    public class Gestione
    {
        public static string RiconosciTriangoli(double lato1, double lato2, double Lato3)
        {
            string risultato = "";
            if (lato1 > 0 && lato2 > 0 && Lato3 > 0)
            {
                if (lato1 == lato2 && lato1 == Lato3)
                {
                    risultato = "Equilatero";
                }
                else if (lato1 != lato2 && lato2 != Lato3 && Lato3 != lato1)
                {
                    risultato = "Scaleno";
                }
                else
                {
                    risultato = "Isoscele";
                }
            }
            else
                risultato = "IMPOSSIBILE";
            return risultato;          
        }
        public static double Perimetro(double lato1, double lato2, double lato3)
        {
            return lato1 + lato2 + lato3;
        }

        public static double Area(double lato1, double lato2, double lato3)
        {
            double semiperimetro = (Perimetro(lato1, lato2, lato3)) / 2;
            return Math.Round((Math.Sqrt(semiperimetro)) * (semiperimetro - lato1) * (semiperimetro - lato2) * (semiperimetro - lato3),2);
        }
    }
}
