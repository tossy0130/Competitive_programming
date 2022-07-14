* ‰ğ“šƒR[ƒh *
* ------------------ *
var
i,h,a,sum:longint;

     begin
     read(h,a);
     sum := 1;
     i := 0;
         while h > a do
         begin
             Inc(sum);
             h := h - a;
         end;
     write(sum);
end.