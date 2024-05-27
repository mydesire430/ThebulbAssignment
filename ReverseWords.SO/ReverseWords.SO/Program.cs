namespace ReverseWords.SO
{
    public class Program
    {
        public static string ReverseWordsInString(string s)
        {
            // Split the string by spaces
            string[] words = s.Split(' ');
            // Create an array to store reversed words
            string[] reversedWords = new string[words.Length];

            // Reverse each word and store it in the reversedWords array
            for (int i = 0; i < words.Length; i++)
            {
                char[] wordArray = words[i].ToCharArray();
                Array.Reverse(wordArray);
                reversedWords[i] = new string(wordArray);
            }

            // Join the reversed words with a single space
            return string.Join(" ", reversedWords);
        }

        public static void Main()
        {
            Console.WriteLine(ReverseWordsInString("This is an example!")); // Output: "sihT si na !elpmaxe"
            Console.WriteLine(ReverseWordsInString("double  spaces"));      // Output: "elbuod  secaps"
        }
    }
}