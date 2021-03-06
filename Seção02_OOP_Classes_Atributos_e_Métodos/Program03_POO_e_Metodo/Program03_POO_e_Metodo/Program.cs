/*      
      Udemy - curso C#
        Seção 04

Problema-Exemplo: Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas). 
Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.
A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a fórmula de Heron.
*/

using System;
using System.Globalization;


namespace Program03_POO_e_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;

            X = new Triangulo();
            Y = new Triangulo();

            double areaX, areaY;
            string[] trianguloX, trianguloY;

            Console.WriteLine("MEDIDAS -EXEMPLO: '2.5 - 6 - 1.8\n'");
            Console.WriteLine("Informe as medidas do triângulo X:");
            trianguloX = Console.ReadLine().Split(" - ");

            X.lado01 = double.Parse(trianguloX[0], CultureInfo.InvariantCulture);
            X.lado02 = double.Parse(trianguloX[1], CultureInfo.InvariantCulture);
            X.lado03 = double.Parse(trianguloX[2], CultureInfo.InvariantCulture);

            Console.WriteLine("\nInforme as medidas do triângulo Y:");
            trianguloY = Console.ReadLine().Split(" - ");

            Y.lado01 = double.Parse(trianguloY[0], CultureInfo.InvariantCulture);
            Y.lado02 = double.Parse(trianguloY[1], CultureInfo.InvariantCulture);
            Y.lado03 = double.Parse(trianguloY[2], CultureInfo.InvariantCulture);

            areaX = X.Area();
            areaY = Y.Area();

            Console.WriteLine("\nÁrea de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("\nMaior área: X");
            }

            else
            {
                Console.WriteLine("\nMaior área: Y");
            }
        }
    }
}
