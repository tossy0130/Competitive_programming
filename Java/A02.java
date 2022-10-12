import java.util.*;


public class A02 {
    public static void main(String[] args) {
     
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();
        int M = sc.nextInt();
        
        int arr[] = new int[N];
        
        for(int i = 0; i < arr.length; i++) {
            arr[i] = sc.nextInt();
        }
        
        boolean flg = false;
        for(int i = 0; i < arr.length; i++) {
            if(arr[i] == 0 && arr[i + 1] == 0 && arr[i + 2] == 0) {
                flg = false;
                break;
            } else {
                flg = true;
            }
        }
        
        if(flg) {
            System.out.print("OK");
        } else {
            System.out.print("NG");
        }
        
    }
}