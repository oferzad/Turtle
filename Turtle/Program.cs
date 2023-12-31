using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Unit4.TurtleLib;

namespace TurtleExc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Turtle turtle = new Turtle();
            
            turtle.SetTailColor(Color.Blue);
            turtle.TailDown();
            for (int i = 0; i < 4; i++)
            {
                turtle.MoveForward(100);
                turtle.TurnLeft(90);
            }
            Turtle turtle2 = new Turtle();
            turtle2.SetTailColor(Color.Red);
            turtle2.TailDown();
            for (int i = 0; i < 4; i++)
            {
                turtle2.MoveForward(100);
                turtle2.TurnRight(90);
            }



        }
    }
}
