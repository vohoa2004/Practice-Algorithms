//problem: https://leetcode.com/problems/baseball-game/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public int CalPoints(string[] operations) {
        int n = operations.Length;
        List<int> arr = new List<int>();
        int result = 0;
        for (int i = 0; i < n; i++) {
            int lastIndexOfArr = arr.Count - 1;
            if (operations[i] == "C") {
                arr.RemoveAt(lastIndexOfArr);
            }
            else if (operations[i] == "D") {
                arr.Add(arr[lastIndexOfArr] * 2);
            }
            else if (operations[i] == "+") {
                arr.Add(arr[lastIndexOfArr] + arr[lastIndexOfArr - 1]);
            } else {
                arr.Add(int.Parse(operations[i]));
            }
        }
        foreach (int x in arr) {
            result += x;
        }
        return result;
    }
}