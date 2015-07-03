using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem Statement: http://www.reddit.com/r/dailyprogrammer/comments/38yy9s/20150608_challenge_218_easy_making_numbers/
 * */

namespace DailyProgrammer
{

    public class PalindromicNumbers
    {
        public static Tuple<bool, int> IsPalindromic(long i, int count=0)
        {
            try
            {
                var stringRep = i.ToString().ToCharArray();
                Array.Reverse(stringRep);
                var reversedLong = long.Parse(new string(stringRep));

                if (i == reversedLong)
                {
                    return new Tuple<bool, int>(true, count);
                }
                else
                {
                    if (count < 10000)
                    {
                        return IsPalindromic(i + reversedLong, ++count);
                    }
                    else
                    {
                        return new Tuple<bool, int>(false, count);
                    }
                }

            }
            catch (Exception ex)
            {
                return new Tuple<bool, int>(false, 0);
            }
        }
    }
}
