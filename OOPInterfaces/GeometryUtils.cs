using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaces
{
    public static class GeometryUtils
    {
		public static double CalculateTotalArea(IObjectWithARea[] objects)
		{
			double area = 0;
			foreach (IObjectWithARea o in objects)
			{
				area += o.GetArea();
			}

			return area;
		}
	}
}
