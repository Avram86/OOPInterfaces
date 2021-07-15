using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaces
{
    public class Rectangle : Shape
    {
		public Rectangle(double width, double height)
		{
			this.Width = width;
			this.Height = height;
		}

		public double Width
		{
			get;
		}

		public double Height
		{
			get;
		}
		public override double GetArea()
        {
			return this.Width * this.Height;
        }
    }
}
