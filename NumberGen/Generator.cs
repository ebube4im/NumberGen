using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGen
{
    internal class  Generator
    {

        List<int> GeneratedNumbers = new List<int>();
        int number;
        Random randomNumber = new Random(1);

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Enter G to Generate and Y to exit!");

                string Input = Console.ReadLine().ToString();

                switch (Input.ToUpper())
                {
                    case "G":
                        Console.WriteLine(Generate());
                        break;
                    case "Y":
                        return;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }

        int Generate()
        {
                
          
            number = randomNumber.Next(1,27);
            if (!GeneratedNumbers.Contains(number))
            {
                GeneratedNumbers.Add(number);
                return number;
            }
            else
            {
                return Generate();
            }

           // return 0;


        }
    }
}
