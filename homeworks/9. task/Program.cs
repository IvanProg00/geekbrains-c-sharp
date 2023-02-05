Console.Write("Enter coordinate A X: ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Enter coordinate A Y: ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Enter coordinate A Z: ");
int az = int.Parse(Console.ReadLine());

Console.Write("Enter coordinate B X: ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Enter coordinate B Y: ");
int by = int.Parse(Console.ReadLine());
Console.Write("Enter coordinate B Z: ");
int bz = int.Parse(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(
	Math.Pow(Convert.ToDouble(bx - ax), 2) +
	Math.Pow(Convert.ToDouble(by - ay), 2) +
	Math.Pow(Convert.ToDouble(bz - az), 2)
), 2);

Console.WriteLine("Distance between A and B is " + distance);
