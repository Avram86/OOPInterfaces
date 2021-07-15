using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaces
{
    public class OtherRotatableObject: IRotatableObject
    {
        public void Rotate(double angleDegrees)
        {
            Console.WriteLine($"Hey, look! I am rotating with an angle of {angleDegrees} degrees");
        }
    }
}
