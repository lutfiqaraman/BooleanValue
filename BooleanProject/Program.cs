using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooleanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? stringtoboolean = null;

            Console.WriteLine("Please enter a value");

            string inputvalue = Console.ReadLine();
            string[] inputoptions = { "", "0", "1" };

            bool notinthearray = inputoptions.Contains(inputvalue);

            if (inputvalue.Length > 1 || (notinthearray == false))
                Console.WriteLine("Please only 0 or 1 is allowed");

            switch (inputvalue)
            {
                case "":
                    stringtoboolean = null;
                    break;

                case "0":
                    stringtoboolean = false;
                    break;

                case "1":
                    stringtoboolean = true;
                    break;
            }
            
            if (stringtoboolean.HasValue)
                Console.WriteLine(stringtoboolean.Value);
            else
                Console.WriteLine("Null");

            Console.ReadKey();
        }
    }
}