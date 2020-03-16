using Xunit;
using PalindromeService;

namespace PalindromeCheck
{
    public class PalindromeCheck_IsPalindromeShould
    {
        private readonly PalindromeChecker _palindromeCheck;

        public PalindromeCheck_IsPalindromeShould()
        {
            _palindromeCheck = new PalindromeChecker();
        }

        [Fact]
        public void IsPalindrome_InputIs1_ReturnTrue()
        {
            var result = _palindromeCheck.IsPalindrome("Malayalam");

            Assert.True(result, "Malayalam should be palindrome");
        }
    }
}