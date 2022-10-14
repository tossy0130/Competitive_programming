using System;
using System.Collections.Generic;
//　MAX, MIN
using System.Linq;

class Program { 

     /*
        i 番目の出力 　配列：03  arr_i の配列　の idx 引数で受け取った idx を出力する
    */
    public void Arr_Write_02(int[] arr_i, int idx) {
        
      //=== 引数の idx の 配列の index を出力する。
      Console.WriteLine(arr_i[idx - 1]);
    }

    /*
        全要素の出力 　配列：02
    */
    public void Arr_Write_01(int[] arr_i) {
        
        foreach(int val in arr_i) {
            // === 改行コードを入れて全件出力 
            System.Console.Write("{0}", val.ToString() + "\n");
        }

    /*
    要素数の出力  - 配列:01
    */
    public void Get_Len(int[] arr_i) {

        int ans = arr_i.Length;
        Console.WriteLine(ans);
    }
    
    //=============== main 実行
    static void Main()
    {
        // ===================== Get_Len 実行
        int [] arr = {5,1,3,4,5,12,6,8,1,3};
        Program obj_01 = new Program();
        obj_01.Get_Len(arr);
        // ===================== Get_Len 実行 END ===>

        //====================== Arr_Write_01 実行
        int [] arr_02 = {5,1,3,4,5,12,6,8,1,3};
        Program obj_02 = new Program();
        obj_02.Arr_Write_01(arr_02);
        //====================== Arr_Write_01 実行 END ===>

        //====================== Arr_Write_02 実行
        int [] arr_03 = {5,1,3,4,5,12,6,8,1,3};
        Program obj_03 = new Program();
        int cal_index = 4;
        obj_03.Arr_Write_02(arr_03, cal_index);
        //====================== Arr_Write_02 実行 END ===>

    }
}