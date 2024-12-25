// problem: https://leetcode.com/problems/multiply-strings/?envType=study-plan-v2&envId=programming-skills

public class Solution {
    public string Multiply(string a, string b) {
        // 2ms
        // return (BigInteger.Parse(a) * BigInteger.Parse(b)).ToString();

        // 4ms
        if (a.Equals("0") || b.Equals("0")) {
            return "0";
        }
        int m = a.Length - 1, n = b.Length - 1,
            carry = 0;
        string product = "";
        /*
        Ý tưởng chính:
        Lặp qua từng vị trí tổng quát i trong kết quả phép nhân:

        Kết quả phép nhân của a và b sẽ có độ dài tối đa là m + n + 1 (trường hợp nhân hai số lớn nhất).
        Tại mỗi vị trí i trong kết quả, chúng ta sẽ tính tổng các chữ số từ a và b nhân với nhau sao cho vị trí của chúng khớp để tạo nên kết quả ở vị trí i.
        Lặp qua chỉ số j:

        j đại diện cho chỉ số chữ số trong chuỗi a góp phần tạo ra giá trị tại vị trí i trong kết quả.
        Math.Max(0, i - n): Đảm bảo j bắt đầu từ chỉ số hợp lệ của a.
        Math.Min(i, m): Đảm bảo j không vượt quá chỉ số cuối cùng của a.
        Tính tích từng chữ số:

        (a[m - j] - '0'): Lấy chữ số ở vị trí j từ chuỗi a (bắt đầu từ phải sang trái).
        (b[n - i + j] - '0'): Lấy chữ số từ chuỗi b tương ứng với vị trí i.
        Tích của hai chữ số này được thêm vào carry.
        Lưu giá trị vào product:

        (carry % 10): Lấy phần đơn vị của tổng (carry) để lưu vào kết quả tại vị trí i.
        carry /= 10: Loại bỏ phần đơn vị của carry, giữ lại phần dư để cộng vào lần lặp tiếp theo.
        */
        for (int i = 0; i <= m + n || carry != 0; ++i) {
            for (int j = Math.Max(0, i - n);
                 j <= Math.Min(i, m); ++j) {
                carry += (a[m - j] - '0') * (b[n - i + j] - '0');
            }
            product += (char)(carry % 10 + '0');
            carry /= 10;
        }
        char[] charArray = product.ToCharArray();
        Array.Reverse(charArray);
        product = new string(charArray);
        return product;
    }
}