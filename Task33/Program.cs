// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число
// в массиве.
//4; массив [6,7,19,345,3] -> нет
//3; массив [6,7,19,345,3] -> да

// Метод возврвщает массив на size элементов
int[] FillArrayWithRandomNumbers(int size, int minValue, int maxValue) 
{
   int[] array = new int[size];
   Random random = new Random();
   for(int i =0; i < size; i ++)
   {
      array [i] = random.Next(minValue, maxValue + 1);
   } 
   return array;
}
int[] arr = FillArrayWithRandomNumbers(10, -10, 10);// массив в 10 элементов с макс значением
// 10 и мин значение -10
Console.WriteLine($"Massiv [{string.Join(", ", arr)}]");// выводим исходный массив

Console.WriteLine("Enter looking for number");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsNumberInArray (arr, number);
if(result == true)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

bool IsNumberInArray(int[]array, int findNumber)
{
    bool flag = false; // eсли элемента нет, то false. Иначе true.
    for(int i = 0; i < array.Length; i++)
    {
        if (array [i] == findNumber)
        flag = true; // искомый элемент найден
        break; // если запишем не break, а else - flag = false, то следующая итерация может стереть true
    }
    return flag;
}



 