
using System.Globalization;

namespace exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] Alturas = new double[N];
            char[] Sexos = new char[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                Alturas[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                Sexos[i] = char.Parse(s[1]);
            }

            double menorAltura = Alturas[0];
            for (int i = 1; i < N; i++)
            {
                if (Alturas[i] < menorAltura)
                {
                    menorAltura = Alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));

           
            double maiorAltura = Alturas[0];
            for (int i = 1; i < N; i++)
            {
                if (Alturas[i] > maiorAltura)
                {
                    maiorAltura = Alturas[i];
                }
            }
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

           
            double somaDasAlturasDasMulheres = 0.0;
            int contMulheres = 0;
            for (int i = 0; i < N; i++)
            {
                if (Sexos[i] == 'F')
                {
                    somaDasAlturasDasMulheres = somaDasAlturasDasMulheres + Alturas[i];
                    contMulheres++;
                }
            }

            if (contMulheres == 0)
            {
                Console.WriteLine("Nao ha nenhuma mulher dentre as pessoas");
            }
            else
            {
                double media = somaDasAlturasDasMulheres / contMulheres;
                Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }
            int contHomens = 0;
            for (int i = 0; i < N; i++)
            {
                if (Sexos[i] == 'M')
                {
                    contHomens++;
                }
            }
            Console.WriteLine("Numero de homens = " + contHomens);
        }
    }
}