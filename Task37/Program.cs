// Найдите произведение пар чисел в одномерном массиве. Парой считается первый и последний 
//элемент, второй и предпоследний и т.д. Результат запишите в новом массиве
//[1,2,3,4,5] -> [5,8,3]
//[6,7,3,6] -> 36  21

int[] arr = {6 ,7, 3, 6}; // исходный массив (пока без метода)

int newLength = arr.Length / 2 + arr.Length % 2; 

int [] resultArr = new int[newLength]; // объявляем новый массив

for(int i = 0; i < newLength; i++)
{
 resultArr[i] = arr[i] * arr[arr.Length - 1 - i];

}
if(arr.Length % 2==1)//если длинна массива нечетная
{
    resultArr[resultArr.Length-1] = arr[arr.Length/2]; //то последний элемент нового массива
    //переписывается с середины исходного массива
}

Console.WriteLine($"Massiv [{string.Join(", ",  resultArr)}]");// выводим новый массив