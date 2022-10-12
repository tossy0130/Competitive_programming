import java.util.*;

public class A13 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        int K = sc.nextInt();

        for (int i = 1; i <= K; i++) {
            for (int j = 1; j <= N; j++) {
                if (j == N) {
                    System.out.println(j);
                } else {
                    System.out.print(j + " ");
                }
            }
        }

    }
}