using System;

class Program
{   
    
    /*
    ある数をある回数表示 1
    3 を 8 回、改行区切りで出力
    */
     public void t_01(int num, int loop_num){
        
        for(var i = 0; i < loop_num; i++) {
            Console.WriteLine(num.ToString());
        }
     }

    /*
        入力例1
        3 8
    */
    public void t_02(int num, int loop_num){
        
        for(var i = 0; i < loop_num; i++) {
            Console.WriteLine(num.ToString());
        }
        
    }

    static void Main()
    {

         Program obj = new Program();

        // 自分の得意な言語で
        // Let's チャレンジ！！
        for(var i = 1; i <= 10; i++) {
            Console.WriteLine(i);
        } 

        // === 1 ~ N の整数を 1 から順に改行区切りで出力
        var N = int.Parse(Console.ReadLine());
        for(var i = 1; i <= N; i++) {
            Console.WriteLine(i);
        }

        // 与えられた 10 個の数字を改行区切りで出力してください。
       //出力の末尾には改行を入れてください。
       // 入力例1
       // 1 2 3 4 5 6 7 8 9 10
       string[] inputStrArray = Console.ReadLine().Split(' ');
      
       foreach(var val in inputStrArray) {
          Console.WriteLine(val);
       }

        /*
        入力例1
        5
        1 2 3 4 5
        */
        
         var num = int.Parse(Console.ReadLine());
         var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
         
         foreach(var val in arr) {
             Console.WriteLine(val);
         }

         //  ある数をある回数表示 1 function t_01
         obj.t_01(3, 8);

        /*
        入力例1
        3 8
        */
        obj.t_02(arr[0], arr[1]);


        /*
          a ~ z までを表示
        */
        //=== a ~ z までを表示
        string[] texts_arr = new string[] { "a", "b", "c" ,"d","e","f","g","h","i","j","k","l","m","n"
                                    ,"o","p","q","r","s","t","u","v","w","x","y","z"};
                                    
        foreach(var val in texts_arr) {
            Console.WriteLine(val);
        }
        // === a ~ z までを表示 END

    }
}