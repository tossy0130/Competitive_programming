using System;
using System.Collections.Generic;
//　MAX, MIN
using System.Linq;

class Program {

    /*
    条件付き最大値 => 02

    数列に含まれる値で、k 以下であるもののうち、値が最大のものを出力
    入力例1
    5
    -5 11 3 -9 0
    -4

    出力例1
    -5

    */
    public void Min_get_02(int loop_num, string[] inputs, int target_min) {

        int[] arr = new int[loop_num];

        for(int i = 0; i < loop_num; i++) {
            arr[i] = int.Parse(inputs[i]);
        }

        //=== target_min 以下をリストへ　格納
           var ans_list = new List<int>();
        for(int i = 0; i < loop_num; i++) {
            if(arr[i] <= target_min) {
                ans_list.Add(arr[i]);
            }
        }

         int maximum = -1000000001;

         foreach(var val in ans_list) {
            maximum = Math.Max(maximum, val);
        //    Console.WriteLine(val.ToString());
        }

       Console.WriteLine(maximum);

    }

    /*

        条件付き最小値  ==> 01

        入力例1
        5
        -5 11 3 -9 0
        -4

        出力例1
        0
    */
     public void Min_get_01(int loop_num, string[] inputs, int target_min) {

        int[] arr = new int[loop_num];

        for(int i = 0; i < loop_num; i++) {
            arr[i] = int.Parse(inputs[i]);
        }

        //=== int型を格納するリストを宣言
        var ans_list = new List<int>();
        for(int i = 0; i < loop_num; i++) {
            if(arr[i] >= target_min) {
                ans_list.Add(arr[i]);
            }
        }

        //========== MAX , MIN ロジック
        int minimum = 1000000001;

        foreach(var val in ans_list) {
            minimum = Math.Min(minimum, val);
        //    Console.WriteLine(val.ToString());
        }

       Console.WriteLine(minimum);


    }

    //=== main 実行
     static void Main()
    {

        //==================== Min_get_01 start
        Program obj = new Program();

        int num_01 = int.Parse(Console.ReadLine());
        string[] arr = Console.ReadLine().Split(' ');
        int t_num_01 = int.Parse(Console.ReadLine());

        obj.Min_get_01(num_01, arr, t_num_01);
         //==================== Min_get_01 END

        //==================== Min_get_01 start
        Program obj_02 = new Program();

        int num_02 = int.Parse(Console.ReadLine());
        string[] arr_02 = Console.ReadLine().Split(' ');
        int t_num_02 = int.Parse(Console.ReadLine());

        obj_02.Min_get_02(num_02, arr_02, t_num_02);
         //==================== Min_get_01 END

    }

}