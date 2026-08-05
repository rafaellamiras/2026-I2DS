
internal class Program
{
    private static void Main(string[] args)
    {

        int celsius;
        Console.Write("Digite a temperatura em Graus Celsius: ");
        celsius = int.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
    }
}
