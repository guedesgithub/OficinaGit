using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num * num2;

        if (resultado == 0) { Console.WriteLine("Numero inválido"); }
        if (resultado == 1) { Console.WriteLine("Numero inválido"); }
        if (resultado == 2) { Console.WriteLine("Numero inválido"); }
       /* if (resultado == 3) { Console.WriteLine("Numero inválido"); }*/

        for(int i = 0; i < num; i++)
        {
            Console.WriteLine(i);
        }



        Console.WriteLine($"O resultado da multiplicação é {resultado}");

        Console.ReadKey(); 
    }
}