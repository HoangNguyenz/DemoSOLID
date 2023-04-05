using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID
{
    public interface IUserInterface
    {
        double GetNumberFromUser(string prompt);
        void ShowResult(double result);
    }
}
