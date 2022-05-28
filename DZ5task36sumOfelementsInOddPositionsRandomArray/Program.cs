// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] InitArray(int length)  //  fill method with random numbers
{
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(-100, 100); 
}

return arr;
}

void PrintArray(int [] arr)   //print method in console
{
foreach(int item in arr)
Console.Write($"{item} ");
}

int Sum(int [] arr)  // sum of elements on the odd positions
{
    int result = 0;
    for(int i = 1; i < arr.Length; i = i + 2)
    {
       result += arr[i];
    }
    return result;
}

Console.Write("Enter the size of array: ");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.Write("Array: ");
PrintArray(arr);
Console.WriteLine(" ");
Console.Write("Sum of the elements on the odd positions: ");
int count = Sum(arr);
Console.WriteLine(count);


// int[] CreateArray(int[]array, int length)  // fill array with random elements method
// {
//     for (int i = 0; i < length; i++)
//     {
//         Random arrayValues = new Random();
//         array[i] = arrayValues.Next(-100,100);
//     }
//     Console.Write($" -> [{array}]");
//     return array;    
// }