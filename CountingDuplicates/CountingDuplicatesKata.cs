using System;
using System.Linq;

namespace CountingDuplicates
{
    public class CountingDuplicatesKata
    {
        public int DuplicateCount(string str)
        {
            if (str.Trim() == "")
            {
                return 0;
            }

            var strBuffer = str;

            return Count(strBuffer);
        }

        private static int Count(string strBuffer)
        {
            if (IsEmptyString(strBuffer)) return 0;

            if (IsExitsAboveTwice(strBuffer))
            {
                strBuffer = RemoveAllFirstWord(strBuffer);
                return 1 + Count(strBuffer);
            }
            else
            {
                strBuffer = RemoveAllFirstWord(strBuffer);
                return Count(strBuffer);
            }
        }

        private static string RemoveAllFirstWord(string strBuffer)
        {
            return strBuffer.ToLower().Replace(strBuffer[0].ToString().ToLower(), "");
        }

        private static bool IsExitsAboveTwice(string strBuffer)
        {
            return strBuffer.ToLower().ToCharArray().Count(x => x == strBuffer.ToLower()[0]) >= 2;
        }

        private static bool IsEmptyString(string strBuffer)
        {
            return strBuffer == "";
        }
    }
}