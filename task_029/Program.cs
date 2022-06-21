/* Напишите программу, которая задаёт массив из 8 случайных целых чисел
и выводит отсортированный по модулю массив.
*/
Console.WriteLine("Задача 029");
int[] array = Array(8);
Method(array);
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}


void Method (int[] arr){
int temp;
for (int i = 0; i < arr.Length-1; i++)
{
    for (int j = i+1; j < arr.Length; j++)
    {
         if (Math.Abs(arr[i]) > Math.Abs(arr[j]))
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
}


int[] Array(int length) {
    Random rand = new Random();
    int[] arr = new int[length];
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = rand.Next(-10,10);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}