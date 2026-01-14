namespace TestesInstancia.Pasta;

public class ClasseQualquerComInjecao(ClasseQualquer classeQualquer)
{
    public void Run()
    {
        Console.WriteLine("Run da classe qualquer com injeção.");
        classeQualquer.Run();
    }
}
