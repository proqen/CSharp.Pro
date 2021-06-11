namespace Task6._2.Library
{
    interface ITemperature
    {
        double Fahrenheit(double celsius);
    }
    public class Temperature: ITemperature
    {
        public double Fahrenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }
    }
}
