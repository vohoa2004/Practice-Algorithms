/*
 * List: https://leetcode.com/studyplan/programming-skills/
 * Problem #2: https://leetcode.com/problems/find-the-difference/description/?envType=study-plan-v2&envId=programming-skills
 * String t is generated by random shuffling string s and then add one more letter at a random position.

 * Return the letter that was added to t.
 */
package ProgrammingSkills;

/**
 *
 * @author vothimaihoa
 */

class Solution {
    // mindset hay: ban chat t luon hon s mot ky tu bat ky o dau do 
    // => tong gia tri ASCII cua t hon cua S dung bang ma ASCII cua ky tu them vao do!!!
    public char findTheDifference(String s, String t) {
        int lenS = s.length();
        int lenT = t.length();
        char[] sArr = s.toCharArray();
        char[] tArr = t.toCharArray();
        int sumS = 0;
        for (char i : sArr) {
            sumS += i;
        }
        int sumT = 0;
        for (char i : tArr) {
            sumT += i;
        }
        
        return (char)(sumT - sumS);
    }
}