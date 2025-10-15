using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NasadukJA.Sprint2.Task3.V6.Lib
{
    public class DataService : ISprint2Task3V6
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = x + Math.Pow((x - 15.0) / (x - 10.0), x - 3.0);
            }
            else
            {
                if (x == 0)
                {
                    y = (x * x - Math.Cos(x * x) + 10.0) / (x * x - Math.Sin(x * x) + 12.0);
                }
                else
                {
                    if ((x > -10) && (x < 0))
                    {
                        y = Math.Pow(x * x * x * x + (1.0 / (x * x)), x);
                    }
                    else
                    {
                        if (x < -10)
                        {
                            y = x + (10.0 * x) - (1.0 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
