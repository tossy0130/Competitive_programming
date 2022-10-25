import java.util.*;

public class B_05 {

    static void B_05_01(int num, int left, int right, int[] arr) {
        // 長さ N の数列 a (a_1, a_2, ..., a_N) と、整数 A, B が与えられます。
        int idx = left - 1;
        int ans = 0;

        while (idx <= right - 1) {
            ans += arr[idx];
            idx++;
        }

        System.out.println(ans);
    }

    public static void main(String[] args) {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        Scanner sc = new Scanner(System.in);
        int loop = sc.nextInt();
        int left = sc.nextInt();
        int right = sc.nextInt();

        int[] arr = new int[loop];
        for (int i = 0; i < loop; i++) {
            arr[i] = sc.nextInt();
        }

        B_05_01(loop, left, right, arr);

    }
}