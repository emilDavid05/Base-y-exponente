using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la base:");
        double basePotencia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el exponente:");
        double exponentePotencia = Convert.ToDouble(Console.ReadLine());

        double resultadoPotencia = ElevarPotencia(basePotencia, exponentePotencia);

        Console.WriteLine("El resultado es: " + resultadoPotencia);
    }

    static double ElevarPotencia(double basePotencia, double exponentePotencia)
    {
        return Math.Pow(basePotencia, exponentePotencia);
    }
}