using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaces
{
    public class Rectangle : Shape
    {
		public Rectangle(Point topLeft,double width, double height)
			:base(new Point[] { topLeft ?? new Point(0,0), 
								new Point(topLeft?.X ?? 0+width, topLeft?.Y ?? 0),
								new Point(topLeft?.X ?? 0+width, topLeft?.Y ?? 0+height),
								new Point(topLeft?.X ?? 0, topLeft?.Y ?? 0+height)})
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
