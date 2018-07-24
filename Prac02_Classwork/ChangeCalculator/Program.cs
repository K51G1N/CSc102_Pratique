using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an amount: ");
            string cash = Console.ReadLine();
            
            bool money = Double.TryParse(cash, out Double dcash);
            if(money == true)
            {
                Console.WriteLine("great input!!");

            }
            else {
                Console.WriteLine("It makes no sense!!");
            }
            int[] Currency = new int[] { 200, 100, 50, 20, 10, 5, 2, 1, 50, 20, 10, 5, 2, 1 };

            double rands = System.Math.Floor(dcash);
            double cents = dcash - rands;

            cents = System.Math.Floor(cents * 100);
            int cent = Convert.ToInt16(cents);
            int rand = Convert.ToInt32(rands);
            int i = 0;
            string item = "note";
            int nrn = 0;
            int ncn = 0;
            while (rand != 0)
            {
                 nrn = rand % Currency[i];
                rand = rand - nrn * Currency[i];
                if (i > 4)
                {
                     item = "coin";
                }
                Console.WriteLine("Return " + nrn + " x R" + Currency[i] + " " + item + "(s)");
                i++;
            }
            while(cent != 0)
            {
                ncn = cent % Currency[i];
                cent = cent - ncn * Currency[i];
                Console.WriteLine("Return " + ncn + " x R" + Currency[i] + " " + item + "(s)");
                i++;
            }
            

          
            
        }
    }
}
