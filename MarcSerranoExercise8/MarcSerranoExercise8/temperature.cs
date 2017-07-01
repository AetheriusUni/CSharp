using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MarcSerranoExercise8
{
    class Temperature
    {
        char scale;
        double degree;
        public void GetData()
        {
            Console.Write("\n Please enter the room temprature:");
            degree = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Please enter the scale you used for room temperature:");
            scale = Convert.ToChar(Console.Read());
        }
        public void DisplayDegree()
        {
            Console.WriteLine("\n The room temperature is {0} {1}\n", degree, scale);
        }
    }
}

/*
 * UML = Uniform Modeling Language
Temperature
char scale; double degree;
void GetData(); void DisplayDegree();
*/

/*
if we change the data members to be public, we can:
Temperature room = new Temperature();
room.GetData();
Console.WriteLine("\n The room temperature is {0} {1}\n", degree, scale);
*/