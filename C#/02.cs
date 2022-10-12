using System;

// リストを使う
using System.Collections.Generic;


class Program
{   

    /**
        線形探査 01  

        入力例1
        5
        -3 2 0 -1 2
        2

        出力例1
        2
     
    */
  public void linear_exploration_01(int loop_num,string[] inputs, int target ) {
        
         int [] arr = new int[loop_num];
         int result_num = 0;
         
         //=== 配列へ値格納
         for(var i = 0; i < loop_num; i++) {
            arr[i] = int.Parse(inputs[i]); // 配列を string => int 型へ変換
         }
        
        //=== 判定ロジック
        for(int i = 0; i < loop_num; i++) {
            if(arr[i] == target) {
                result_num = result_num + i;
                break;
            } else {
                no_num = 0;
            }
        }
        
        if (result_num > 1) {
             Console.WriteLine(result_num);
        } else {
             Console.WriteLine(no_num);
        }
    }

    /**
      線形探査 02: 指定された値の位置 1    

      loop_num , ループ回数
      inputs , 配列
      target , 線形探査で、見つける　対象の値

      入力例1
       5
       -3 2 0 -1 2
       2

      出力例1
      2

    */
    public void linear_exploration_02(int loop_num, string[] inputs, int target) {
        
        int[] arr = new int [loop_num];
        int result_num = 1;
        
        //=== 配列へ格納  string => int へ パース
        for(int i = 0; i < loop_num; i++) {
            arr[i] = int.Parse(inputs[i]);
        }
        
        //=== 判定ロジック
        for(int i = 0; i < loop_num; i++) {
            if(arr[i] == target) {
                result_num = result_num + i;
                break;
            }
        }
        
        //=== index を返す
        Console.WriteLine(result_num);
        
    }

    /**
        線形探査 03 : 指定された値の位置 2 

        入力例1
        5
        -3 2 0 -1 2
        2

        出力例1
        5

    */
    public void linear_exploration_03(int loop_num, string[] inputs, int target) {

        int[] arr = new int [loop_num];
        int result_num = 0; // 
        int non_num = 0; // target がない場合は 0 を返す

        // === 配列の値をパース
        for(int i = 0; i < loop_num; i++) {
            arr[i] = int.Parse(inputs[i]);  // string => int へ パース
        }

        // === 線形探査 開始
        for(int i = 0; i < loop_num; i++) {
            if(arr[i] == target) {
                result_num = i;
            } 
        }

        // === 線形探査で見つからなかった場合は、0 を返す。 
        // 見つかった場合は、見つけた　index を返す。 
        if(result_num > 0) {
            Console.WriteLine(result_num);
        } else {
            Console.WriteLine(non_num);
        }

    }

      /**
        線形探査 04 : 【指定された値の探索】指定された値の位置 3  

        入力例1
        5
        -3 2 0 -1 2
        2

       出力例1
        2
        5
    */
    public void linear_exploration_04(int loop_num,  string[] inputs, int target) {
        
        int[] arr = new int [loop_num];

        //=== string -> int へ パース
        for(int i = 0; i < loop_num; i++) {
            arr[i] = int.Parse(inputs[i]);
        }


        // int型を格納するリストを宣言
        var ans_list = new List<int>();
        for(int i = 0; i < loop_num; i++) {
            if(arr[i] == target) {
                // === リストへ 整数を追加
                ans_list.Add(i + 1);
            }
        }

        // リストが空ならなにもしない
        if(ans_list.Count == 0) {

        } else {
            foreach(var val in ans_list) {
                Console.WriteLine(val.ToString());
            }
        }

    }

    static void Main()
    {

        //========================== 線形探索 ==============================
        //=============== 線形探索 01　function 実行
        var n = int.Parse(Console.ReadLine());
      //  var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        string[] inputs = Console.ReadLine().Split(' ');
        var k = int.Parse(Console.ReadLine());
        
        Program obj = new Program();
        obj.linear_exploration_01(n,inputs,k);
         //=============== 線形探索 01　function 実行 =============== END


        //=============== 線形探索 02 function 実行
        var n_2 = int.Parse(Console.ReadLine());
        string[] inputs_2 = Console.ReadLine().Split(' ');
        var k_2 = int.Parse(Console.ReadLine());
        
        Program obj_2 = new Program();
        obj_2.linear_exploration_02(n_2, inputs_2, k_2);
         //=============== 線形探索 02　function 実行 =============== END

         //=============== 線形探査 03 function 実行 
         var n_3 = int.Parse(Console.ReadLine());
         string[] inputs_3 = Console.ReadLine().Split(' ');
         var k_3 = int.Parse(Console.ReadLine());

         Program obj_3 = new Program();
         obj_3.linear_exploration_03(n_3, inputs_3, k_3);
         //=============== 線形探索 03　function 実行 =============== END


    }
}