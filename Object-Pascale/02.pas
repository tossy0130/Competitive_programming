     var
         sum,i,h,a:Integer;
         arr:array of Integer;
begin
         read(h,a); // h = 211 a = 5 Ši”[
         SetLength(arr, a);   // arr[5] ‚Ì”z—ñ‚ğì¬
         sum := 0;

         for i := Low(arr) to High(arr) do begin // for 0 <= 5 ƒ‹[ƒv
             read(arr[i]);   // arr ‚É 31, 41, 59, 26, 53 Ši”[ 
             sum := sum + arr[i];   // sum ‚É@31, 41, 59, 26, 53 ‚ğ‘«‚µ‚½‡Œv’l‚ğ“ü‚ê‚é
         end;

         begin
             if sum > h then // sum > 211
                 write('Yes')
             else
                 write('No');
         end;
end.