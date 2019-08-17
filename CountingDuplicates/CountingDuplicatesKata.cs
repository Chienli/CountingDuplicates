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
            if (strBuffer != "")
            {
                if (strBuffer.ToLower().ToCharArray().Count(x => x == strBuffer.ToLower()[0]) >= 2)
                {
                    strBuffer = strBuffer.ToLower().Replace(strBuffer[0].ToString().ToLower(), "");
                    return 1 + Count(strBuffer);
                }
                else
                {
                    strBuffer = strBuffer.ToLower().Replace(strBuffer[0].ToString().ToLower(), "");
                    return Count(strBuffer);
                }
            }
            return 0;
        }
    }
}