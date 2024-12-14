// problem: https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int diff = arr[1] - arr[0];

        for(int i=2; i<arr.Length; i++){
            if(arr[i] - arr[i-1] != diff) {
                return false;
            }
        }

        return true;
    }
    public bool Way1HashSet2Ms(int[] arr) {
        // find min, find max => d
        int min = arr[0];
        int max = arr[0];
        int len = arr.Length;
        HashSet<int> seen = new HashSet<int>();
        for (int i = 0; i < len; i++) {
            if (arr[i] < min) {
                min = arr[i];
            }
            if (arr[i] > max) {
                max = arr[i];
            }
            seen.Add(arr[i]);
        }
        // const array
        if (((max - min) % (len - 1)) != 0) {
            return false;
        }
        int d = (max - min)/(len - 1);
        if (d == 0) {
            return true;
        }
        else {
            for (int i = 0; i < len; i++) {
                if (!seen.Contains(min + i * d)) {
                    return false;
                }
            }
        }
        return true;
    }

    public bool Way2Sort3Ms(int[] arr) {
        Array.Sort(arr);
        int len = arr.Length;
        int d = arr[1] - arr[0];
        for (int i = 2; i < len - 1; i++) {
            if (arr[i + 1] - arr[i] != d) {
                return false;
            }
        }
        return true;
    }
}