internal class Program
{
    private static void Main(string[] args)
    {
        Personagem personagem1 = new Personagem("Mago", 50, 70, 30, 80, 50 );
        Personagem personagem2 = new Personagem("Elfo", 10, 30, 30, 70, 60 );
        Personagem personagem3 = new Personagem("Cavaleiro", 70, 70, 20, 90, 50 );

        Console.WriteLine("=== APRESENTAÇÃO DOS PERSONAGENS ===");

        Console.WriteLine("\n Personagem 1");
        Console.Write($"Nome: {personagem1.Nome} | Nível: {personagem1.Nivel} | Força: {personagem1.Forca} | Agilidade: {personagem1.Agilidade} | Inteligencia: {personagem1.Inteligencia} | Vida: {personagem1.Vida} ");
    }
    public class Personagem
    {
        public string Nome {get; private set;}
        public int Nivel {get; private set;}
        public int Forca {get; private set;}
        public int Agilidade {get; private set;}
        public int Inteligencia {get; private set;}
        public int Vida {get; private set;}

        public Personagem(string nome, int nivel, int forca, int agilidade, int inteligencia, int vida)
        {
            this.Nome = nome;
            this.Nivel = nivel;
            this.Forca= forca;
            this.Agilidade = agilidade;
            this.Inteligencia = inteligencia;
            this.Vida = vida;
        }

        

        
        
    }

    
}