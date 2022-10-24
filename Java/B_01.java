import java.util.*;

public class B_01 {

    // ========================== ２分探索 実装
    static int Binary_search(int[] arr, int len, int key) {
        int left = 0;
        int right = len - 1;
        int mid = 0;
        while (left <= right) {
            mid = (right + left) / 2;

            if (arr[mid] == key) {
                return key;
            } else if (arr[mid] < key) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        } // === END while

        key = -1;
        return key;
    }

    public static void main(String[] args) {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        Scanner sc = new Scanner(System.in);

        int num = sc.nextInt();

        int[] get_arr = new int[num];
        // === 値取得
        for (int i = 0; i < num; i++) {
            get_arr[i] = sc.nextInt();
        }

        int key_num = sc.nextInt();

        int[] key_arr = new int[key_num];

        for (int i = 0; i < key_num; i++) {
            key_arr[i] = sc.nextInt();
        }

        int ans = 0;
        for (int j = 0; j < key_num; j++) {
            // ============ 関数 使用
            ans = Binary_search(get_arr, num, key_arr[j]);
            // === 回答
            if (ans == -1) {
                System.out.println("No");
            } else {
                System.out.println("Yes");
            }
        }

    }
}