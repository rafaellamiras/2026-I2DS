internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro Aluno
        Aluno aluno1 = new Aluno();
        aluno1.Rm= 5055;
        aluno1.Nome =  "rafaella";
        aluno1.Nascimento = new DateOnly (2010, 01, 12);
        aluno1.Email = "rafaellamiras@edu.senai.br";

         // Segundo Aluno
        Aluno aluno2 = new Aluno();
        aluno2.Rm= 2345;
        aluno2.Nome =  "Isabela";
        aluno2.Nascimento = new DateOnly (2009, 04, 20);
        aluno2.Email = "isabelaalbino@edu.senai.br";

        Aluno aluno3 = new Aluno();
        aluno3.Rm= 0978;
        aluno3.Nome =  "Gabriela";
        aluno3.Nascimento = new DateOnly (2002, 09, 06);
        aluno3.Email = "gabriela@edu.senai.br";


        // Exibindo os Livro na Tela
        Console.WriteLine("==== ALUNO ====");
        Console.WriteLine($"\nRm: {aluno1.Rm} | aluno 01: {aluno1.Nome}");
        Console.WriteLine($"Rm: {aluno2.Rm} | aluno 02: {aluno2.Nome}");
        Console.WriteLine($"Rm: {aluno3.Rm} | aluno 03: {aluno3.Nome}");
    }

    public class Aluno {
    public int Rm {get; set;}
    public string Nome {get; set;}
    public DateOnly Nascimento {get; set;}
    public string Email {get; set;}
    }
}