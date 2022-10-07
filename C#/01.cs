using System;

class Program
{
    static void Main()
    {
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



    }
}