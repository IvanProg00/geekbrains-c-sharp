Console.Write("Enter coordinate A X: ");
double ax = double.Parse(Console.ReadLine());
Console.Write("Enter coordinate A Y: ");
double ay = double.Parse(Console.ReadLine());


Console.Write("Enter coordinate B X: ");
double bx = double.Parse(Console.ReadLine());
Console.Write("Enter coordinate B Y: ");
double by = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(ax-bx, 2) + Math.Pow(ay-by, 2));

Console.WriteLine($"Distance between A and B is: {distance}");
