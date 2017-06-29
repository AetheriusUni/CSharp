using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer1;
            Console.Write("Input your integer: ");
            integer1 = Convert.ToInt32(Console.ReadLine());
            if (integer1 % 2 == 0)
                Console.WriteLine("Your integer is Even.");
            else
                Console.WriteLine("Your integer is Odd.");

        }
    }
}
/*Input your integer: 456
Your integer is Even.
Press any key to continue . . .
 */
/*Input your integer: 321
Your integer is Odd.
Press any key to continue . . .
*/
//The program still works as intended with the use of double.
/*Double Program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            double integer1;
            Console.Write("Input your integer: ");
            integer1 = Convert.ToInt32(Console.ReadLine());
            if (integer1 % 2 == 0)
                Console.WriteLine("Your integer is Even.");
            else
                Console.WriteLine("Your integer is Odd.");

        }
    }
}
*/