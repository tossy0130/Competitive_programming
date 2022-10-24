import java.util.*;

public class B_03 {

    // ================= 配列の max値を取得
    static void Check_arr_03(int num, int[] arr) {

        int left = arr[0];
        for (int i = 1; i < num; i++) {
            if (left < arr[i]) {
                left = arr[i];
            }
        }
        System.out.println(left);
    }

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int loop_num = sc.nextInt();
        int[] arr = new int[loop_num];
        for (int i = 0; i < loop_num; i++) {
            arr[i] = sc.nextInt();
        }

        // ============= Check_arr_03 関数 使用 ===============
        Check_arr_03(loop_num, arr);

    }
}