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
            Console.WriteLine(Wurzel(2));
        }

        static double Wurzel(double zahl)
        {
            double untereGrenze = 1;
            double obereGrenze = 2;
            double result;
            double mitte = (obereGrenze + untereGrenze) / 2;
            for(int k = 0; k < 100; k++)
            {
                mitte = (obereGrenze + untereGrenze) / 2;
                if (mitte*mitte == 2)
                {
                    result = mitte;
                    break;
                }

                else
                {
                    if(mitte*mitte < 2)
                    {
                        untereGrenze = mitte;
                    }
                    else
                    {
                        obereGrenze = mitte;
                    }
                }

            }
            Console.WriteLine("oG = " + obereGrenze);
            Console.WriteLine("uG = " + untereGrenze);
            Console.WriteLine("mitte = " + mitte);
            result = mitte;
            return result;

        }

    }
}
