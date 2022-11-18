double [] array = {23, 56, 32, 12, 577};
double min = array[0];
double max = array[0];

for(int i =0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
else
   if(array [i] < min)
   {
     min = array[i];
   }

}
Console.WriteLine("min = "+ min);
Console.WriteLine("max = "+ max);
Console.Write($"result = {max - min}");
