void NewArrayFormation(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Напишите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[n];
Console.WriteLine("Напишите элементы массива: ");
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = Convert.ToString(Console.ReadLine());
}
string[] array2 = new string[array1.Length];
NewArrayFormation(array1, array2);
PrintArray(array2);