import java.util.*;

public class A06 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();
        String[] arr = new String[num];

        for (int i = 0; i < num; i++) {
            arr[i] = sc.next();
        }

        boolean flg = false;
        String a;
        String b;

        // ========== 判定ロジック 部分
        for (int i = 0; i < num; i++) {
            if (i == num - 1) {
                break;
            }

            if (arr[i].charAt(arr[i].length() - 1) == arr[i + 1].charAt(0)) {
                flg = true;
            } else {
                System.out.println(arr[i].charAt(arr[i].length() - 1) + " " + arr[i + 1].charAt(0));
                flg = false;
                break;
            }
        }

        // === 出力部分
        if (flg) {
            System.out.println("Yes");
        }

    }
}