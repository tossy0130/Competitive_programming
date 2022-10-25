import java.lang.reflect.Array;
import java.util.Arrays;

//=== 1313. Decompress Run-Length Encoded List
class a_03 {
    public int[] decompressRLElist(int[] nums) {
        int a = nums[0];
        int b = nums[1];

        int c = nums[2];
        int d = nums[3];

        int[] arr_a = new int[a];
        int[] arr_c = new int[c];

        for (int i = 0; i < a; i++) {
            arr_a[i] = b;
        }

        for (int i = 0; i < c; i++) {
            arr_c[i] = d;
        }

        // === 配列 結合 ===
        int[] arr_ans = new int[arr_a.length + arr_c.length];

        System.arraycopy(arr_a, 0, arr_ans, 0, arr_a.length);
        System.arraycopy(arr_c, 0, arr_ans, arr_a.length, arr_c.length);

        return arr_ans;

    }
}