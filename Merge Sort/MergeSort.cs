using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class MergeSort
    {
       

        public int[] Merge(int[] firstArray,int[] secondArray)
        {
            int finalArrayLength=firstArray.Length+secondArray.Length;
            int[] result=new int[finalArrayLength];
            int indexLeft=0,indexRight=0,indexResult=0;
            while(indexLeft<firstArray.Length || indexRight<secondArray.Length)
                {
                   
                 /**Case1 : When both the arrays have elements.**/
                 if(indexLeft<firstArray.Length && indexRight<secondArray.Length)
                    {
                        /**Case : When item on left array is less then the item on the right array**/
                        if(firstArray[indexLeft]<=secondArray[indexRight])
                        {
                           result[indexResult]=firstArray[indexLeft];
                           indexLeft++;
                           indexResult++;
                        }
                        else
                        {
                           result[indexResult]=secondArray[indexRight];
                           indexRight++;
                           indexResult++;
                        }

                    }
                 else if(indexLeft<firstArray.Length)
                    {
                        result[indexResult]=firstArray[indexLeft];
                           indexLeft++;
                           indexResult++;
                     
                    }
                 else if(indexRight<secondArray.Length)
                    {
                        result[indexResult]=secondArray[indexRight];
                           indexRight++;
                           indexResult++;
                    }

                }
            return result;

        }
        public int[] MergeSortFunc(int[] inputArray)
        {
            int inputArraySize = inputArray.Length;
            int[] leftArray;
            int[] rightArray;
            
            if(inputArraySize<=1)
                return inputArray;
            //startIndex =inputArraySize>0 ? inputArray[0]:0;
            int middleIndex=inputArraySize/2;

            /**Prepare left array**/
            leftArray=new int[middleIndex];

            /**if array length is even number then the lenght of left array and right array will be same**/
            if(inputArraySize%2==0)
                rightArray=new int[middleIndex];
            else
                rightArray=new int[middleIndex+1];

            /**Populate the left array**/
            for(int i=0;i<middleIndex;i++)
                leftArray[i]=inputArray[i];

            /**populate right array**/
            int x=0;
            for(int i=middleIndex;i<inputArraySize;i++)
                {
                rightArray[x]=inputArray[i];
                x++;
                }
                
               
            /**Recursively sort the left array**/
            leftArray=MergeSortFunc(leftArray);
            /**Recursively sort the right array**/
            rightArray=MergeSortFunc(rightArray);
            /**Merge the two sorted arrays**/
            return Merge(leftArray,rightArray);

        }
    }
}
