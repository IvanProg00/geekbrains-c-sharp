const int X_COORD = 0;
const int Y_COORD = 1;

double AskNumber(string msg)
{
	Console.Write(msg);
	return double.Parse(Console.ReadLine());
}

double[] FindIntersectionPoint(double b1, double b2, double k1, double k2)
{
	double[] res = new double[2];

	res[X_COORD] = (b1 - b2) / (k2 - k1);
	res[Y_COORD] = k1 * res[X_COORD] + b1;

	return res;
}

double b1 = AskNumber("Enter point b1: "),
	b2 = AskNumber("Enter point b2: "),
	k1 = AskNumber("Enter point k1: "),
	k2 = AskNumber("Enter point k2: ");



double[] coords = FindIntersectionPoint(b1, b2, k1, k2);
Console.WriteLine(String.Join(", ", coords));
