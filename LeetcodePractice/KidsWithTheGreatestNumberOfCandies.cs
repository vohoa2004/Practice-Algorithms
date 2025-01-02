https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/?envType=study-plan-v2&envId=leetcode-75

public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        // giai thich de bai: moi truong hop la rieng biet
        // VD: EX1 - Kid 5 => candies [2,3,5,1,6] => Kid 5 has most => true
        IList<bool> result = new List<bool>();
        int oldMax = candies[0];
        for (int i = 0; i < candies.Length; i++) {
            if (candies[i] > oldMax) {
                oldMax = candies[i];
            }
        }

        for (int i = 0; i < candies.Length; i++) {
            // vi case chi co 1 vi tri thay doi, nen ta so sanh voi max ban dau la ddur
            result.Add(candies[i] + extraCandies >= oldMax);
        }
        return result;
    }
}