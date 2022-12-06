//Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
//и метод который возводит число A в натуральную степень B. 
//Задание должно быть выполнено в методе. 
//В методе не должно быть вывода в консоль. 
//Не использовать Math.Pow()


Console.Write("Введите первое число: ");

int numberA = InputInt();

Console.Write("Введите второе число: ");

int numberB = InputInt();

int numberToPower = RaisingNumberToPower(numberA, numberB);

Console.Write($"{numberA} в степени {numberB} равно {numberToPower}.");


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


//Метод возведения числа А в степень В

int RaisingNumberToPower(int numberA, int numberB)
{
    for (int result = numberA, count = 1; count < numberB; result = result * numberA, count++)
    {
        
        return result;
    }

}