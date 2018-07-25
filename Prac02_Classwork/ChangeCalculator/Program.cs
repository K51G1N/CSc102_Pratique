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
            Console.WriteLine("Please enter an amount: ");              //user input
            string cash = Console.ReadLine();
            
            bool money = Double.TryParse(cash, out Double dcash);       //input validation check
            if(money == true)
            {
                Console.WriteLine("great input!!");                     //user feedback

            }
            else {
                Console.WriteLine("It makes no sense!!");               //rejection
            }
            int[] Currency = new int[] { 200, 100, 50, 20, 10, 5, 2, 1, 50, 20, 10, 5, 2, 1 }; //Currency

            double rands = System.Math.Floor(dcash);                    //Obtains the rand
            double cents = dcash - rands;                               //Calculates the cents
            cents = System.Math.Round(cents, 3);
            cents = System.Math.Floor(cents * 100);                     //Takes first two cent digits
            int cent = Convert.ToInt16(cents);                          // conversion to int
            int rand = Convert.ToInt32(rands);                          // conversion to int
            int i = 0;                                                  // variable declaration
            string item = "note";
            int nrn = 0;
            int ncn = 0;
            while (rand != 0)                               //While there are still rands to be calculated
            {
                 
                nrn = rand / Currency[i];                   // Notes needed
                rand = rand - nrn * Currency[i];            // diminish rands
                if (i > 4)                                  // after fourth value only coins remain in currency spectrum
                {
                     item = "coin";                         // set currency item to coin
                }
                if(nrn != 0)                                // only if there is currency needed will it display it
                {
                    Console.WriteLine("Return " + nrn + " x R" + Currency[i] + " " + item + "(s)");
                    
                }
                i++;        // increment i 
            }
            i = 8;
            while(cent != 0)                        // cents still need processing
            {
                
                ncn = cent / Currency[i];
                cent = cent - ncn * Currency[i];
                if(ncn != 0)
                {
                    Console.WriteLine("Return " + ncn + " x " + Currency[i] + "c" + " " + item + "(s)");
                }
                
                i++;
            }

            
            
            

          
            
        }
    }
}
