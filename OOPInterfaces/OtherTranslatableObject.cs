using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaces
{
    public class OtherTranslatableObject:ITranslatableObject
    {
        public void Translate(int dx, int dy)
        {
            Console.WriteLine($"Hey, look! I am moving with dx={dx} and dy={dy}");
        }
    }
}
