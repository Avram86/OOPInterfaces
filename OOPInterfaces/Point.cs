using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaces
{
    public class Point : ITranslatableObject, IRotatableObject
    {
		public Point(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}

		public double X { get;  set; } = 0;

		public double Y { get;  set; } = 0;

		public void Rotate(double angleDegrees)
		{
			double angleRadians = (Math.PI / 180) * angleDegrees;

			// see: https://en.wikipedia.org/wiki/Rotation_matrix
			double originalX = this.X;
			double originalY = this.Y;

			this.X = originalX * Math.Cos(angleRadians) - originalY * Math.Sin(angleRadians);
			this.Y = originalX * Math.Sin(angleRadians) + originalY * Math.Cos(angleRadians);
		}

		public void Translate(int dx, int dy)
		{
			this.X += dx;
			this.Y += dy;
		}

		public void Print()
		{
			Console.WriteLine($"Point (struct) found at coords: [X={X}, Y={Y}] ");
		}

	}
}
