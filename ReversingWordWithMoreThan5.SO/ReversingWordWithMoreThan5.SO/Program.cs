namespace ReversingWordWithMoreThan5.SO
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(ReverseLongWords("Hey fellow warriors"));
            Console.WriteLine(ReverseLongWords("This is a test"));
            Console.WriteLine(ReverseLongWords("This is another test"));
        }
        public static string ReverseLongWords(string sentence)
        {
            // Split the sentence into words
            string[] words = sentence.Split(' ');

            // Process each word
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    words[i] = ReverseString(words[i]);
                }
            }
            // Join the processed words back into a single string
            return string.Join(" ", words);
        }
        private static string ReverseString(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}