import java.util.*;

public class A07 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int a_range = sc.nextInt();
        int b = sc.nextInt();

        int[] arr_i = new int[a_range];

        int[] arr_ten = new int[a_range];
        int[] arr_ketu = new int[a_range];

        for (int i = 0; i < arr_i.length; i++) {
            arr_ten[i] = sc.nextInt();
            arr_ketu[i] = sc.nextInt();
        }

        // ===== 判定ロジック arr_ten - arr_ketu * 5 = 「点数」
        // 「点数」 > b => 「合格点」 のものを出力
        for (int j = 0; j < arr_ten.length; j++) {
            if (arr_ten[j] - (arr_ketu[j] * 5) >= b) {
                System.out.println(j + 1);

                // b = 「合格点」が 0 の時の処理
            } else if (arr_ten[j] - (arr_ketu[j] * 5) < 0 && b == 0) {
                System.out.println(j + 1);
            }
        }

    }
}