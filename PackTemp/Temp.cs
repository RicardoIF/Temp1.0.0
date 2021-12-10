using System;

namespace PackTemp
{
    public class Temp
    {
        private string vScale;
        private double vTemp;

        public Temp(double Temp, string Scale)
        {
            vScale = Scale;
            vTemp = Temp;
        }
        public double ToFahrenheit()
        {
            if (vScale == "K")
            {
                return Math.Round(((vTemp - 273.15) * 1.8) + 32, 2);
            }
            else if(vScale == "C")
            {
                return Math.Round((vTemp * 1.8) + 32, 2);
            }
            else
            {
                return vTemp;
            }
        }
        public double ToCelsius()
        {
            if (vScale == "K")
            {
                return Math.Round((vTemp - 273.15), 2);
            }
            else if (vScale == "F")
            {
                return Math.Round((vTemp - 32) / 1.8, 2);
            }
            else
            {
                return vTemp;
            }
        }
        public double ToKelvin()
        {
            if (vScale == "C")
            {
                return Math.Round((vTemp + 273.15), 2);
            }
            else if (vScale == "F")
            {
                return Math.Round(((vTemp - 32) / 1.8) + 273.15, 2);
            }
            else
            {
                return vTemp;
            }
        }
    }
}
