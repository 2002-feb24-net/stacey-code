using Xunit;
using Palindrome.Services;

namespace Palindrome.UnitTests.Services
{
    public class PalindromeService_IsPalindromeShould
    {
        private readonly PalindromeService _palindromeService;

        public PalindromeService_IsPalindromeShould()
        {
            _palindromeService = new PalindromeService();
        }

        [Fact]
        public void IsPalindrome_InputIs1_ReturnFalse()
        {
            var result = _palindromeService.IsPalindrome("Malayalam");

            Assert.False(result, "Malayalam should not be palindrome");

        }
    }
}