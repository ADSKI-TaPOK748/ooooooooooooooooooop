using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooooooooooooooooooop
{
    internal class Human
    {
        public int age;
        public int height;
        public string name;

        public void SetName(string new_name);
        {
            name=new_name;
        }
        public void GetName()
        {
            Console.WriteLine($"Меня зовут {name}");
        }

        public class Child : Human
        {
            Console.Writeline
        }
    }
}
