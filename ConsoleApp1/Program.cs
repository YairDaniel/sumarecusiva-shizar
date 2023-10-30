using System;

class Program
{
    static int SumaIterativa(int n)
    {
        int suma = 0;

        while (n > 9)
        {
            suma += n % 10;
            n /= 10;
        }

        return suma + n;
    }

    static int SumaRecursiva(int n)
    {
        if (n <= 9)
        {
            return n;
        }
        else
        {
            return SumaRecursiva(n / 10) + n % 10;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        int sumaIterativa = SumaIterativa(numero);
        int sumaRecursiva = SumaRecursiva(numero);

        Console.WriteLine("Suma iterativa: " + sumaIterativa);
        Console.WriteLine("Suma recursiva: " + sumaRecursiva);

        Console.WriteLine("Presiona Enter para salir...");
        Console.ReadLine(); // Espera a que el usuario presione Enter
    }
}
