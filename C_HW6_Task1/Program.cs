// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Функция запроса и считывания данных введенных пользователем
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}


//Функция создания массива с указанием длинны (количества элементов) для заполнения его пользователем
int[] CreateArray(int length)
{
    int[] array = new int[length];    // объявляем массив с указанием длинны
    for (int i = 0; i < length; i++)
    {
        array[i] = ReadInt($"Введите значение элемента A{i + 1} = ");
    }
    return array;
}


// Функция вывод на печать массива с указанием значений для каждого элемента
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Значение элемента массива A{i +1} = {array[i]}\t");
    }
    System.Console.WriteLine();
}

//Функция поиска количества положительных чисел в массиве
int PositiveNumber(int[] array)

{
    int positive = 0;
    for (int i = 0; i < array.Length; i = i + 1)
    {
        if (array[i] > 0)
        {
            positive++;
        }
    }
    return positive;
}

int length = ReadInt("Введите размер массива = ");
int[] array = CreateArray(length);
System.Console.WriteLine();
System.Console.WriteLine("В введенном Вами массиве:");
PrintArray(array);
System.Console.WriteLine($"{PositiveNumber(array)} элементов больше 0");