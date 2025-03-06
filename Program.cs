using RationalNumbers;
using RationalNumbers.Task_3;
using System.Globalization;

Console.WriteLine("Task 1:");

RNClass rn = new RNClass(22, 11);
//RNClass rnErr = new RNClass(22, 0);
Console.WriteLine(rn.ToString());
//rn.Denominator = 54; //err
Console.WriteLine(rn.Numerator);

rn = new RNClass(0, 3);
Console.WriteLine(rn.ToString());
Console.WriteLine(rn.Numerator);
Console.WriteLine(rn.Denominator);

rn = new RNClass(1,2);
rn = rn*new RNClass(2,3);
Console.WriteLine(rn.ToString());

rn = new RNClass(-3,-4);
Console.WriteLine(rn.ToString());

Console.WriteLine("\nTask 2:");

var Eprinter = new EuropTimePrinter();
var Aprinter = new AmericanTimePrinter();

ConcreteDecorator cd1 = new ConcreteDecorator("###", Eprinter);
ConcreteDecorator cd2 = new ConcreteDecorator("***", Aprinter);

cd1.Print();
cd2.Print();

var cultureInfo = new CultureInfo("es-ES",false);
Console.WriteLine(cultureInfo.ToString());

Console.WriteLine("\nTask 3:");

var t = new Tree(1);
t.AddChild(new Tree(2));
t.AddChild(new Tree(3));
t.children[0].AddChild(new Tree(21));
t.children[0].AddChild(new Tree(22));
t.children[1].AddChild(new Tree(31));
t.children[1].AddChild(new Tree(32));

t.children[1].children[1].AddChild(new Tree(321));
t.children[0].children[1].AddChild(new Tree(221));
t.children[0].children[1].children[0].AddChild(new Tree(2211));


t.PrintTree();
