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
            if (strBuffer.ToLower().ToCharArray().Count(x => x == strBuffer[0]) >= 2)
            {
                strBuffer = strBuffer.Replace(strBuffer[0].ToString(), "");
                return 1 + Count(strBuffer);
            }

            return 0;
        }
    }
}