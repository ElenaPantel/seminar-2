// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Enter several negetives and positive numbers: ");
string numbers = Console.ReadLine();
string[] newNumbers = new string[numbers.Length];
int n = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
    if (numbers[i] == ',')
    {
        n++;
    }
    else
    {
        newNumbers[n] = newNumbers[n] + $"{numbers[i]}";
    }
}
n++;
int[] resultNumbers = new int[n];
PrintArray(resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < n; i++)
{
    if (resultNumbers[i] > 0)
    {
        sum++;
    }
}
Console.Write("--> " + sum);

void PrintArray(int[] array, string[] string1)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(string1[i]);
        Console.Write(array[i] + "  ");
    }
}