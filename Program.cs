using System;
using System.Globalization;


namespace area_de_um_terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, preco, PrecoMetroQuadrado, area;

            Console.WriteLine("DIGITE O VALOR REFERENTE A LARGURA");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("DIGITE O COMPRIMENTO");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("QUAL VALOR DO METRO QUADRADO");
            PrecoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * PrecoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO= " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
