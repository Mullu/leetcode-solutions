
namespace Algorithms
{
    public class ReverseWord
    {
        public static string Reverse(string word)
        {
            char[] characters = word.ToCharArray();
            Array.Reverse(characters);
            return new string(characters);
        }

        public static string ReverseEachWord(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return string.Empty;

            var words = sentence.Split(" ");
            var reversedWords = words.Select(word => Reverse(word));

            return string.Join(" ", reversedWords);
        }

        //public static void Main(String[] args)
        //{
        //    string sentence = "sally is a great worker";
        //    string learnerResult = ReverseEachWord(sentence);
        //    Console.WriteLine(learnerResult);
        //}
    }
}
