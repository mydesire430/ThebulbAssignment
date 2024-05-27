using System.Text;

namespace SpaceCamelCase.SO
{
    public class Program
    {
        static void Main(string[] args)
        {
            public string SplitCamelCase(string camelCasedString)
            {
                StringBuilder builder = new StringBuilder();

                foreach (char c in camelCasedString)
                {
                    if (char.IsUpper(c) && builder.Length > 0)
                    {
                        builder.Append(' ');
                    }
                    builder.Append(c);
                }
                return builder.ToString().Trim();
            }
        }
    }
}