using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem Statement: http://www.reddit.com/r/dailyprogrammer/comments/3aqvjn/20150622_challenge_220_easy_mangling_sentences/
 * */
namespace DailyProgrammer
{
    public class E220_Mangle
    {
        public static string MangeSentence(string input)
        {
            StringBuilder res = new StringBuilder(input.Length);
            // Set string to lowercase
            // Remove non characters
            // Split the string
            // Reverse individual components.
            var reversedWords = new String(input.ToLower().Where(x => Char.IsLetter(x) || Char.IsWhiteSpace(x)).
                                                ToArray()).
                                                Split(new char[] { ' ' })
                                                .Select(x => x.OrderBy(y=>y));

            // Re-join the string keeping position in place.
            int index = 0;
            foreach(var word in reversedWords)
            {
                foreach (char c in word)
                {
                    if(!Char.IsLetter(input[index]))
                    {
                        while (!Char.IsLetter(input[index]))
                        {
                            res.Append(input[index++]);
                        }
                    }

                    if (Char.IsUpper(input[index++]))
                    {
                        res.Append(c.ToString().ToUpper());
                    }
                    else
                    {
                        res.Append(c);
                    }
                }
            }

            while(index<input.Length)
            {
                res.Append(input[index++]);
            }
            return res.ToString();
        }
    }
}
