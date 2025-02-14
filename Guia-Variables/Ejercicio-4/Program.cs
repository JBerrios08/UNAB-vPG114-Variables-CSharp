internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Promedio de tres números
         * Declara tres variables de tipo double, por ejemplo, nota1, nota2, nota3.
         * Asigna valores a las tres notas.
         * Calcula el promedio de las tres notas y muestra el resultado.
         */

        double nota1 = 10;
        double nota2 = 8;
        double nota3 = 9;

        double promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promedio de las notas ingresadas es " + promedio);
    }
}