internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Suma de 5 números
         * Declarar dos variables de tipo entero (int), por ejemplo, numero1 y numero2.
         * Asigna un valor numérico a cada variable que asigne el usuario.
         * Muestra en la consola la suma de ambas variables.
         */

        //Aquí declaré una variable por cada número
        int numero1 = 10;
        int numero2 = 20;
        int numero3 = 30;
        int numero4 = 40;
        int numero5 = 50;

        //Suma cada una de las variables
        int sumatoria = numero1 + numero2 + numero3 + numero4 + numero5;

        //Muestro el total de la suma
        Console.WriteLine("El resultado de la sumatoria de los 5 números es " + sumatoria);
    }
}