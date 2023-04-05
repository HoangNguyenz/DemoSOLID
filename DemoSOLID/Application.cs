using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID
{
    //demo
    public class Application
    {
        private readonly ICalculator _calculator;
        private readonly IUserInterface _userInterface;

        public Application(ICalculator calculator, IUserInterface userInterface)
        {
            _calculator = calculator;
            _userInterface = userInterface;
        }

        public void Run()
        {
            double a = _userInterface.GetNumberFromUser("Nhap so thu nhat: ");
            double b = _userInterface.GetNumberFromUser("Nhap so thu hai: ");
            double result = _calculator.Add(a, b);
            Console.WriteLine($"Tong cua hai so la: {result}");
            Console.ReadLine();
        }
    }
}
