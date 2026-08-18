/*
## 🟢 Exercício 03 — Agenda Telefônica

Crie uma agenda telefônica utilizando:

```csharp
Dictionary<string, string>
```
Onde:

- A chave representa o nome.
- O valor representa o telefone.

O programa deve permitir:

1. Cadastrar um contato.
2. Pesquisar um contato pelo nome.
3. Alterar o telefone de um contato.
4. Remover um contato.
5. Exibir todos os contatos.

**Conceitos:** `Dictionary`, chave/valor, inclusão, alteração, pesquisa e remoção.

*/

internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("=== AGENDA TELEFONICA ===");

        Dictionary<string, string> agenda = new Dictionary<string, string>();

agenda.Add("Rafaella", "99876-9088");
agenda.Add("Lucas", "99654-0987");
agenda.Add("Isabela","99234-6574");

Console.WriteLine();
        foreach (var telefone in agenda)
        {
            Console.WriteLine($"{telefone.Key} - {telefone.Value}");
        }

        string? termo;
        bool chave = agenda.TryGetValue("Lucas", out termo);

        Console.WriteLine();

        if (chave && termo is not null)
        {
            Console.WriteLine($"O contato foi encontrada: {termo}");
        }
        else
        {
            Console.WriteLine("O contato não foi encontrada na agenda");
        }

        agenda["Rafaella"] = "99433-0789";
        Console.WriteLine();
        foreach (var telefone in agenda)
        {
            Console.WriteLine($"{telefone.Key} - {telefone.Value}");
        }

        agenda.Remove("Isabela");
        Console.WriteLine();
        foreach (var telefone in agenda)
        {
            Console.WriteLine($"{telefone.Key} - {telefone.Value}");
        }
    }
}