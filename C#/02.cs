using System;

class Program
{   

     /**
      線形探査 : 指定された値の位置 1    
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
        線形探査 01  
    */
  public void linear_exploration_01(int loop_num,string[] inputs, int target ) {
        
         int [] arr = new int[loop_num];
         
         int result_num = 0;
         
         //=== 配列へ値格納
         for(var i = 0; i < loop_num; i++) {
            arr[i] = int.Parse(inputs[i]); // 配列を string => int 型へ変換
         }
        
        //=== 判定ロジック
         for(var i = 0; i < loop_num; i++) {
            if(arr[i] == target) {
                result_num = result_num + 1;
            }
        }
        
        Console.WriteLine(result_num);
    }

    static void Main()
    {

        //========================== 線形探索 ==============================
        //=============== 線形探索 01
        var n = int.Parse(Console.ReadLine());
      //  var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        string[] inputs = Console.ReadLine().Split(' ');
        var k = int.Parse(Console.ReadLine());
        
        Program obj = new Program();
        
        //=== 線形探査 function 01 実行
        obj.linear_exploration_01(n,inputs,k);


        //=============== 線形探索 02
        var n_2 = int.Parse(Console.ReadLine());
        string[] inputs_2 = Console.ReadLine().Split(' ');
        var k_2 = int.Parse(Console.ReadLine());
        
        Program obj_2 = new Program();
        obj_2.linear_exploration_02(n_2, inputs_2, k_2);

    }
}