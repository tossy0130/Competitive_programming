     var
         sum,i,h,a:Integer;
         arr:array of Integer;
begin
         read(h,a); // h = 211 a = 5 �i�[
         SetLength(arr, a);   // arr[5] �̔z����쐬
         sum := 0;

         for i := Low(arr) to High(arr) do begin // for 0 <= 5 ���[�v
             read(arr[i]);   // arr �� 31, 41, 59, 26, 53 �i�[ 
             sum := sum + arr[i];   // sum �Ɂ@31, 41, 59, 26, 53 �𑫂������v�l������
         end;

         begin
             if sum > h then // sum > 211
                 write('Yes')
             else
                 write('No');
         end;
end.