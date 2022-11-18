// Задайте массив вещественных чисел. Найдите разницу между макс. и мин. элементами массива
//[3 7 22  2 78] -> 76

double [] array = new double [4];
Random random = new Random();
double max = array[0];
double min = array[0];
for(int i =0; i < array.Length; i++)
{
    array [i] = random.Next(3, 32);
    
}
Console.WriteLine($"Massiv [{string.Join(", ",  array)}]");
for(int i =1; i < array.Length; i++)
{
 if (array[i] > max)
    {
        max = array[i];

    }
    else
     if (min > array [i])
    {
    min = array[i];
    }
}

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
Console.WriteLine(max-min);
