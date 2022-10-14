using System;
using System.Collections.Generic;
//　MAX, MIN
using System.Linq;

class Program { 

    /*
        内角　の和

        n角形の内角の和は 180°×(n - 2) 
    */
    public void Naikaku_Wa(int n) {

        int ans = 180 * (n - 2) / n;
        Console.WriteLine(ans);

    }


     /*

     「点と点の距離」

    入力例1
    5
    -9 5
    0 4
    2 -6
    7 -4
    -3 -1
    10

    出力例1
    3
     */
     public void Itiman_Po(string[] arr) {

         int d = 0;
         int s = 0;
         d = int.Parse(arr[0].Trim());
         s = int.Parse(arr[1].Trim());
        
        //=== 計算　ロジック
         if(d * 10 >= s) {
             Console.WriteLine("yes");
         } else {
             Console.WriteLine("no");
         }

     }

      //=== main 実行
     static void Main()
    {   

        //================== Itiman_Po 実行
        Program obj_01 = new Program();
        int d = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        obj_01.Itiman_Po(d, s);
        //================== Itiman_Po 実行 END

        //================== Naikaku_Wa 実行
        Program obj_2 = new Program();
        int n_2 = int.Parse(Console.ReadLine());
        obj_2.Naikaku_Wa(n_2);
        //================== Naikaku_Wa 実行 END

    }

}