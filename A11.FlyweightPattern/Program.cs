using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12.FlyweightPattern
{
    class Program
    {
        static string[] colors = { "red", "green", "blue", "white", "block" };
        static Random random;
        static void Main(string[] args)
        {
            random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Circle circle =
                    (Circle)ShapeFactory.GetCile(GetRandomColor());
                circle.x = GetRandomx();
                circle.y = GetRandomy();
                circle.radius = 100;
                circle.Draw();
            }
        }
        static string GetRandomColor() => colors[random.Next(0, colors.Length-1)];
        static int GetRandomx() => random.Next(0, 100);
        static int GetRandomy() => random.Next(0, 100);
    }
}
