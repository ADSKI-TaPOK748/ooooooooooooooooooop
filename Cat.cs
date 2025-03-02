using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooooooooooooooooooop
{
    internal class Cat
    {
        public string name;
        public int age;
        public double height;
        public string color;
        public string poroda;

        public int tail;

        public void SetTaiLlenth(int x)
        {
            if ((x>5) & (x<50))
            {
                tail = x;
            }
        }
        public void GetTail()
        {
            Console.WriteLine($"Длинна хвоста - {tail} Сантиметров");
        }
    }
}
