Console.Write("Enter three digit number: ");
int num = int.Parse(Console.ReadLine());

int res = num / 10 % 10;

Console.WriteLine($"Second number of number {num} is {res}");
