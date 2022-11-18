// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов
// стоящих на нечетных позициях

int[] array = new int [8];
Random random = new Random();
int sum = 0;
for (int i =0; i < array.Length; i++)
{
    array [i] = random.Next(-2, 4);
    if(i % 2 != 0 )
    {
    sum = sum + array[i];
    }
}
Console.WriteLine($"Massiv [{string.Join(", ", array)}]");// выводим исходный массив
Console.WriteLine(sum);
