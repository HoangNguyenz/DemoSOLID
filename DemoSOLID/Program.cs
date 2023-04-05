using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DemoSOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();
            IUserInterface userInterface = new ConsoleUI();
            Application application = new Application(calculator, userInterface);
            application.Run();
        }
    }
}
