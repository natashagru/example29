// Напишите программу. которая задает массив из 8 элементов и выводит их на экран.
int[] ArrayInput()
{
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    {
    array[i] = int.Parse(Console.ReadLine()!);
    }
return array;
}
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]}");
if (i != array.Length - 1)
{
Console.Write(", ");
}
}
}

Console.Clear();
Console.WriteLine("Введите через Enter 8 цифр");
int[] ArrayResult = ArrayInput();
PrintArray(ArrayResult);

