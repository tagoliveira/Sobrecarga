using System;

namespace Sobrecarga
{
    class Program
    {
        static double media;
        static string metodo_sobrecarga;
        static void Main(string[] args)
        {
            calcular(5,"8");
            mostrar_media();
        }

        public static void calcular(double nota1, double nota2)
        {
            media = (nota1 + nota2) / 2;
            metodo_sobrecarga = "calcular (double nota1, double nota2)";
        }

        public static void calcular(string nota1, string nota2)
        {
            media = (double.Parse(nota1) + double.Parse(nota2)) / 2;
            metodo_sobrecarga = "calcular (string nota1, string nota2)";
        }

        public static void calcular(double nota1, string nota2)
        {
            media = (nota1 + double.Parse(nota2)) / 2;
            metodo_sobrecarga = "calcular(double nota1, string nota2)";
        }

        public static void mostrar_media()
        {
            Console.WriteLine("A media é " + media);
            Console.WriteLine("Metodo chamado " + metodo_sobrecarga);
            Console.ReadKey();
        }
    }
}
