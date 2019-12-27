namespace leetcode.lib.Medium
{
    public class PalindromeNumber
    {
        public bool IsPalindromeNumber(int x)
        {
            /*
            var s = x.ToString();
            for(var i = 0 ;i < s.Length ; i++)
            {
                if(s[i] == s[s.Length -1 - i])
                    continue;
                else
                    return false;

                if(i > s.Length-1 -i)
                    break;
            }

            return true;
            */

            if (x == 0 || (x % 10 == 0 && x != 0))
                return false;

            int num = x;
            int compare = 0;
            while (num > 0)
            {
                compare = compare * 10 + num % 10;
                num /= 10;
            }

            return x == compare;
        }
    }
}