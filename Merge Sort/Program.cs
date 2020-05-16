using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
      
            int inputArraySize;
            int[] array;
            MergeSort _mergeSort=new MergeSort();
            int[] result;
            Random random = new Random();
            StringBuilder stringBuilder=new StringBuilder();
            Console.WriteLine("Do you wish to entry array size manually (Input 1) or let the computer do it for you? (Input 2) ");
            int optionselected= Convert.ToInt32(Console.ReadLine());
            switch(optionselected)
                { case 1 : Console.WriteLine("You have choosen to input size and element of the array manually");
                    Console.WriteLine("Please enter size of the array");
                    inputArraySize=Convert.ToInt32(Console.ReadLine());
                    array=new int[inputArraySize];
                     result =new int[inputArraySize];
                     Console.WriteLine("Please enter elements of the array");
                    for(int i = 0;i<inputArraySize;i++)
                    {
                       array[i]= Convert.ToInt32(Console.ReadLine());
                       stringBuilder.Append(array[i]);
                       stringBuilder.Append(" | ");
                    }
                    Console.WriteLine("Entered elements in the input array are :"); 
                    Console.WriteLine(stringBuilder.ToString());
                   
                    Console.WriteLine("Performing merge sort"); 
                    result= _mergeSort.MergeSortFunc(array);
                    stringBuilder.Clear();
                     Console.WriteLine("Sorting is done.Here is the sorted array"); 
                    for(int i = 0;i<inputArraySize;i++)
                    {
                        stringBuilder.Append(result[i]);
                        stringBuilder.Append(" | ");
                    }
                     Console.WriteLine(stringBuilder.ToString());
 
                  break;
                  case 2 :  Console.WriteLine("You have choosen to let computer prepare the input array for you and do the merge sort");
                      
                      
                    Console.WriteLine("Selecting size of an array");
                    inputArraySize=random.Next(10); 
                    Console.WriteLine("Size selected : " + inputArraySize);
                     array=new int[inputArraySize];
                     result =new int[inputArraySize];
                     Console.WriteLine("Entering elements of the array");
                    for(int i = 0;i<inputArraySize;i++)
                    {
                       array[i]= random.Next(0,100);
                       stringBuilder.Append(array[i]);
                        stringBuilder.Append(" | ");
                    }
                    Console.WriteLine("Entered elements in the input array are :"); 
                    Console.WriteLine(stringBuilder.ToString());
                   
                    Console.WriteLine("Performing merge sort"); 
                    result= _mergeSort.MergeSortFunc(array);
                    stringBuilder.Clear();
                     Console.WriteLine("Sorting is done.Here is the sorted array"); 
                     for(int i = 0;i<inputArraySize;i++)
                    {
                        stringBuilder.Append(result[i]);
                        stringBuilder.Append(" | ");
                    }
                     Console.WriteLine(stringBuilder.ToString());
                     
                  break;
                  default : Console.WriteLine("You havent choosen from the option available"); break;
                }                  
            Console.ReadLine();
        }
    }
}
