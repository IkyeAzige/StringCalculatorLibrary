using System.Collections.Generic;

namespace StringCalculatorLibrary
{
    public class SubStringDelimiterParser : IDelimiterParser
    {
        public IEnumerable<string> Parse(string stringNumbers)
        {
            IList<string> delimiters = new List<string>();

            if (stringNumbers.StartsWith("//"))
            {
                string singleDelimiter = stringNumbers[2].ToString();

                if (singleDelimiter.StartsWith("["))
                {
                    string delimiterSection = null;
                    try
                    {
                        delimiterSection = stringNumbers.Substring(2, stringNumbers.IndexOf("\n") - 2);
                    }
                    catch (System.Exception)
                    {

                        delimiterSection = stringNumbers.Substring(2, stringNumbers.IndexOf("\\n") - 2);
                    }
                    

                    string[] splits = delimiterSection.Split(']');

                    for (int i = 0; i < splits.Length - 1; i++)
                    {
                        delimiters.Add(splits[i].Remove(0, 1));
                    }
                }
                else
                {
                    delimiters.Add(singleDelimiter);
                }
            }

            return delimiters;
        }
    }
}
