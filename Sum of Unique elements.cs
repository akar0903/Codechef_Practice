public class Solution {
    public int SumOfUnique(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            if (!dict.ContainsKey(nums[i])){
                dict[nums[i]] = 1;
            }
            else{
                dict[nums[i]]++;
            }
        }
        int sum = 0;
        foreach(var num in dict.Keys){
            if (dict[num] == 1){
                sum += num;
            }
        }
        return sum;
    }
}
