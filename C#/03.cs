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

    /*
        偶数が何番目にあるか：
        
    入力例1
    5
    1 3 5 6 8

    出力例1
    4
    */
    public void Even_search_01(int loop_num, string[] inputs) {

            //=== 配列作成
            int[] arr = new int[loop_num];

            //=== string => int へパース
            for(int i = 0; i < loop_num; i++) {
                arr[i] = int.Parse(inputs[i]);
            }

            // ====== 偶数判定ロジック
            int result_num = 0;
            for(int i = 0; i < loop_num; i++) {
                if(arr[i] % 2 == 0) {
                    result_num = i + 1;
                    break;
                }
            }

            Console.WriteLine(result_num);
    }

    /*
        奇数の最後の index を出力

        入力例1
        5
        1 3 5 6 8

        出力例1
        3
    */
      public void Odd_search_02(int loop_num, string[] inputs) {

        int[] arr = new int[loop_num];

        //=== string => int 変換
        for(int i = 0; i < loop_num; i++) {
            arr[i] = int.Parse(inputs[i]);
        }

        int result_num = 0;
        //=== 期数ロジック部分 ===== 最後に現れる奇数
        for(int i = 0; i < loop_num; i++) {
            if(arr[i] % 2 != 0 && arr[i] != 1) {
                result_num = i + 1;
            }
        }

        Console.WriteLine(result_num);
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

        //========== Odd_search_01 実行 start ===========
        int num = int.Parse(Console.ReadLine());
        string [] arr = Console.ReadLine().Split(' ');

        Program obj_4 = new Program();
        obj_4.Even_search_01(num, arr);
         //========== Odd_search_01 実行 END ===========

        //========== Odd_search_02 start ================
        int num_5 = int.Parse(Console.ReadLine());
        string[] arr = Console.ReadLine().Split(' ');

         Program obj_5 = new Program();
         obj_5.Odd_search_02(num_5, arr);
         //========== Odd_search_02 END ================
    }
}