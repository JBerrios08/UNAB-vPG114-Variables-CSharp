internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Conversión de temperatura
         * Declara una variable fahrenheit que almacene la temperatura en grados Fahrenheit.
         * Convierte esa temperatura a grados Celsius con la fórmula: C = (F - 32) * 5/9.
         * Muestra la temperatura en Celsius.
         */

        double tempFahrenheit = 16; //Declaré una variable para guardar el valor de la temperatura °F
        double tempCelsius = (tempFahrenheit - 32) * 5.0 / 9.0; //Aquí apliqué la fómula tomando en cuenta la variable antes declarada

        //Salida de datos
        Console.WriteLine($"Temperatura Fahrenheit: {tempFahrenheit}°F \nTemperatura Celsius: {tempCelsius}°C");
    }
}