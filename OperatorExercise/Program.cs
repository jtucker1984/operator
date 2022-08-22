int a = 17;
var b = 4;

var div = a / b;
var mod = a % b;


Console.WriteLine($"{a}/{b} is {div} remainder {mod}.");

// Exercise 2



static double AreaOfCircle(double r)
{
  return Math.PI * r * r;
}

/*var answer = AreaOfCircle(13.0);
Console.WriteLine(answer);*/
Console.WriteLine("Enter the Radius");
var userEntry = double.Parse(Console.ReadLine());

Console.WriteLine(AreaOfCircle(userEntry)); 




































