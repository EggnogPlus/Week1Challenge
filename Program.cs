using System;

namespace Operators
{
    public class Program
    {
        public static void Main()
        {
            int x, y, z;
            x = 0;
            y = 0;
            z = 0;
            bool numberx;
            bool numbery;
            bool xx = true;
            bool yy = true;
            //x = 0;
            while (xx = true)
            {
                Console.WriteLine("enter numercial value for x");

                numberx = int.TryParse(Console.ReadLine(), out x); ;
                
                //x = Convert.ToInt32(Console.ReadLine());
                if (x > 1000 || numberx != true || x < 0)
                {
                    Console.WriteLine("nO");
                    
                }
                else
                {
                    break;
                }
            }
            while (yy = true)
            {
                Console.WriteLine("enter numerical value for y");
                numbery = int.TryParse(Console.ReadLine(),out y); ;
                if (y > 1000 || numbery != true || y <0)
                {
                    Console.WriteLine("nO");
                }
                else
                {
                    break;
                }
            }
            CallMe(x, y, z);
            //Console.WriteLine($"{x} + {y} = {z}");
        }

        public static void CallMe(int x, int y, int z)
        {
           z = x + y;
           Console.WriteLine($"{x} + {y} = {z}");
        }

    }
}
