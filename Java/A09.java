
import java.util.*;

public class A09 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int target = 57;
        boolean C_flg = true;

        // === 素数判定 *** 「整数 N が素数である」とは「N が 2 以上で、かつ N の約数が 1 と N のみしか存在しない」
        // 割り切れたら 素数ではない
        for (int i = 2; i <= target; i++) {
            if (target % i == 0) {
                C_flg = false;
            }
        }

        if (C_flg) {
            System.out.println("OK");
        } else {
            System.out.println("NO");
        }

    }
}
