// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке[10,99] (minValue, maxValue)
// [5,18,123,6,2] -> 1
//[1,2,3,6,2] -> 0
//[10,11,12,13,14] ->5

int [] array = new int [123];
int count = 0;
for(int i =0; i < array.Length; i++)
{
 array [i] = new Random().Next(-15,123);
 if( array[i] > 10 & array[i] < 99)
 {
    count++;
 }

}
Console.WriteLine($"Massiv [{string.Join(", ", array)}]");// выводим исходный массив

Console.WriteLine($"Number of digits from 10 till 99 is {count}");
