using System;

namespace OOPInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

			PointStruct ps1 = new PointStruct(10, 10);
			PointStruct ps2 = ps1;

			ps2.X = 20;
			ps2.Y = 20;

			ps1.Print();

			Shape triangle = new Triangle(new Point(15, 15), new Point(23, 30), new Point(50, 25));
			Shape rectangle = new Rectangle(new Point(10,10), 100, 200);

			IObjectWithARea o1 = new SomeOtherObjectWithArea(100);
			ITranslatableObject o2 = new OtherTranslatableObject();
			IRotatableObject o3 = new OtherRotatableObject();

			double totalArea = GeometryUtils.CalculateTotalArea(new[] { triangle, rectangle ,o1 });
			Console.WriteLine($"Total area: {totalArea}");

			GeometryUtils.TranslateObjects(30, 50, triangle, rectangle, o2);

			GeometryUtils.RotateObjects(45, triangle, rectangle, o3);

			double totalArea2 = GeometryUtils.CalculateTotalArea(new[] { triangle, rectangle, o1 });
			Console.WriteLine($"Total area after translation and rotation: {totalArea2}");

		}
	}
}
