// problem: https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public double Average(int[] salary) {
        int max = salary[0];
        int min = salary[0];
        int sum = 0;
        int n = salary.Length;
        foreach (int s in salary) {
            max = Math.Max(max, s);
            min = Math.Min(min, s);
            sum += s;
        }
        return (double)(sum - min - max)/(double)(n - 2);
    }
}