using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;

using TestesDI;
using TestesDI.Strategies;

/*
 * Utilizando o container do SimpleInjector, consigo fazer uma coleção e buscar todas as Strategies.
 */

var container = new Container();
container.Collection.Register<IStrategy>(typeof(StrategyA), typeof(StrategyB));
container.Register<ClasseComum>();

var classeComum = container.GetService<ClasseComum>();
classeComum?.Handle();