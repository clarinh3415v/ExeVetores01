
namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            String[] nomes = new String[N];
            int[] idades = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }

          
            int MaiorIdade = idades[0];
            int posicaoMaiorIdade = 0;

            for (int i = 1; i < N; i++)
            {
                if (idades[i] > MaiorIdade)
                {
                    MaiorIdade = idades[i];
                    posicaoMaiorIdade = i;
                }
            }

           
            Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaiorIdade]);
        }
    }
}