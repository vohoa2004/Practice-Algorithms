/*
 * List: https://leetcode.com/studyplan/programming-skills/
 * Problem #1: https://leetcode.com/problems/merge-strings-alternately/?envType=study-plan-v2&envId=programming-skills
 * You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. 
 * If a string is longer than the other, append the additional letters onto the end of the merged string.
 */
package ProgrammingSkills;

/**
 *
 * @author vothimaihoa
 */

class MergeStringAlternatively {
    public String mergeAlternately(String word1, String word2) {
        // use merge algorithm of Merge Sort
        StringBuilder result = new StringBuilder();

        // Initialize 2 pointer to track with current position of each array
        int l = 0, r = 0;
        int n1 = word1.length();
        int n2 = word2.length();
        char[] charArr1 = word1.toCharArray();
        char[] charArr2 = word2.toCharArray();

        // merge letters
        if (n1 < n2) {
            while (l < n1) {
                result.append(charArr1[l]);
                result.append(charArr2[r]);
                l++;
                r++;
            }
            while (r < n2) {
                result.append(charArr2[r]);
                r++;
            }
        } else {
             while (r < n2) {
                result.append(charArr1[l]);
                result.append(charArr2[r]);
                l++;
                r++;
            }
            while (l < n1) {
                result.append(charArr1[l]);
                l++;
            }
        }
        return result.toString();
    }
}