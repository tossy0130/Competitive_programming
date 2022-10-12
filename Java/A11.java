import java.util.*;
import java.util.Arrays;

public class A11 {
    public static void main(String[] args) {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();

        // === リスト宣言
        ArrayList<String> list = new ArrayList<>();

        // === リストへ追加
        for (int i = 0; i < n; i++) {
            list.add(sc.next());
        }

        // === リスト出力 拡張for 文
        /*
         * for (String s : list) {
         * System.out.println(s);
         * }
         */

        // === foreach 文 list のforeach
        list.forEach(s -> System.out.println(s)); // forEachメソッド

        // === foreach ループカウンタ付き
        /*
         * int[] i = { 0 };
         * list.forEach(s -> {
         * System.out.println(i[0] + " : " + s);
         * i[0]++;
         * });
         */

    }
}