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
    /*
       最大値、最小値　を出力 : 10変数の最大最小
    */
     public void Max_and_Min_02(string[] inputs) {
        
        int[] arr = new int[inputs.Length];
        
        for(int i = 0; i < inputs.Length; i++) {
            arr[i] = int.Parse(inputs[i]);
        }
        
        //========== MAX , MIN ロジック
        int maximum = -1000000001;
        int minimum = 1000000001;

        for (int i = 0; i < inputs.Length; i++)
        {
            maximum = Math.Max(maximum, arr[i]);
            minimum = Math.Min(minimum, arr[i]);
        }
        
        Console.WriteLine(maximum.ToString() + " " + minimum.ToString());
    }

     /*
    最大値、最小値　を出力  :【最大最小】n 変数の最大最小
    */
    public void Max_and_Min_03(int loop_num, string[] inputs) {
            
            int[] arr = new int[loop_num];
            
            for(int i = 0; i < loop_num; i++) {
                arr[i] = int.Parse(inputs[i]);
            }
            
            //========== MAX , MIN ロジック
            int maximum = -1000000001;
            int minimum = 1000000001;
    
            for (int i = 0; i < inputs.Length; i++)
            {
                maximum = Math.Max(maximum, arr[i]);
                minimum = Math.Min(minimum, arr[i]);
            }
        
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

        //=== Max_and_Min_02 実行 ====================
        string[] inputs = Console.ReadLine().Split(' ');
       
        Program obj_2 = new Program();
        obj_2.Max_and_Min_02(inputs);
       //=== Max_and_Min_02 実行 END ====================

        //=========== 最大値、最小値　を出力  :【最大最小】n 変数の最大最小 ========== 
         int num = int.Parse(Console.ReadLine());
         string[] inputs_03 = Console.ReadLine().Split(' ');
       
        Program obj_3 = new Program();
        obj_3.Max_and_Min_03(num, inputs_03);
        // ========================== END ================================================
        
    }
}