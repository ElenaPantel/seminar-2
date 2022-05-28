// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Random rnd = new Random();
double[] nums = new double[10];
int n = nums.Length;
double min;
double max;
double diff;

for (int i = 0; i < n; i++)
{
    nums[i] = rnd.Next(0, 100);
}

min = nums[0];
max = nums[0];
for (int i = 0; i < n; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
    if (nums[i] < min)
    {
        min = nums[i];
    }
}

diff = max - min;
PrintArray(nums);
Console.WriteLine($"-> Difference between max element {max} and min element {min} of the array is: {diff}");

void PrintArray(double[] arr)
{
    string str = "[";

    for (int i = 0; i < arr.Length; i++)
    {
        str += $", {arr[i]}";
    }

    str = str.Remove(1, 2);
    // str += "]";
    Console.WriteLine($"Array: {str}]");
}