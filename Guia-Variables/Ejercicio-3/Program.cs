internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Intercambio de valores
         * Declara dos variables de tipo entero, a y b, y asigna valores diferentes a ambas.
         * Intercambia los valores de a y b sin usar una tercera variable.
         * Muestra los valores de a y b después del intercambio.
         */

        //Aquí declaro variables para cada letra y le asigno un valor
        int a = 10, b = 20;

        //Muestro valores antes del intercambio
        Console.WriteLine($"Los valores originales son:\nValor de a: {a}\nValor de b: {b}");

        //Realizo el intercambio
        a = a + b;
        b = a - b;
        a = a - b;

        //Muestro valores después del intercambio
        Console.WriteLine($"Los valores después del intercambio son:\nValor de a: {a}\nValor de b: {b}");
    }
}