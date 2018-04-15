using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Rectangular : Triangle
    {
        private double hypotenuse;

        public Rectangular(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC) { }

        public bool IsRectagular()
        {
            
            if ((Math.Pow(this.SideA, 2) + Math.Pow(this.SideB, 2)) == Math.Pow(this.SideC, 2))
            {
                hypotenuse = this.SideC;
                return true;
            }

            if ((Math.Pow(this.SideB, 2) + Math.Pow(this.SideC, 2)) == Math.Pow(this.SideA, 2))
            {
                hypotenuse = this.SideA;
                return true;
            }

            if ((Math.Pow(this.SideA, 2) + Math.Pow(this.SideC, 2)) == Math.Pow(this.SideB, 2))
            {
                hypotenuse = this.SideB;
                return true;
            }

            return false;
        }

        public double Hypotenuse
        {
            get { return hypotenuse; }
            set { hypotenuse = value > 0 ? value : 0; }
        }


        public override String ToString()
        {
            String result;
            if (this.IsTriangle() && this.IsRectagular())
            {
                result = "Rectagular triangle: " + " (" + this.SideA + ", " + this.SideB + ", " + this.SideC + ")" + Environment.NewLine;
                result += "Perimeter: " + this.GetPerimeter() + Environment.NewLine;
                result += "Square: " + this.GetSquare() + Environment.NewLine;
                result += "Angles:" + Environment.NewLine + this.GetAngle(this.SideA, this.SideB, this.SideC) + Environment.NewLine;
                result += this.GetAngle(this.SideB, this.SideC, this.SideA) + Environment.NewLine;
                result += this.GetAngle(this.SideA, this.SideC, this.SideB) + Environment.NewLine;

            }
            else
            if (!this.IsTriangle())
                result = "Rectagular triangle: " + "(" + this.SideA + ", " + this.SideB + ", " + this.SideC + ")" + " is NOT triangle" + Environment.NewLine;
            else
                result = "Rectagular triangle: " + " (" + this.SideA + ", " + this.SideB + ", " + this.SideC + ")" + " is NOT rectangular triangle" + Environment.NewLine;

            return result;
        }
    }
}
