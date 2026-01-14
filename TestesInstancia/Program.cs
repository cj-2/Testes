using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using TestesInstancia.Pasta;

var assembly = Assembly.GetExecutingAssembly();
var type = assembly.GetType("TestesInstancia.Pasta.ClasseQualquer");
var classeQualquer = (ClasseQualquer)Activator.CreateInstance(type);

classeQualquer?.Run("Teste!");

// Exemplo resolvendo inejeções:

var serviceProvider = new ServiceCollection()
    .AddScoped<ClasseQualquer>()
    .BuildServiceProvider();

var typeClass = Type.GetType("TestesInstancia.Pasta.ClasseQualquerComInjecao");

var serviceScopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();
var serviceScope = serviceScopeFactory.CreateScope();

/*
 * Aqui eu obti o serviceProvider pelo serviceScope, porém só fiz dessa forma por causa
 * do exemplo do código real que estou seguindo que busca IServiceScopeFactory por DP
 * no construtor da classe, não tendo necessidade de criar um serviceProvider manualmente (como fiz).
 *
 * Nesse meu código poderia ser resumido apenas passando o serviceProvider:
 *  Ex: (ClasseQualquerComInjecao)ActivatorUtilities.CreateInstance(serviceProvider, typeClass)
 */
var classeQualquerComInjecao = (ClasseQualquerComInjecao)ActivatorUtilities
    .CreateInstance(serviceScope.ServiceProvider, typeClass);

classeQualquerComInjecao.Run();