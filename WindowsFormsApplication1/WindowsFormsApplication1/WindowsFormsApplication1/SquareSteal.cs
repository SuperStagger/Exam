using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class SquareSteal : PowerSteal
    {
        private int side;
        public SquareSteal(int thickness, double density, int side) : base(thickness, density)
        {
            this.side = side;
        }
        public override double Square()
        {
        return side*side;
        }
        public override double  Weight()
        {
            return base.Weight();
        }
        public override string Information()
        {
            return "Квадратний Лист, Товщина: " + thickness + ", густина: " + density;
        }
    }
    
}
