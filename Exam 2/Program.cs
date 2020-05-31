// Grdading Id
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            


            string[] counties = { "Jefferson" , "Clark", "Floyd", "Harrison", "Bullitt",
                "Shelby", "Nelson", "Oldham", "Spencer", "Meade" };
            int[] infections = { 249, 49, 34, 18, 6, 5, 4, 4, 4, 1 };

            string userinput;
            bool found = false;
            double infected = 0;
            int index = counties.Length;

            Write("Enter name of county: ");
            userinput = ReadLine();

            
            for (int a=0; a < index && !found; ++a)
            {
                if (userinput == counties[a])
                    found = true;

                infected = infections[a];
            }
            if (found)
            
               
                WriteLine($"There are {infected} known cases in {userinput} County");
            
            else 
            WriteLine($"Sorry, no data for {userinput} County");



        }
    }
}
