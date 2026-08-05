using System.Runtime.CompilerServices;

internal partial class Program
{
    private static void Main(string[] args)
    {
 string[] produtos = new string[5];
double[] precos = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Digite o produto: ");
    produtos[i] = Console.ReadLine();

    Console.Write("Digite o preço: ");
    precos[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{produtos[i]} - R$ {precos[i]}");
}
Console.Write("Digite o produto que deseja pesquisar: ");
        string pesquisa = Console.ReadLine();
    }
}