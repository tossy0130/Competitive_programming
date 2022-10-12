import java.util.*;

public class A12 {
    public static void main(String[] args) {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        Scanner sc = new Scanner(System.in);

        // リスト定義
        ArrayList<String> t_list = new ArrayList<>();

        // 要素取得 hasNext
        while (sc.hasNext()) {
            t_list.add(sc.next());
        }

        // forEach で出力
        t_list.forEach(s -> System.out.println(s));

    }
}