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

        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even.")]
        [InlineData("one two one")]
        [InlineData("123abccba123")]

        public void IsPalindrome_ValuesNotSameInReverse_ReturnFalse(string value)
        {
            var result = _palindromeService.IsPalindrome(value);
    
            Assert.False(result, $"{value} should not be palindrome");
        }
    }
}