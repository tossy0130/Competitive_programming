import java.util.*;

public class A03 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int a = sc.nextInt();
        int b = sc.nextInt();

        int[] arr = new int[a - 1];

        for (int i = 0; i < a - 1; i++) {
            arr[i] = sc.nextInt();
        }

        int ans = 0;
        for (Integer k : arr) {
            if (k <= b) {
                // System.out.println(k);
                ans += k;
            }
        }

        System.out.println(ans);

    }
}
