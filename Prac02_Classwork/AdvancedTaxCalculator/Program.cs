using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaxCalculator
{
    class Program
    {
        static void Main(string[] args)

        {
            double SalaryTot = 0;          // variable intializers
            int AgeTot = 0;
            int totaltax = 0;
            int taxpayers = 0;
            int nage = 0;
            bool stop = false;
            double nsalary = 0;
            bool check = false;                     // Validation
            while(stop == false) { 
            Console.WriteLine("Enter your age: ");  // User input

            string age = Console.ReadLine();        //Assigns input



            while (check == false)                  //
            {

                if (age.All(char.IsDigit) && age.Length != 0)
                {
                    nage = Convert.ToInt16(age);
                    if (nage >= 20 && nage <= 100)                  // Checks age in [20-100]
                    {
                        Console.WriteLine("Thanks for your age");
                            AgeTot += nage;                                         // HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
                            Console.WriteLine("Age Total: " + AgeTot);
                            taxpayers += 1;
                            Console.WriteLine("Users: " + taxpayers); // HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
                            check = true;
                        
                    }
                    else
                    {
                        Console.WriteLine("Your age is out of bounds. Please re-enter: ");      // Age doesnt fall in range
                        age = Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("Your entry was not valid please Re-enter it:");          // Age is not a number
                    age = Console.ReadLine();
                }

            }


            Console.Write("Enter your monthly salary: ");                       // Name is correct
            string salary = Console.ReadLine();                                 // Takes salary in

            check = false;

            check = Double.TryParse(salary, out nsalary);
            if (check == true) {
                nsalary = Convert.ToDouble(salary);
                SalaryTot += nsalary;
                    Console.WriteLine("The total salary: " + SalaryTot);        // HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE

                }


            while (check == false)                                          // While validity is not verified

            {
                if (check = Double.TryParse(salary, out nsalary))         // Salary is a number
                {
                    nsalary = Convert.ToDouble(salary);
                    if (nsalary < 0)                             // not a negative salary
                    {
                        Console.WriteLine("Your salary entry was invalid please re-enter it: ");
                        salary = Console.ReadLine();

                    }
                    else
                    {
                        check = true;                   // Salary is valid
                        SalaryTot += nsalary;
                    }


                }
                else
                {
                    Console.WriteLine("Your salary entry was invalid please re-enter it: ");
                    salary = Console.ReadLine();
                }

            }
            nsalary = Convert.ToDouble(salary);         // converts salary to double
            Console.ReadLine();
            
            if (nage < 65)                                          // Bracketing for tax due age then income within age
            {
                if (nsalary < 5000)
                {
                    Console.WriteLine("Your taxe payment is 0");
                    totaltax += 0;
                }
                else if (nsalary < 6500)
                {
                    Console.WriteLine("Your taxe payment is 13");
                    totaltax += 13;
                }
                else if (nsalary < 7800)
                {
                    Console.WriteLine("Your taxe payment is 250");
                    totaltax += 250;
                }
                else if (nsalary < 10000)
                {
                    Console.WriteLine("Your taxe payment is 620");
                    totaltax += 620;
                }
                else if (nsalary < 13500)
                {
                    Console.WriteLine("Your taxe payment is 1200");
                    totaltax += 1200;
                }
                else if (nsalary < 17900)
                {
                    Console.WriteLine("Your taxe payment is 2100");
                    totaltax += 2100;
                }
                else if (nsalary < 20000)
                {
                    Console.WriteLine("Your taxe payment is 2700");
                    totaltax += 2700;
                }
                else if (nsalary < 40000)
                {
                    Console.WriteLine("Your taxe payment is 8000");
                    totaltax += 8000;
                }
                else if (nsalary < 60000)
                {
                    Console.WriteLine("Your taxe payment is 16000");
                    totaltax += 16000;
                }
                else if (nsalary >= 60000)
                {
                    Console.WriteLine("Your taxe payment is 20000");
                    totaltax += 20000;
                }
            }
            else if (nage >= 65 && nage <= 75)
            {
                if (nsalary < 5000)
                {
                    Console.WriteLine("Your taxe payment is 0");
                    totaltax += 0;
                }
                else if (nsalary < 6500)
                {
                    Console.WriteLine("Your taxe payment is 0");
                    totaltax += 0;
                }
                else if (nsalary < 7800)
                {
                    Console.WriteLine("Your taxe payment is 0");
                    totaltax += 0;
                }
                else if (nsalary < 10000)
                {
                    Console.WriteLine("Your taxe payment is 0");
                    totaltax += 0;
                }
                else if (nsalary < 13500)
                {
                    Console.WriteLine("Your taxe payment is 600");
                    totaltax += 600;
                }
                else if (nsalary < 17900)
                {
                    Console.WriteLine("Your taxe payment is 1500");
                    totaltax += 1500;
                }
                else if (nsalary < 20000)
                {
                    Console.WriteLine("Your taxe payment is 2000");
                    totaltax += 2000;
                }
                else if (nsalary < 40000)
                {
                    Console.WriteLine("Your taxe payment is 7500");
                    totaltax += 7500;
                }
                else if (nsalary < 60000)
                {
                    Console.WriteLine("Your taxe payment is 15600");
                    totaltax += 15600;
                }
                else if (nsalary >= 60000)
                {
                    Console.WriteLine("Your taxe payment is 17050");
                    totaltax += 17050;
                }

            }
            else
            {
                if (nsalary < 5000)
                {
                    Console.WriteLine("Your taxe payment is 0");
                    totaltax += 0;
                }
                else if (nsalary < 6500)
                {
                    Console.WriteLine("Your taxe payment is 0");
                    totaltax += 0;
                }
                else if (nsalary < 7800)
                {
                    Console.WriteLine("Your taxe payment is 0");
                    totaltax += 0;
                }
                else if (nsalary < 10000)
                {
                    Console.WriteLine("Your taxe payment is 0");
                    totaltax += 0;
                }
                else if (nsalary < 13500)
                {
                    Console.WriteLine("Your taxe payment is 400");
                    totaltax += 400;
                }
                else if (nsalary < 17900)
                {
                    Console.WriteLine("Your taxe payment is 1200");
                    totaltax += 1200;
                }
                else if (nsalary < 20000)
                {
                    Console.WriteLine("Your taxe payment is 1800");
                    totaltax += 1800;
                }
                else if (nsalary < 40000)
                {
                    Console.WriteLine("Your taxe payment is 7300");
                    totaltax += 7300;
                }
                else if (nsalary < 60000)
                {
                    Console.WriteLine("Your taxe payment is 15400");
                    totaltax += 15400;
                }
                else
                {
                    Console.WriteLine("Your taxe payment is 17000");
                    totaltax += 17000;
                }

            }
            Console.WriteLine("Would you like to add another record? : Y/N");
            string ans = Console.ReadLine();

            if(ans == "N")
            {
                stop = true;
            }
                Console.WriteLine("Total Tax is: " + totaltax); // HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
                check = false;
        }
            double AgeAVG = AgeTot / taxpayers;
            double SalaryAVG = System.Math.Round((SalaryTot / taxpayers), 2);
            double TaxAvg = totaltax / taxpayers;
            Console.WriteLine();
            Console.WriteLine("The average age of taxpayers is: " + AgeAVG);
            Console.WriteLine("The average monthly salary of taxpayers is: " + SalaryAVG);
            Console.WriteLine("The average tax payment is: " + TaxAvg);


                
            }
        }
    }

