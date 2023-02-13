int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

bool IsTriangleValid(int side1, int side2, int side3)
{
	return side2 + side3 > side1 && side1 + side3 > side2 && side1 + side2 > side3;
}

int side1 = AskNumber("Enter length of the first side: ");
int side2 = AskNumber("Enter length of the second side: ");
int side3 = AskNumber("Enter length of the third side: ");

if (IsTriangleValid(side1, side2, side3))
{
	Console.WriteLine("Triangle is valid");
}
else
{
	Console.WriteLine("Triangle sides sizes are incorrect");
}
