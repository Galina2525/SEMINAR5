// Напишите программу замены элементов массива: положительные элементы замените на соответствующие
//отрицательные и наоборот
//[-4, -8, 8, 2 ]-> [4, 8, -8, -2 ]

//  Console.Write("Enter number of elemens of massiv:\t");
//  int elementCount = Convert.ToInt32(Console.ReadLine());
//  int [] array = new int [elementCount];

//  for(int i =0; i < array.Length; i++)
//  {
//     array [i] = new Random().Next(elementCount);
//  }

//  Console.WriteLine($"Massiv [{string.Join(", ", array)}]");
//  for(int i =0; i < array.Length; i++)
//  {
//     array [i] *= -1; 
//  }
 
//  Console.WriteLine($"New massiv [{string.Join(", ", array)}]");


int[] arr = FillArrayWithRandomNumbers(10, -10, 10);// массив в 10 элементов с макс значением
// 10 и мин значение -10
Console.WriteLine($"Massiv [{string.Join(", ", arr)}]");// выводим исходный массив
SwapSignOfArrayElements(arr);
Console.WriteLine($"New massiv [{string.Join(", ", arr)}]");//выводим измененный массив

// Метод возврвщает массив на size элементов
int[] FillArrayWithRandomNumbers(int size, int leftSize, int rightSize) 
{
   int[] array = new int[size];
   Random random = new Random();
   for(int i =0; i < size; i ++)
   {
      array [i] = random.Next(leftSize, rightSize + 1);
   } 
   return array;
}
void SwapSignOfArrayElements(int[] array) //метод замены знака 
{
   for(int i =0; i< array.Length; i++)
   {
      array[i] = - array[i];
      //array [i] = array [i] * -1;
   }
}

 