using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Triangle
    {
        double sideA, sideB, sideC;

        public Triangle()
        {
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double SideA
        {
            get { return sideA; }
            set { sideA = value > 0 ? value : 0; }
        }
        public double SideB
        {
            get { return sideB; }
            set { sideB = value > 0 ? value : 0; }
        }

        public double SideC
        {
            get { return sideC; }
            set { sideC = value > 0 ? value : 0; }
        }

        public bool IsTriangle()
        {
            bool result = false;
            if (
                (this.sideA + this.sideB > this.sideC) &&
                (this.sideB + this.sideC > this.sideA) &&
                (this.sideA + this.sideC > this.sideB)
                )
                result = true;

            return result;
        }

        public double GetPerimeter()
        {
            return this.sideA + this.sideB + this.sideC;
        }

        public double GetSquare()
        {
            double p = this.GetPerimeter() / 2;
            return Math.Sqrt(p * (p - this.sideA) * (p - this.sideB) * (p - this.sideC));
        }

        public double GetAngle(double sideA, double sideB, double sideC)
        {
            return (180 / Math.PI) * Math.Acos((sideA * sideA + sideB * sideB - sideC * sideC) / (2 * sideA * sideB));
        }

        public override String ToString()
        {
            String result;
            if (this.IsTriangle())
            {
                result = "Triangle: " + " (" + this.SideA + ", " + this.SideB + ", " + this.SideC + ")" + Environment.NewLine;
                result += "Perimeter: " + this.GetPerimeter() + Environment.NewLine;
                result += "Square: " + this.GetSquare() + Environment.NewLine;
                result += "Angles:" + Environment.NewLine + this.GetAngle(this.SideA, this.SideB, this.SideC) + Environment.NewLine;
                result += this.GetAngle(this.SideB, this.SideC, this.SideA) + Environment.NewLine;
                result += this.GetAngle(this.SideA, this.SideC, this.SideB) + Environment.NewLine;

            } else
                result = "Triangle: " + " (" + this.SideA + ", " + this.SideB + ", " + this.SideC + ")" + " is NOT triangle" + Environment.NewLine;

            return result;
        }

    }
}
