// تمرین 1 
// System.Console.WriteLine("please enter a number");
// int a=int.Parse(Console.ReadLine());
//  int z=0;
//  for (var i = 1; i <= a; i++)
// {
//     z=z+i;
//  }
//  System.Console.WriteLine(z);




// تمرین 2
// int [] x=new int[10];

// for (var i = 0; i <= 9; i++)
// {
//    System.Console.WriteLine("please enter a number: ");
//    x[i]=int.Parse(Console.ReadLine());
// }

// for (var i = 0; i < 9; i++)
// {
//    int maximumNumber=x.Max();
//    System.Console.WriteLine( "the largest number is: {0} ", maximumNumber);
//    break;
// }

// for (int i = 1; i <= 9; ++i) {
//     if (x[0] < x[i]) {
//       x[0] = x[i];
//     }
// System.Console.WriteLine(x[]);}

// تمرین 3
//  float[] x = new float[10];
//         int[] freq = new int[10];

//         Console.WriteLine("plaese enter a number: ");
//         for(int i = 0; i <= 9; i++)
//         {
//             Console.Write("Position {0}: ", i);
//             x[i] = float.Parse(Console.ReadLine());
//         }
// for (int i = 1; i <= 9; ++i) {
//     if (x[0] < x[i]) {
//       x[0] = x[i];
//     }
// }
//  for(int j = 0; j<= 9; j++)
//         {
            

//             for(int k = 0; k<= 9; k++)
//             {
                
//                 if(x[j] == x[k])
//                 {
//                     freq[j]++;
//                 }
//             }
//         }
//         Console.WriteLine("The number of times the largest number appears in the array is:");

//         for(int l = 1; l<= 9; l++)
//         {
//             Console.WriteLine("{0} appears {1} time(s)", x[0], freq[0]-1);
//             break;
//         }

// تمرین 4
// int []a = new int[10];
// int []x = new int[10];
// for (int i = 0; i <= 9; i++)
// {
//     System.Console.WriteLine("please enter a number: ");
//     x[i] = int.Parse(Console.ReadLine());

//    if (x[i]<10)
//    {
//     a[i]=x[i];
//    }
// }
// for (var i = 0; i < 10; i++)
// {
//     int maximumNumber=a.Max();
//     System.Console.WriteLine(maximumNumber);
//     break;
// }

// تمرین 8
// System.Console.WriteLine("number");
// int num = int.Parse(Console.ReadLine());
// int sum = 0;
// while(num > 0)
// {
//   sum = num % 10 +sum;
//   num /= 10;
// }
// Console.WriteLine(sum);

// تمرین 5
// using System.Linq;
// int []a = new int[5];
// int []x = new int[5];

// for (int i = 0; i <= 4; i++)
// {
//     System.Console.WriteLine("position-{0} ", i);
//     x[i] = int.Parse(Console.ReadLine());

   
//     if (x[i]>15)
//    {
//     a[i]=x[i];
    
//    }
   
// }
 
// int size = a.Length;
//      int sum = 0;
//      int average = 0;

//      for (int i = 0; i < size; i++)
//      {
//           sum += a[i];
//      }

//      average = sum /size; 

//      Console.WriteLine("The Sum Of Array Elements Is : " + sum);
//      Console.WriteLine("The Average Of Array Elements Is : " + average);




// double avg = Queryable.Average(a.AsQueryable());
//  double avg = 


// System.Console.WriteLine("the average is: {0}", avg);
