internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;
        int num3;
        string nome;
        
        Console.Write(" Digite seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite a Primeira Nota: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a Segunda Nota: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a Terceira Nota: ");
        num3 = int.Parse(Console.ReadLine());

        double resultado = 0;
        double media = 0;
        resultado = num1 + num2 + num3;
        media = resultado /3;
        Console.WriteLine(" A média das notas é: " + media);


    if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}
        
    }
}