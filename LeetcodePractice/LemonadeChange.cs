// problem: https://leetcode.com/problems/lemonade-change/submissions/1486010268/?envType=study-plan-v2&envId=programming-skills

public class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        int amountOf5 = 0;
        int amountOf10 = 0;
        foreach (int bill in bills)
        {
            switch (bill)
            {
                case 5:
                    amountOf5++;
                    break;
                case 10:
                    if (amountOf5 <= 0)
                    {
                        return false;
                    }
                    amountOf5--;
                    amountOf10++;
                    break;
                case 20:
                    if (amountOf10 > 0)
                    {
                        if (amountOf5 <= 0)
                        { // 1 of 10, 0 of 5 => false
                            return false;
                        }
                        // >= 1 of 10, >= 1 of 5
                        amountOf10--;
                        amountOf5--;
                    }
                    else if (amountOf5 >= 3)
                    { // >= 3 of 5 => true
                        amountOf5 -= 3;
                    }
                    else
                    { // 0 of 10 && < 3 of 5
                        return false;
                    }
                    break;
            }
        }
        if (amountOf5 < 0 || amountOf10 < 0) return false;
        return true;
    }
}