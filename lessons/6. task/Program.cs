int num = new Random().Next(10, 100);

int num1 = num / 10;
int num2 = num % 10;

int max = num1;

if (num2 > num1)
{
	max = num2;
}

Console.WriteLine($"The maximum digit in number {num} is {max}");
