using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig piggie = new Pig(116);
            Console.WriteLine(piggie.ToString());

            Cow Cowie = new Cow(225);
            Console.WriteLine(Cowie.ToString());

            Snake Snakie = new Snake(25);
            Console.WriteLine(Snakie.ToString());
        }
    }
}
