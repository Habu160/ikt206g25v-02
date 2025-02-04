
namespace MyLibrary
{
    public class WordFinder
    {
        // Checks if a word exists in a given sentence
        public bool ContainsWord(string sentence, string word)
        {
            if (string.IsNullOrWhiteSpace(sentence) || string.IsNullOrWhiteSpace(word))
                return false;

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Contains(word, StringComparer.OrdinalIgnoreCase);
        }
    }
}


