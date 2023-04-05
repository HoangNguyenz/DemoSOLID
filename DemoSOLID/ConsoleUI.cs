using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID
{
    internal class ConsoleUI : IUserInterface
    {
        public double GetNumberFromUser(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToDouble(Console.ReadLine());
        }

        public void ShowResult(double result)
        {
            Console.WriteLine("Result: {0}", result);
        }
    }
}
