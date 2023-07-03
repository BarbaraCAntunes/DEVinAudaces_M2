using Animal;

internal class Program
{
    private static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro { Nome = "Rex", Idade = 5 };
        cachorro.EmitirSom(); 

        Gato gato = new Gato { Nome = "Felix", Idade = 3 };
        gato.EmitirSom(); 
    }
}