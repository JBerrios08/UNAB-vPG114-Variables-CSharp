internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Área del círculo
         * Declara una variable de tipo double para almacenar el radio de un círculo.
         * Usa la fórmula del área del círculo, A = π * radio^2, para calcular el área.
         * Muestra el resultado en consola.
         */

        double radio = 4; //Declaré una variable para almacenar el radio del círculo
        double areaCirculo = Math.PI * Math.Pow(radio, 2); //Apliqué la fórmula para calcular el área del círculo

        //Muestro resultados
        Console.WriteLine("El área del círculo es " + areaCirculo);
    }
}