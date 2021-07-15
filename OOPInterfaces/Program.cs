using System;

namespace OOPInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            SomeOtherObjectWithArea obj = new SomeOtherObjectWithArea(350);

            //polimorfism de tip, obj nu isis pier identitatea, doar arata ca si tipul de baza
            double totalArea = GeometryUtils.CalculateTotalArea(new IObjectWithARea[]{ rectangle, obj });

            Console.WriteLine($"Total area: {totalArea}");
        }
    }
}
