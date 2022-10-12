import java.util.*;

public class A05 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int h = sc.nextInt();
        int w = sc.nextInt();

        // ＝＝＝ ２次元配列初期化
        int[][] arr = new int[h][w];

        // ＝＝＝ 値取得
        for (int i = 0; i < h; i++) {
            for (int j = 0; j < w; j++) {
                arr[i][j] = sc.nextInt();
            }
        }

        // ＝＝＝ 判定ロジック
        for (int i = 0; i < h; i++) {
            for (int j = 0; j < w; j++) {
                if (arr[i][j] >= 128) {
                    arr[i][j] = 1;
                } else {
                    arr[i][j] = 0;
                }
            }
        }

        // ＝＝＝ 値出力部分
        for (int i = 0; i < h; i++) {
            for (int j = 0; j < w; j++) {
                if (j == w - 1) {
                    System.out.print(arr[i][j] + "\n");
                } else {
                    System.out.print(arr[i][j] + " ");
                }

            }
        }

    }
}