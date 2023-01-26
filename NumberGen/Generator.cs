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
        int number, minNum, maxNum;
        Random randomNumber = new Random(1);

        public void Run()
        {
            Console.WriteLine("Please enter the minimum whole number to be generated");
             int.TryParse(Console.ReadLine(), out minNum);

            Console.WriteLine("Please enter the maximum whole number to be generated");
            int.TryParse(Console.ReadLine(), out maxNum);

            while (true)
            {
                Console.WriteLine("Enter G to Generate and Y to exit!");

                string Input = Console.ReadLine().ToString();

                switch (Input.ToUpper())
                {
                    case "G":
                        Console.WriteLine(Generate(minNum, maxNum));
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

        int Generate(int minNum, int maxNum)
        {

            while (true)
            {
                number = randomNumber.Next(1, 27);
                if (!GeneratedNumbers.Contains(number))
                {
                    GeneratedNumbers.Add(number);
                    return number;
                }
            }
          
           
            

           // return 0;


        }
    }
}
