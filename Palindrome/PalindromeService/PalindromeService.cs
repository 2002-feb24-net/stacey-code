using System;

namespace Palindrome.Services
{
    public class PalindromeService : IPalindrome
    {
        public bool IsPalindrome(string candidate)
        {
            if (candidate.Length <= 1)
            return true;
            else
            {
            if ( candidate[0] != candidate[ candidate.Length - 1 ] )
                return false;
            else
                return IsPalindrome(candidate.Substring( 1, candidate.Length-2 ) );
            }
            throw new NotImplementedException("Not fully implemented.");
        }
    }
}
