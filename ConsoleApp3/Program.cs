using System;

namespace Ejercicios
{
    class MainClass
    {
        static void Main(string[] args)
        {
            double temperaturaF, temperaturaC;
            Console.Write("Ingresa la temperatura en grados Fahrenheit: ");
            temperaturaF = double.Parse(Console.ReadLine());
            Console.WriteLine("Su temperatura en grados Celcius es: ");
            temperaturaC = (temperaturaF - 32) * 0.5556;
            Console.WriteLine(temperaturaC);


        }
    }
}