using System;

using System.Collections.Generic;
//　MAX, MIN
using System.Linq;


class Program
{
    /**
        最大値、最小値　を出力  : 2変数の最大最小
    */
    public void Max_and_Min_01(string[] inputs) {
        
        int[] arr = new int [inputs.Length];
        for (int i = 0; i < 2; i++)
        {
            arr[i] = int.Parse(inputs[i]);
        }

        int maximum = -1000000001;
        int minimum = 1000000001;

        for (int i = 0; i < 2; i++)
        {
            maximum = Math.Max(maximum, arr[i]);
            minimum = Math.Min(minimum, arr[i]);
        }
        
        //=== 出力
        Console.WriteLine(maximum.ToString() + " " + minimum.ToString());
        
    }
    
    static void Main()
    {
        /**
        最大値、最小値　を出力  : 2変数の最大最小
        */ 
       string[] arr = Console.ReadLine().Split(' ');
       Program obj = new Program();
       obj.Max_and_Min_01(arr);

       //=== 最大値、最小値　を出力  : 2変数の最大最小 === END
        
    }
}