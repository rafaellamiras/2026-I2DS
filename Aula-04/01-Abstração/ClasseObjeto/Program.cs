internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Classe -> é a abstração de um objeto do mundo real para o mundo computacional.
        Objeto -> É a instância de uma classe
        */

        // Instanciar um objeto do Tipo Aluno
        Aluno aluno01 = new Aluno();
        Aluno aluno02 = new Aluno();

        // Atribuiu os valores
        aluno01.Nome = "José da Silva";
        aluno01.RM = 2444;
        aluno01.DataNascimento = new DateOnly(2010,01,15);

        aluno02.Nome = "João dos Santos";
        aluno02.RM = 1234;
        aluno02.DataNascimento = new DateOnly(2006,12,07);

        //Executar os Metodos
        aluno01.ApresentarSe();
        aluno02.ApresentarSe();

    }
    // Declaração de uma classe
    public class Aluno // Declaração mde uma classe
    {
        // Atributos0 -> Características
        public string Nome {get; set; }
        public int RM {get; set; }
        public DateOnly DataNascimento {get; set; }

        // Métodos -> Ações ou Funcionalidades
        public void ApresentarSe(){
            Console.WriteLine($"Olá, meu nome é {Nome}, meu RM é {RM}, nasci na data {DataNascimento}");
        }
    }
}