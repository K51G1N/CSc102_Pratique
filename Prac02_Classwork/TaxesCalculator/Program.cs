using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            bool check = false;

            while (check == false) { 
            if (age.All(char.IsDigit) && age.Length != 0){
                Console.WriteLine("Thanks for your age");
                    check = true;
            }
            else
            {
                    Console.WriteLine("Your entry was not valid please Re-enter it:");
                    age = Console.ReadLine();
            }
            }
            int nage = Convert.ToInt16(age);
            Console.Write("Enter your monthly salary: ");
            string salary = Console.ReadLine();

            check = false;

            while (check == false) {
            if(salary.All(char.IsDigit) && salary.Length !=0){
                    Console.Write("Thank you for entering your salary!");
                    check = true;
                }
                else
                {
                    Console.WriteLine("Your salary entry was invalid please re-enter it: ");
                    salary = Console.ReadLine();
                }
                
            }
            int nsalary = Convert.ToInt32(salary);
            Console.ReadLine();

            if (nage < 65)
            {
                if (nsalary < 5000)
                {
                    Console.WriteLine("Your taxe payment is 0");
                }
                else if (nsalary < 6500)
                {
                    Console.WriteLine("Your taxe payment is 13");
                }
                else if (nsalary < 7800)
                {
                    Console.WriteLine("Your taxe payment is 250");
                }
                else if (nsalary < 10000)
                {
                    Console.WriteLine("Your taxe payment is 620");
                }
                else if (nsalary < 13500)
                {
                    Console.WriteLine("Your taxe payment is 1200");
                }
                else if (nsalary < 17900)
                {
                    Console.WriteLine("Your taxe payment is 2100");
                }
                else if (nsalary < 20000)
                {
                    Console.WriteLine("Your taxe payment is 2700");
                }
                else if (nsalary < 40000)
                {
                    Console.WriteLine("Your taxe payment is 8000");
                }
                else if (nsalary < 60000)
                {
                    Console.WriteLine("Your taxe payment is 16000");
                }
                else if (nsalary >= 60000)
                {
                    Console.WriteLine("Your taxe payment is 20000");
                }
            }
            else if (nage >= 65 && nage <= 75)
            {
                if (nsalary < 5000)
                {
                    Console.WriteLine("Your taxe payment is 0");
                }
                else if (nsalary < 6500)
                {
                    Console.WriteLine("Your taxe payment is 0");
                }
                else if (nsalary < 7800)
                {
                    Console.WriteLine("Your taxe payment is 0");
                }
                else if (nsalary < 10000)
                {
                    Console.WriteLine("Your taxe payment is 0");
                }
                else if (nsalary < 13500)
                {
                    Console.WriteLine("Your taxe payment is 600");
                }
                else if (nsalary < 17900)
                {
                    Console.WriteLine("Your taxe payment is 1500");
                }
                else if (nsalary < 20000)
                {
                    Console.WriteLine("Your taxe payment is 2000");
                }
                else if (nsalary < 40000)
                {
                    Console.WriteLine("Your taxe payment is 7500");
                }
                else if (nsalary < 60000)
                {
                    Console.WriteLine("Your taxe payment is 15600");
                }
                else if (nsalary >= 60000)
                {
                    Console.WriteLine("Your taxe payment is 17050");
                }

            }
            else if(nage > 75)
            {
                if (nsalary < 5000)
                {
                    Console.WriteLine("Your taxe payment is 0");
                }
                else if (nsalary < 6500)
                {
                    Console.WriteLine("Your taxe payment is 0");
                }
                else if (nsalary < 7800)
                {
                    Console.WriteLine("Your taxe payment is 0");
                }
                else if (nsalary < 10000)
                {
                    Console.WriteLine("Your taxe payment is 0");
                }
                else if (nsalary < 13500)
                {
                    Console.WriteLine("Your taxe payment is 400");
                }
                else if (nsalary < 17900)
                {
                    Console.WriteLine("Your taxe payment is 1200");
                }
                else if (nsalary < 20000)
                {
                    Console.WriteLine("Your taxe payment is 1800");
                }
                else if (nsalary < 40000)
                {
                    Console.WriteLine("Your taxe payment is 7300");
                }
                else if (nsalary < 60000)
                {
                    Console.WriteLine("Your taxe payment is 15400");
                }
                else if (nsalary >= 60000)
                {
                    Console.WriteLine("Your taxe payment is 17000");
                }
            }
        }
    }
}
