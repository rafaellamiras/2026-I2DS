using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Sintaxe: Enquanto uma condição for verdadeira

        execute um conjunto de comandos

        for -> Quando sabemos a quantidade de repetições
        while -> Quando a repetição depende de uma condição
        do...while -> Quando precisa executar ao menos uma vez o bloco de código
        */

        /* Laço for: Imprmir numeros de 1 a 10 */

Console.WriteLine("Imprimir numeros de 1 até 10, utilizando o laço for.");
        for(int numero = 1; numero <= 10; numero++)
        {
            Console.WriteLine(numero);
        }

        /* Laço for: ICOntagem Regressivaa 10 a 0 */

Console.WriteLine("Imprimir Contagem Regressiva");
        for(int numero = 10; numero >= 0; numero--)
        {
            Console.WriteLine(numero);
        }

        /* ********************************************************** */

Console.WriteLine("Imprimir numeros de 1 até 10, utilizando o laço while.");
int contador = 1;
while(contador <= 10)
    {
            Console.WriteLine(contador);
            contador ++;
        }

        /* Solicitar a senha até acertar */
        string senha = "";

        while(senha != "2444")
        {
            Console.Write("Digite a Senha: ");
            senha = Console.ReadLine(); // WriteLine - Eu escrevo na linha - Write: A pessoa escreve na linha
        }
        Console.WriteLine("Acesso Permitido!");

        /* ********************************************************** */
int num;
        do
        {
            Console.Write("Digite um Numero Positivo: ");
            num = int.Parse(Console.ReadLine());
        }while(num <=0);
    }
}