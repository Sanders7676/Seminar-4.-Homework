//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = new int[8];

int[] array = FillArray(arr);

Console.WriteLine("Массив выглядит следующим образом: ");

PrintArray (array);



//метод заполнения массива

int[] FillArray(int[] arr)
{
	Console.WriteLine("Введите числа для формирования массива:");

    for (int i = 0; i < 8; i++)
    {
		Console.Write($"Введите {i+1}-e числo: ");
	    int num = int.Parse(Console.ReadLine());
		arr[i] = num;
    }
    return arr;
}


//Метод печати массива

void PrintArray (int[] array)
{
	for (int i = 0; i < 8; i++)
	{
        Console.Write($"{array[i]}, ");
	}
}

