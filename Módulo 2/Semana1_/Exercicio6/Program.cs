internal partial class Program
{
  private static void Main(string[] args)
  {
    string frase = "A linguagem de programação C# é muito poderosa";
    List<string> palavras = new List<string>();
    string[] partes = frase.Split(' ');

    foreach (string palavra in partes)
    {
      palavras.Add(palavra);
    }



    Console.WriteLine(palavras.Last());
  }
}