using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignments_1._4
{
    //Create a structure named “Point” and 2 data members: X and Y coordinate.
    //Declare 2 points: P1 and P2.
    //Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates.
    //( if p1.x is more than p2.x , it is to the right )
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1.1, 1.2); ;
            Point p2 = new Point(1.3, 1.40);

            if (p1.x == p2.x)
            {
                Console.WriteLine("On the same y-axis");
            }
            else if (p1.x < p2.x)
            {
                Console.WriteLine("p1 is to the left of p2.");
            }
            else
            {
                Console.WriteLine("p1 is to the right of p2.");
            }
        }

        public class Point
        {
            public Point(double xCoord, double yCoord)
            {
                x = xCoord;
                y = yCoord;
            }
            public Point()
            {
                x = 0;
                y = 0;
            }

            public double x;
            public double y;
        }
    }
}
