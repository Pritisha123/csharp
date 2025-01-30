using System;
using System.Security.Cryptography.X509Certificates;

public class exercicio_16
{
    public static void Main(string[] args)
    {
        parImpar(10);
        parImpar(11);
    }
    public static void parImpar(int valor1)
    {
        bool resultado = valor1 % 2 == 0;
        if (resultado)
        {
            quadradonumPar(valor1);
        }
        else
        {
            Console.WriteLine("o numero nao e par e por" +
                "isso nao e calculado o valor ao quadrado");
        }
    }
    public static void quadradonumPar (int valor2)
    {
        int resultado = valor2 * valor2;
        Console.WriteLine("o quadrado do valor" + valor2 + "e"+ resultado);

    }
}
