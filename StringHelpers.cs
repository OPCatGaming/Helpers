using System;
using System.Collections.Generic;

namespace Helpers
{
    public class StringHelpers : IStringHelpers
    {
        public bool AdvancedContains(string lookAt, string findIn, bool noticeBefore = false, bool noticeAfter = false, bool ignoreCase = true)
        {
            int nextChar = 0;
            bool foundStr = false;
            string str = ignoreCase ? lookAt.ToLower() : lookAt;
            string find = ignoreCase ? findIn.ToLower() : findIn;
            for (int i = 0; i < str.Length; i++)
            {
                if (noticeBefore)
                {
                    if (nextChar == find.Length - 1)
                        return true;
                    else if (str[i] == find[nextChar])
                        nextChar++;
                    else
                        return false;
                } else if (noticeAfter)
                {
                    if (nextChar == find.Length - 1)
                        foundStr = true;
                    if (!foundStr && str[i] != find[nextChar])
                        nextChar = 0;
                    if (!foundStr && str[i] == find[nextChar])
                        nextChar++;

                    if (foundStr)
                    {
                        //Console.WriteLine(i);
                        if (i != str.Length - 1)
                            return false;
                        else
                            return true;
                    }
                } else if (noticeBefore && noticeAfter)
                {
                    if (str == find)
                        foundStr = true;
                } else
                {
                    if (nextChar == find.Length - 1)
                        return true;
                    if (!foundStr && str[i] != find[nextChar])
                        nextChar = 0;
                    if (!foundStr && str[i] == find[nextChar])
                        nextChar++;
                }
            }
            return false;
        }
    }
}
