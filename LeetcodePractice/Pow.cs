public class Solution {
    public double MyPow(double x, int n) {
        // way 2, reduce no of iteration
        // use the binary expression of n. EVERY integer n can be described as sum of pow(2,i).
        // instead of n iterations, now we only need sum(m_i) iterations with m_i is the exponent of 2
        // ex: n = 20 = 2^4 + 2^2 => 6 iterations => 4 loops to square the ((x)^2)^4 + 2 loops to square ((x)^2)^2 then multiply these 2 numbers
        return n < 0 ? 1.0/BiPow(x, -(long)n) : BiPow(x, (long)n);
    }

    public double BiPow(double x, long n) {
        double result = 1;
        for (; n > 0; n /= 2) {
            if (n % 2 == 1) {
                result *= x;
            }
            x *= x;
        }
        return result;
    }
}