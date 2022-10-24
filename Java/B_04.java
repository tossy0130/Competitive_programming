import java.util.*;

public class B_04 {

    // ============ 配列の和を出力
    static void Check_arr_03(int[] arr, int num) {

        int sum_num = 0;
        for (int i = 0; i < num; i++) {
            sum_num = sum_num + arr[i];
        }

        System.out.println(sum_num);

    }
    // ============ 配列の和を出力 END

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int loop_num = sc.nextInt();
        int[] get_arr = new int[loop_num];
        for (int i = 0; i < loop_num; i++) {
            get_arr[i] = sc.nextInt();
        }

        // ================ Check_arr_03 関数実行 =================
        Check_arr_03(get_arr, loop_num);

    }
}