/*# PARTE 1 — ENUNCIADOS

## 🟢 Exercício 01 — Cadastro de Frutas

Crie um aplicativo Console que utilize uma `List<string>` para armazenar nomes de frutas.

O programa deve:

- Adicionar inicialmente 5 frutas.
- Exibir todas as frutas cadastradas.
- Solicitar ao usuário uma nova fruta.
- Adicionar a nova fruta à lista.
- Exibir novamente a lista atualizada.

**Conceitos:** `List`, `Add`, `foreach`. */


internal class Program
{
    public class Cadastro
    {
        public string? Nome {get;set;}
    }
    private static void Main(string[] args)
    {
    Console.WriteLine("=== LISTA FRUTAS ===");

    List<Cadastro> listaFrutas = new List<Cadastro>();
Cadastro fruta1 = new Cadastro
{
    Nome = "Maçã"
};
Cadastro fruta2 = new Cadastro
{
    Nome = "Banana"
};
Cadastro fruta3 = new Cadastro
{
    Nome = "Uva"
};
Cadastro fruta4 = new Cadastro
{
    Nome = "Mamão"
};
Cadastro fruta5 = new Cadastro
{
    Nome = "Abacaxi"
};
Cadastro fruta6 = new Cadastro
{
    Nome = "Morango"
};

listaFrutas.Add(fruta1);
listaFrutas.Add(fruta2);
listaFrutas.Add(fruta3);
listaFrutas.Add(fruta4);
listaFrutas.Add(fruta5);

Console.WriteLine();
foreach (var Cadastro in listaFrutas)
        {
            Console.WriteLine($"{Cadastro.Nome}");
        }

        listaFrutas.Add(fruta6);
        Console.WriteLine("NOVA FRUTA ADICIONADA");

foreach (var Cadastro in listaFrutas)
        {
            Console.WriteLine($"{Cadastro.Nome}");
        }
    }
}