public class Solution {
    public bool IsPalindrome(int x) {
        string num = x.ToString();
        for(int i = 0; i < num.Length / 2; i++)
        {
            if(num[i] != num[num.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}