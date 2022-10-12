import java.util.*;

public class A04 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int[] arr_01 = new int[2];
        int[] arr_02 = new int[2];

        // === 値取得
        for (int i = 0; i < 2; i++) {
            arr_01[i] = sc.nextInt();
        }
        for (int i = 0; i < 2; i++) {
            arr_02[i] = sc.nextInt();
        }

        int ans = 0;

        int temp01 = arr_01[0] * arr_02[1];
        int temp02 = arr_01[1] * arr_02[0];
        int temp03 = arr_02[0] * arr_02[1];

        temp01 = Math.abs(temp01);
        temp02 = Math.abs(temp02);
        temp03 = Math.abs(temp03);

        /*
         * System.out.println(temp01);
         * System.out.println(temp02);
         * System.out.println(temp03);
         */

        int t = temp01 + temp02;
        // System.out.println(t);

        ans = t - temp03;

        // === 判定ロジック ===
        /*
         * for(int i = 0; i < 2; i++) {
         * if(i == 2 - i){
         * break;
         * }
         * ans = (arr_01[i] * arr_02[i + 1]) + (arr_01[i + 1] * arr_02[i]) - (arr_02[i]
         * * arr_02[i + 1]);
         * }
         */

        System.out.println(ans);

    }
}
