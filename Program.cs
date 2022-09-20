using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung_Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Wurzel(0.5));
        }

        static double Wurzel(double zahl)
        {
            double untereGrenze = 1;
            double obereGrenze = zahl;
            double result;
            double middle = mitte(zahl, obereGrenze, untereGrenze);
            while(middle*middle != zahl)
            {
                if(mitte(zahl, obereGrenze, untereGrenze) < zahl)
                {
                    untereGrenze = mitte(zahl, obereGrenze, untereGrenze);
                    middle = mitte(zahl, obereGrenze, untereGrenze);
                }
            }
            //Console.WriteLine("oG = " + obereGrenze);
            //Console.WriteLine("uG = " + untereGrenze);
            //Console.WriteLine("mitte = " + mitte);
            result = middle;
            return result;

        }
        static double mitte(double zahl, double obereGrenze, double untereGrenze)
        {
            double mitte = (obereGrenze + untereGrenze) / 2;
            return mitte;
        
            double result;
            mitte = (obereGrenze + untereGrenze) / 2;
            if (mitte * mitte == zahl)
            {
                return mitte;
                
            }

            else
            {
                if (mitte * mitte < zahl)
                {
                    untereGrenze = mitte;
                }
                else
                {
                    obereGrenze = mitte;
                }
            }
        }

    }
}
