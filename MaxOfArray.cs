using System;

public class MaxOfArray
{
    public static void Main(string[] args)
    {
        
	int[] arr = new int[5] { -2, -4, 8, 9, 0 };
        int i, max = arr[0];
        for(i=0;i<arr.Length; i++){
            if (arr[i] > max){
                max = arr[i];
            }
        }
        Console.WriteLine("Arraydaki en boyuk eded : "+ max);
    }
}