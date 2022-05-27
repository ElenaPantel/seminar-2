// Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenArray()
{
    Console.Write("Enter the number of elements in the array: ");
    int N = int.Parse(Console.ReadLine());

    int[] array = new int[N];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100);
    }
    return array;
}
int[] newArray = GenArray();
var str = string.Join(", ", newArray);
Console.Write(str);
Console.Write($" -> [{str}]");
