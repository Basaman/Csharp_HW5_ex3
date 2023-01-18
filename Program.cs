//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

int lenght = GetArrayLenghtFromUser("Введите длину массива: ");
int[] array = GetRandomArray(lenght, -100, 101);
int maxArrayValue = GetMaxArrayValue(array);
int minArrayValue = GetMinArrayValue(array);

Console.WriteLine("Выполняется создание массива... ");
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}] -> {maxArrayValue - minArrayValue}");

int GetArrayLenghtFromUser(string lenghtMessage)
{
    Console.Write(lenghtMessage);
    int userInput = int.Parse(Console.ReadLine() ?? "");
    return userInput;
}

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }
    return result;
}

int GetMaxArrayValue(int[] array)
{
    int max = array[0];
    for (int i = 0; i < lenght; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int GetMinArrayValue(int[] array)
{
    int min = array[0];
    for (int i = 0; i < lenght; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}