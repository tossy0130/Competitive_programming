var
 n,i,sum:integer;
 
begin
 sum := 0;
 read(n);
 
 for i := 1 to n do begin
 
 begin
 if i <= 9 then
 Inc(sum);
 end;
 
 begin
 if (i >= 100) and (i <= 999) then
 Inc(sum);
 end;
 
 begin
 if (i >= 10000) and (i <= 99999) then
 Inc(sum);
 end;
 
 end;
 
 writeln(sum);

end.