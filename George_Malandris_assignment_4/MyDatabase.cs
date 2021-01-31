using George_Malandris_assignment_4.Enums;
using George_Malandris_assignment_4.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Malandris_assignment_4
{
    class MyDatabase
    {
        public List<TShirt> TShirts { get; set; }

        public MyDatabase()
        {
            TShirts = new List<TShirt>()
            {
					new TShirt(Color.GREEN, Size.L, Fabric.CASHMERE),
					new TShirt(Color.BLUE, Size.M, Fabric.COTTON),
					new TShirt(Color.RED, Size.XL, Fabric.LINEN),
					new TShirt(Color.ORANGE, Size.M, Fabric.SILK),
					new TShirt(Color.GREEN, Size.XS, Fabric.WOOL),
					new TShirt(Color.VIOLET, Size.M, Fabric.CASHMERE),
					new TShirt(Color.GREEN, Size.L, Fabric.COTTON),
					new TShirt(Color.BLUE, Size.S, Fabric.LINEN),
					new TShirt(Color.BLUE, Size.XXL, Fabric.CASHMERE),
					new TShirt(Color.RED, Size.XXXL, Fabric.WOOL),
					new TShirt(Color.RED, Size.M, Fabric.RAYON),
					new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE),
				    new TShirt(Color.INDIGO, Size.L, Fabric.COTTON),
					new TShirt(Color.RED, Size.XL, Fabric.LINEN),
					new TShirt(Color.ORANGE, Size.S, Fabric.SILK),
					new TShirt(Color.VIOLET, Size.M, Fabric.CASHMERE),
				    new TShirt(Color.RED, Size.XS, Fabric.LINEN),
					new TShirt(Color.BLUE, Size.XS, Fabric.POLYESTER),
					new TShirt(Color.RED, Size.L, Fabric.POLYESTER),
					new TShirt(Color.BLUE, Size.XXXL, Fabric.CASHMERE),
					new TShirt(Color.GREEN, Size.L, Fabric.CASHMERE),
					new TShirt(Color.INDIGO, Size.M, Fabric.COTTON),
					new TShirt(Color.RED, Size.S, Fabric.RAYON),
					new TShirt(Color.VIOLET, Size.M, Fabric.POLYESTER),
					new TShirt(Color.GREEN, Size.XS, Fabric.COTTON),
					new TShirt(Color.YELLOW, Size.M, Fabric.CASHMERE),
					new TShirt(Color.GREEN, Size.L, Fabric.COTTON),
					new TShirt(Color.BLUE, Size.S, Fabric.LINEN),
					new TShirt(Color.YELLOW, Size.M, Fabric.CASHMERE),
					new TShirt(Color.ORANGE, Size.L, Fabric.SILK),
				    new TShirt(Color.RED, Size.M, Fabric.RAYON),
				    new TShirt(Color.BLUE, Size.L, Fabric.RAYON),
				    new TShirt(Color.INDIGO, Size.XXXL, Fabric.COTTON),
					new TShirt(Color.RED, Size.XL, Fabric.LINEN),
					new TShirt(Color.VIOLET, Size.S, Fabric.COTTON),
					new TShirt(Color.BLUE, Size.M, Fabric.SILK),
					new TShirt(Color.YELLOW, Size.XS, Fabric.LINEN),
					new TShirt(Color.BLUE, Size.XS, Fabric.POLYESTER),
					new TShirt(Color.RED, Size.L, Fabric.POLYESTER),
				    new TShirt(Color.BLUE, Size.XXXL, Fabric.WOOL),
					new TShirt(Color.GREEN, Size.L, Fabric.CASHMERE),
					new TShirt(Color.BLUE, Size.M, Fabric.COTTON),
					new TShirt(Color.RED, Size.S, Fabric.LINEN),
					new TShirt(Color.ORANGE, Size.XXL, Fabric.SILK),
					new TShirt(Color.GREEN, Size.XS, Fabric.WOOL),
				    new TShirt(Color.VIOLET, Size.M, Fabric.CASHMERE),
				    new TShirt(Color.GREEN, Size.L, Fabric.COTTON),
					new TShirt(Color.BLUE, Size.S, Fabric.LINEN),
				    new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE),
				    new TShirt(Color.RED, Size.XXXL, Fabric.WOOL),
				    new TShirt(Color.RED, Size.XXL, Fabric.RAYON),
				    new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE),
				    new TShirt(Color.INDIGO, Size.L, Fabric.COTTON),
					new TShirt(Color.RED, Size.S, Fabric.LINEN),
					new TShirt(Color.ORANGE, Size.S, Fabric.SILK),
					new TShirt(Color.VIOLET, Size.M, Fabric.CASHMERE),
					new TShirt(Color.RED, Size.XS, Fabric.LINEN),
				    new TShirt(Color.BLUE, Size.XS, Fabric.POLYESTER),
				    new TShirt(Color.RED, Size.L, Fabric.POLYESTER),
				    new TShirt(Color.BLUE, Size.XXXL, Fabric.CASHMERE),
					new TShirt(Color.GREEN, Size.L, Fabric.CASHMERE),
					new TShirt(Color.INDIGO, Size.M, Fabric.COTTON),
					new TShirt(Color.RED, Size.S, Fabric.RAYON),
					new TShirt(Color.VIOLET, Size.M, Fabric.POLYESTER),
					new TShirt(Color.GREEN, Size.XS, Fabric.COTTON),
					new TShirt(Color.YELLOW, Size.XXL, Fabric.CASHMERE),
					new TShirt(Color.GREEN, Size.L, Fabric.COTTON),
					new TShirt(Color.BLUE, Size.XL, Fabric.LINEN),
					new TShirt(Color.YELLOW, Size.M, Fabric.CASHMERE),
				    new TShirt(Color.ORANGE, Size.L, Fabric.SILK),
					new TShirt(Color.RED, Size.M, Fabric.RAYON),
					new TShirt(Color.BLUE, Size.L, Fabric.RAYON),
					new TShirt(Color.INDIGO, Size.L, Fabric.COTTON),
				    new TShirt(Color.RED, Size.S, Fabric.LINEN),
					new TShirt(Color.VIOLET, Size.S, Fabric.COTTON),
					new TShirt(Color.BLUE, Size.XXL, Fabric.SILK),
					new TShirt(Color.YELLOW, Size.XS, Fabric.LINEN),
				    new TShirt(Color.BLUE, Size.XS, Fabric.POLYESTER),
				    new TShirt(Color.RED, Size.XXXL, Fabric.POLYESTER),
					new TShirt(Color.BLUE, Size.L, Fabric.WOOL)
            };

        }
    }
}
