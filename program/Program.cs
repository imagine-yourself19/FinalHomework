Console.WriteLine("Напишите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[n];
Console.WriteLine("Напишите элементы массива: ");
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = Convert.ToString(Console.ReadLine());
}
string[] array2 = new string[array1.Length];
