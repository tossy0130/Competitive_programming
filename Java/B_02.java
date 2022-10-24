import java.util.*;

public class B_02 {

    // ======================= K が いくつ含まれているか ======================
    static void Check_arr_01(int n, int k, int[] arr) {
        int ans = 0;

        for (int i = 0; i < n; i++) {
            if (arr[i] == k) {
                ans = ans + 1;
            }
        }
        System.out.println(ans);
    }

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int n;
        int k;
        n = sc.nextInt();
        k = sc.nextInt();

        int[] arr = new int[n];
        for (int i = 0; i < n; i++) {
            arr[i] = sc.nextInt();
        }

        // ================== Check_arr_01 関数実行 ==================
        Check_arr_01(n, k, arr);

    }
}
