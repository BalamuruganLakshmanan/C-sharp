using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickSort
{
    public class PartisionDetails
    {
      public static void MainMenu()
      {
        int[] list={18,19,1,5,7,3,20};
        Quick(list, 0, list.Length-1);
        System.Console.WriteLine("The sorted elements are shown below: ");
        foreach (var item in list)
            {
                Console.Write( item+" ");
            }
      }
        public static int PartisionMethod(int[] list,int left,int right)
        {    
             int temp;
            
            int pivot=list[left];
            while(true)
            {
                while(pivot>list[left])
                {
                    left=left+1;
                }
                while(pivot<list[right])
                {
                    right=right-1;
                }
                if(left<right)
                {
                    if(list[right]==list[left])
                    {
                        return right;
                    }
                    
                    temp=list[left];
                    list[left]=list[right];
                    list[right]=temp;
                    
                }
                else
                {
                    return right;
                }
            }
        }
    
        public static void Quick(int[] list,int left,int right)

        {
            if(left<right)
            {
                int pivot = PartisionMethod(list, left, right);
                 if(pivot>1)
                {
                    Quick(list, left, pivot-1);

                }
                if(pivot+1<right)
                {
                    Quick(list,pivot+1,right);
                }
            }
           
        }
    }
}