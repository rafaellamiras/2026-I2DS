/*
## 🟢 Exercício 02 — Cadastro de Alunos

Crie uma classe `Aluno` com as propriedades:

- `Nome`
- `Idade`

Cadastre 5 alunos utilizando uma `List<Aluno>`.

O programa deve:

1. Exibir todos os alunos.
2. Permitir alterar a idade de um aluno.
3. Permitir remover um aluno pelo nome.
4. Exibir a lista final.

**Conceitos:** `List<T>`, objetos, pesquisa, alteração e remoção.

*/

internal class Program
{
    public class Aluno
    {
        public string Nome {get;set;}
        public int Idade {get;set;}
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== ALUNOS ===");  

        
    List<Aluno> listaAlunos = new List<Aluno>();
    Aluno aluno1 = new Aluno
    {
        Nome = "Rafaella", Idade = 16
    };
    Aluno aluno2 = new Aluno
    {
        Nome = "Isabela", Idade = 20
    };
    Aluno aluno3 = new Aluno
    {
        Nome = "Kauã", Idade = 17
    };
    Aluno aluno4 = new Aluno
    {
        Nome = "Cris", Idade = 25
    };
    Aluno aluno5 = new Aluno
    {
        Nome = "Pedro", Idade = 12
    };
    listaAlunos.Add(aluno1);
    listaAlunos.Add(aluno2); 
    listaAlunos.Add(aluno3);
    listaAlunos.Add(aluno4);
    listaAlunos.Add(aluno5);

Console.WriteLine();
    foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }
listaAlunos[1].Idade = 30;
Console.WriteLine();
Console.WriteLine("=== ALTERAÇÃO IDADE ===");
foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }

listaAlunos.Remove(aluno2);

Console.WriteLine();
Console.WriteLine("=== ALUNO REMOVIDO ===");
foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }


    }
}