using System.Reflection;
using TesteInstancia.Pasta;

var assembly = Assembly.GetExecutingAssembly();
var type = assembly.GetType("TesteInstancia.Pasta.ClasseQualquer");
var instance = (ClasseQualquer)Activator.CreateInstance(type);
instance?.Run();

Console.WriteLine("Fim");
