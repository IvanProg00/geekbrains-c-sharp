int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

string IntoBinary(int num)
{
	string res = String.Empty;

	while (num > 0)
	{
		res = num % 2 + res;
		num /= 2;
	}

	return res;
}

int num = AskNumber("Enter number: ");
string binary = IntoBinary(num);
Console.WriteLine(binary);
