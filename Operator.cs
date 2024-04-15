using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal interface Operator
    {
        double eval(double first_number, double second_number);
    }

    internal class Plus : Operator
    {
        public double eval(double first_number, double second_number)
        {
            return first_number + second_number;
        }
    }

    internal class Minus : Operator
    {
        public double eval(double first_number, double second_number)
        {
            return first_number - second_number;
        }
    }

    internal class Mult : Operator
    {
        public double eval(double first_number, double second_number)
        {
            return first_number * second_number;
        }
    }

    internal class Divide : Operator
    {
        public double eval(double first_number, double second_number)
        {
            return first_number / second_number;
        }
    }

    internal class Null : Operator
    {
        public double eval(double first_number, double second_number)
        {
            return 0.0d;
        }
    }

}
