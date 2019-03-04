using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern.CommandPattern
{
    class Solider
    {
        public void Shoot(string text)
        {
            Console.WriteLine("射击！"+text);
        }

        public void Fight(string text)
        {
            Console.WriteLine("搏斗！"+text);
        }

        public void Walk(string text)
        {
            Console.WriteLine("行军！"+text);
        }
    }
}
