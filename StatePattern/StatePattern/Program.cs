// See https://aka.ms/new-console-template for more information

using StatePattern;

Context context = new Context(5);

Console.WriteLine("=========");
// 1
context.InsertQuarter();
context.TurnCrank();

Console.WriteLine("=========");
// 2
context.InsertQuarter();
context.EjectQuarter();
context.TurnCrank();

Console.WriteLine("=========");
// 3
context.InsertQuarter();
context.TurnCrank();
context.InsertQuarter();
context.TurnCrank();
context.EjectQuarter();

Console.WriteLine("=========");
// 4
context.InsertQuarter();
context.InsertQuarter();
context.TurnCrank();
context.InsertQuarter();
context.TurnCrank();
context.InsertQuarter();
context.TurnCrank();
context.EjectQuarter();

