using George_Malandris_assignment_4.Enums;
using George_Malandris_assignment_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Malandris_assignment_4.Products
{
    public class TShirt : IProduct
    {
        private double _basePrice = 10.0;

        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }

        public TShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        public double GetPriceTag()
        {
            return (double)(_basePrice * (100 + (int)Color + (int)Size + (int)Fabric) / 100);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Product Type: TShirt\nSize: {Size}\nColor: {Color}\nFabric: {Fabric}");
        }
        public void Output()
        {
            Console.WriteLine("{0, 12} | {1, 12} | {2, 12}", Size, Color, Fabric);
        }
    }
}
