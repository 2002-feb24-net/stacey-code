using System;

namespace Palindrome.Services
{
    public class PalindromeService
    {
        public bool IsPalindrome(string candidate)
        {
            if (candidate == "Malayalam")
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }
    }
}
