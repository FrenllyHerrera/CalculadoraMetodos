namespace CaculadoraMétodos;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Caculadora con métodos");
        double numero1 = Leernumero("Ingrese su primer número");
        double numero2 = Leernumero("Ingrese su segundo número");

        Console.WriteLine("Suma: " + Sumar(numero1, numero2));
        Console.WriteLine("Resta: " + Restar(numero1, numero2));
        Console.WriteLine("Multiplicación: " + Multiplicar(numero1, numero2));

        if (numero2 == 0)
        {
            Console.WriteLine("Division: Error, no se puede dividir entre cero");
        }

        else
        {
            Console.WriteLine("Division: " + Dividir(numero1, numero2));
        }

        Console.WriteLine($"Potencia:{Potencia(numero1, numero2)}");
    }
    static double Leernumero(string mensaje)
    { Console.WriteLine(mensaje); double numero = double.Parse(Console.ReadLine()); return numero; }
    static double Sumar(double numero1, double numero2) { return (numero1 + numero2); }
    static double Restar(double numero1, double numero2) { return (numero1 - numero2); }
    static double Multiplicar(double numero1, double numero2) { return (numero1 * numero2); }
    static double Dividir(double numero1, double numero2) { return numero1 / numero2; }
    static double Potencia(double numero1, double numero2) { return Math.Pow(numero1, numero2); }
}