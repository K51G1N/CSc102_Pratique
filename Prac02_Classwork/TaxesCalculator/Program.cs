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


        }
    }
}
