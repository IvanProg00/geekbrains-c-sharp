int num = new Random().Next(100, 1000);

int num1 = num / 100;
int num3 = num % 10;

Console.WriteLine($"The first and second digits from number {num} are {num1}{num3}");