
using System.Globalization;

namespace exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            string[] Nomes = new String[N];
            double[] NotasSemestre1 = new double[N];
            double[] NotasSemestre2 = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                Nomes[i] = s[0];
                NotasSemestre1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                NotasSemestre2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos Aprovados:");
            for (int i = 0; i < N; i++)
            {
                double media = (NotasSemestre1[i] + NotasSemestre2[i]) / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(Nomes[i]);
                }
            }
        }
    }
}
