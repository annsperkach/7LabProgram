using System;

namespace Library
{
    class Equation
    {
        private double a, b, c, d;

        public Equation(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public void SetValue(char input, double value)
        {
            try
            {
                if (input == 'a')
                {
                    a = value;
                }
                else if (input == 'b')
                {
                    b = value;
                }
                else if (input == 'c')
                {
                    c = value;
                }
                else if (input == 'd')
                {
                    d = value;
                }
                else
                {
                    throw new Exception("Invalid argument");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        public double GetValue(char input)
        {
            try
            {
                if (input == 'a')
                {
                    return a;
                }
                else if (input == 'b')
                {
                    return b;
                }
                else if (input == 'c')
                {
                    return c;
                }
                else if (input == 'd')
                {
                    return d;
                }
                else
                {
                    throw new Exception("Invalid argument");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return 0;
            }
        }

        public double Calculation()
        {
            try
            {
                double UpPart = 4 * Math.Log(a / b) + 1;
                double DownPart = c + b - d + a;
                if(DownPart == 0)
                {
                    throw new Exception("Error: The subcortical expression less than 0");
                }
                else if (UpPart == 0 && b == 0)
                {
                    throw new Exception("Error: Division by zero");
                }
                else if (a / b <= 0)
                {
                    throw new Exception("Error: Used number in logarithm <= 0");
                }
                else
                {
                    return UpPart / DownPart;
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
                return 0;
            }
        }
    }
}
