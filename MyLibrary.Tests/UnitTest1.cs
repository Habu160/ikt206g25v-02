using Xunit;
using MyLibrary;

namespace MyLibrary.Tests
{
    public class WordFinderTests
    {
        private readonly WordFinder _wordFinder = new();

        [Fact]
        public void ContainsWord_ReturnsTrue_WhenWordExists()
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            string word = "fox";

            bool result = _wordFinder.ContainsWord(sentence, word);

            Assert.True(result);
        }

        [Fact]
        public void ContainsWord_ReturnsFalse_WhenWordDoesNotExist()
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            string word = "cat";

            bool result = _wordFinder.ContainsWord(sentence, word);

            Assert.False(result);
        }

        [Fact]
        public void ContainsWord_IsCaseInsensitive()
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            string word = "FOX";

            bool result = _wordFinder.ContainsWord(sentence, word);

            Assert.True(result);
        }

        [Fact]
        public void ContainsWord_ReturnsFalse_WhenSentenceIsEmpty()
        {
            string sentence = "";
            string word = "hello";

            bool result = _wordFinder.ContainsWord(sentence, word);

            Assert.False(result);
        }
    }
}