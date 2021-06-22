using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    abstract class PowerSteal
    {
        protected int thickness;
        protected double density;

        public abstract string Information();

        public abstract double Square();
        public virtual double Weight()
        {
            return Square() * thickness*density;
        }

        public PowerSteal(int thickness, double density)
        {
            this.thickness = thickness;
            this.density = density;
        }
    }
}
