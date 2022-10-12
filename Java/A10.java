import java.util.*;

public class A10 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        int K = sc.nextInt();

        // =========== 値取得エリア
        ArrayList<Integer> item = new ArrayList<>();
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < K; j++) {
                item.add(sc.nextInt());
            }
        }

        // =========== 出力エリア
        int loop = 1;
        for (Integer ii : item) {
            if (loop == K) {
                System.out.println(ii);
                loop = 1;
                continue;
            } else {
                System.out.print(ii + " ");
            }
            loop++;

        }

    }
}