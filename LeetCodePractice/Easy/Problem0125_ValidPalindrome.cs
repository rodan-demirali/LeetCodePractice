namespace LeetCodePractice.Easy;

public class Problem0125_ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        // TODO: Solve the problem yourself.
        //throw new NotImplementedException();

        s = s.ToLower();
        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }

            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            if (s[left] != s[right])
            {
                return false;
            }

            left++;
            right--;

        }

        return true;
    }
}
