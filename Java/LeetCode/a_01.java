//===  Two Sum

class a_01 {
    public int[] twoSum(int[] nums, int target) {

        int[] arr_ans = new int[2];
        // === 足して target になった index を配列に格納
        for (int i = 0; i < nums.length; i++) {

            for (int j = 1; j < nums.length; j++) {

                // === 同じ index は飛ばす
                if (i == j) {
                    continue;
                }

                if (nums[i] + nums[j] == target) {
                    arr_ans[0] = i;
                    arr_ans[1] = j;
                }
            }

        }

        return arr_ans;
    }
}