
using System.Globalization;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i]);
            }

            double somaPares = 0.0;
            int quantidadePares = 0;
            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    somaPares = somaPares + vet[i];
                    quantidadePares++;
                }
            }

            if (quantidadePares == 0)
            {
                Console.WriteLine("Não há numero par");
            }
            else
            {
                double media = somaPares / quantidadePares;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}