using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcSerranoExercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature room = new Temperature();
            room.GetData();
            room.DisplayDegree();
        }
    }
}
