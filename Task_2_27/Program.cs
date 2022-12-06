//Задача 27
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11 ; 82 -> 10 ; 9012 -> 12


Console.Write("Введите число: ");

int number = InputInt();

int sumOfDigitsInNumber = SumOfDigitsInNumber(number);

Console.Write($"Сумма цифр в числе {number} равна {sumOfDigitsInNumber}.");


//Метод для приема чисел, вводимых через консоль

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


// Метод нахождения суммы цифр в числе


int SumOfDigitsInNumber(int number)
{
    int result = 0;

    for (int temp = number; temp > 0; temp = temp / 10)
    {
        result = result + temp % 10;
    }

    return result;
}
