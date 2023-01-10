using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazioni
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fractions f = new Fractions(24,60);
            f.Semplifica();
            Console.WriteLine(f.getFrazione());
            
            
        }
    }
}
