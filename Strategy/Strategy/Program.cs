// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("\nSTRATEGY DESIGN PATTERN \n");


/*
var context = new Parent();

context.SetStrategy(new StrategyC());
Console.WriteLine(context.ExecuteStrategy());
*/


var context = new Parent(new StrategyB());
Console.WriteLine(context.ExecuteStrategy());