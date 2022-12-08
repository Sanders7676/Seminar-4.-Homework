//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = new int[8];

int[] array = FillArray(arr);

Console.WriteLine("Массив выглядит следующим образом: ");

PrintArray(array);



//метод заполнения массива

int[] FillArray(int[] arr)
{
    Console.WriteLine("Введите числа для формирования массива:");

    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Введите {i + 1}-e числo: ");
        int num = int.Parse(Console.ReadLine());
        arr[i] = num;
    }
    return arr;
}


//Метод печати массива

void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}




// Семинар 5

//Задача 34:
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//
//[345, 897, 568, 234] -> 2




Console.Write("Введите количество элементов в массиве: ");

int arrayLength = InputInt();

int[] initialArray = GenerateArray(array);

Console.WriteLine("Наш массив выглядит следующим образом:")

PrintArray(initialArray);

int quantityEvenNumbers = GetQuantityEvenNumbersInArray(array);

Console.WriteLine($"Сумма четных элементов в массиве равна {quantityEvenNumbers}.");




// Метод для приема чисел, вводимых через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}




// Метод формирования массива


int[] GenerateArray(int arrayLength)
{
    Random random = new Random();

    int[] array = new int[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}



// Метод подсчета количества четных элементов в массиве


int GetQuantityEvenNumbersInArray(int[] array)
{
    int quantity = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 = 0)
        {
            quantity += array[i];
        }
    }
    return quantity;
}



//Метод печати массива

void PrintArray(int[] array)
{
   Console.WriteLine($"[{string.Join(" ,", initialArray)}]");
}



//__________________________________________________________________
//__________________________________________________________________



//Задача 36:
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных индексах.
//
//[3, 7, 23, 12] -> 19
//
//[-4, -6, 89, 6] -> 0



int[] array = GenerateArray(-10, 10, 12);

PrintArray(array);

int SumOfElementsWithOddIndex = GetSumOfElementsWithOddIndex (array)

Console.WriteLine($"Сумма элементов массива, имеющих нечетный индекс равна {SumOfElementsWithOddIndex}.");




// Метод формирования массива


int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}



// Метод подсчета суммы элементов массива с нечетным индексом


int GetSumOfElementsWithOddIndex (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}




//___________________________________________________________________________________
//___________________________________________________________________________________


//Задача 38:
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива. 
//Не использовать готовые методы Min и Max
//
//[3 7 22 2 78] -> 76


int[] array = GenerateArray(-10, 10, 12);

Console.WriteLine("Наш массив выглядит следующим образом:");

PrintArray(array);

int minimalNumberInArray = GetMinimalNumberInArray (array);

int maximalNumberInArray = GetMaximalNumberInArray (array);

int result = maximalNumberInArray - minimalNumberInArray;

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result}.");




// Метод для приема чисел, вводимых через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}




// Метод формирования массива


int[] GenerateArray(int arrayLength)
{
    Random random = new Random();

    int[] array = new int[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}




//Метод нахождения минимального элемента массива:

int GetMinimalNumberInArray (int[] array)
{
    int minNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}



//Метод нахождения максимального элемента массива:

int GetMaximalNumberInArray (int[] array)
{
    int maxNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > minNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}


//_______________________________________________________________
//_______________________________________________________________


//Задача 38
//Вариант 2



Console.Write("Введите количество элементов в массиве: ");



int arrayLength = InputInt();


Console.Write("Введите крайний левый элемент массива: ");


int zeroIndex = InputInt();


Console.Write("Введите крайний правый элемент массива: ");


int pastIndex = InputInt();


if(zeroIndex >= pastIndex || pastIndex - zeroIndex < arrayLength)
{
	Console.Write("Массив задан неверно!");
	break;
}

Console.WriteLine("Наш массив выглядит следующим образом:");

PrintArray(array);

int minimalNumberInArray = GetMinimalNumberInArray (array);

int maximalNumberInArray = GetMaximalNumberInArray (array);

int result = maximalNumberInArray - minimalNumberInArray;

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result}.");




// Метод для приема чисел, вводимых через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}




// Метод формирования массива


int[] GenerateArray(int arrayLength, int zeroIndex, int pastIndex)
{
    Random random = new Random();

    int[] array = new int[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(zeroIndex, pastIndex + 1);
    }
    return array;
}


//____________________
//____________________

//Задача 38
//Вариант 3



int[] arr = new int[];

Console.WriteLine("Наш массив выглядит следующим образом:");

PrintArray(array);

int minimalNumberInArray = GetMinimalNumberInArray (array);

int maximalNumberInArray = GetMaximalNumberInArray (array);

int result = maximalNumberInArray - minimalNumberInArray;

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result}.");





// Метод формирования массива (другой)


int[] GenerateArray(int[] arr)
{
    	Console.WriteLine("Введите параметры для формирования массива:");

	Console.Write("Введите количество элементов в массиве: ");

	int arrayLength = InputInt();

	Console.Write("Введите крайний левый элемент массива: ");

	int zeroIndex = InputInt();

	Console.Write("Введите крайний правый элемент массива: ");

	int pastIndex = InputInt();

	if(zeroIndex >= pastIndex || (pastIndex - zeroIndex) < arrayLength)
	{
		Console.Write("Массив задан неверно!");
		break;
	}
	
	Random random = new Random();
   	
	for (int i = 0; i < arrayLength; i++)
    	{
        	array[i] = random.Next(zeroIndex, pastIndex + 1);
    	}
    	return array;
}




// Метод для приема чисел, вводимых через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}




//Метод нахождения минимального элемента массива:

int GetMinimalNumberInArray (int[] array)
{
    int minNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }

    return minNumber;
}



//Метод нахождения максимального элемента массива:

int GetMaximalNumberInArray (int[] array)
{
    int maxNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > minNumber)
        {
            maxNumber = array[i];
        }
    }

    return maxNumber;
}
