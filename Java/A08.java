import java.util.*;
import java.util.Scanner;

public class A08 { 
    public static void main(String[] args) {
      
	Scanner sc = new Scanner (System.in);
    
    // 値取得
    int num = sc.nextInt();  
    sc.close();
      
    int ans = 1;
      
    while(ans <= num) {
       ans *= 2;
     }
     
     System.out.println(ans / 2);
    
   }
}