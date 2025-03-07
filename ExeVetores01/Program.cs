using System.Globalization;

int N, P = 0;
double M = 0;
double[] vet;

N = int.Parse(Console.ReadLine());
vet = new double[N];

string[] s = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++) { 
    vet[i] = double.Parse(s[i], System.Globalization.CultureInfo.InvariantCulture);
}

for
    (int i = 0; i <N; i++)
{
    if (vet[i] > M)
    {
        M = vet[i];
        P = i;
    }
}
 Console.WriteLine(M.ToString("F1",CultureInfo.InvariantCulture ));
Console.WriteLine(value: P);

Console.ReadLine();
