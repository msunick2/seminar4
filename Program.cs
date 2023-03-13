// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write (array[i] + " ");
//     }
//     Console.WriteLine ();
// }

// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(size, minValue, maxValue));







//HOMEWORK

//#1
// Console.WriteLine("digit");
// int digit = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("degree");
// int degree = Convert.ToInt32(Console.ReadLine());

// int digitInDegree(int digit, int degree)
// {
//     int i = 0;
//     int temp = 1;
//     while (i < degree)
//     {   
//         temp = temp * digit;
//         i++;
//     }
//     return(temp);

// }


// Console.WriteLine(digitInDegree(digit, degree));

//#2


// Console.WriteLine("digit");
// int digit = Convert.ToInt32(Console.ReadLine());

// int number(int num)
// {
//     int sum = 0;
//     while(num / 10 != 0 || num%10 != 0)
//     {
//        sum = num%10 + sum;
//        num = num / 10;
//     }
//     return(sum);
// }

// Console.WriteLine(number(digit));