     var
         sum,i,h,a:Integer;
         arr:array of Integer;
begin
         read(h,a); // h = 211 a = 5 格納
         SetLength(arr, a);   // arr[5] の配列を作成
         sum := 0;

         for i := Low(arr) to High(arr) do begin // for 0 <= 5 ループ
             read(arr[i]);   // arr に 31, 41, 59, 26, 53 格納 
             sum := sum + arr[i];   // sum に　31, 41, 59, 26, 53 を足した合計値を入れる
         end;

         begin
             if sum > h then // sum > 211
                 write('Yes')
             else
                 write('No');
         end;
end.