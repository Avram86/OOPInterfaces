using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaces
{
    public struct PointStruct:ITranslatableObject
    {
		public PointStruct(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}

		public double X { get;  set; } 

		public double Y { get;  set; }

		public void Print()
        {
			Console.WriteLine($"Point (struct) found at coords: [X={X}, Y={Y}] ");
        }

        public void Translate(int dx, int dy)
        {
            Y += dy;
            X += dx;
        }
    }
}
