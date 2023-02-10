void FillRandomNumbers(int[] arr, int from, int to)
{
	Random rand = new Random();

	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rand.Next(from, to);
	}
}

void PrintNums(int[] arr)
{
	foreach (int val in arr)
	{
		Console.Write(val + " ");
	}
	Console.WriteLine();
}

bool ElementExists(int[] arr, int val)
{
	foreach (int el in arr)
	{
		if (el == val)
		{
			return true;
		}
	}

	return false;
}

int[] arr = new int[5];
int from = 0,
	to = 20;

FillRandomNumbers(arr, from, to);
PrintNums(arr);

int searchElement = new Random().Next(from, to);

Console.WriteLine($"Search element {searchElement}");

if (ElementExists(arr, searchElement))
{
	Console.WriteLine("Value exists");
}
else
{
	Console.WriteLine("Value not exists");
}
