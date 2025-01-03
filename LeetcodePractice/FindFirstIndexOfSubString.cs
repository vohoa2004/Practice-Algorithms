// Problem set: https://leetcode.com/studyplan/programming-skills/
// Problem:  https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/?envType=study-plan-v2&envId=programming-skills
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        //return haystack.IndexOf(needle);

        //self-implemnented indexOf
        int len = haystack.Length;
        int subLen = needle.Length;
        char[] hArr = haystack.ToCharArray();
        char[] nArr = needle.ToCharArray();
        int result = -1;
        for (int i = 0; i <= len - subLen; i++)
        {
            bool matched = true;
            for (int j = 0; j < subLen; j++)
            {
                if (hArr[j + i] != nArr[j])
                {
                    matched = false;
                    break;
                }
            }
            if (matched)
            {
                result = i;
                break;
            }
        }
        return result;
    }
}