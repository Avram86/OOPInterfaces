using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaces
{
    public class SomeOtherObjectWithArea : IObjectWithARea
    {
		public SomeOtherObjectWithArea(double area)
		{
			this.Area = area;
		}

		public double Area
		{
			get;
		}

		public double GetArea()
		{
			return this.Area;
		}
	}
}
