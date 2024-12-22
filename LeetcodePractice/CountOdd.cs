// problem: https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public int CountOdds(int low, int high) {
        int minOdd = low % 2 == 0 ? low + 1 : low;
        int maxOdd = high % 2 == 0 ? high - 1 : high;
        return (maxOdd - minOdd)/2 + 1;
    }
}