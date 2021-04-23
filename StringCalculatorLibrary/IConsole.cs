using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorLibrary
{
    public interface IConsole
    {
        void WriteLine(string sum);
        string ReadLine();
    }
}
