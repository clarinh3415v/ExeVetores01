
using System.Globalization;

namespace exercicio04
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
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }
            double media = soma / N;
            Console.WriteLine("Media = " + media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}