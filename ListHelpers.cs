using System.Collections.Generic;

namespace Helpers
{
    using System;
    using System.Collections.Generic;

    namespace Helpers
    {
        public class ListHelpers : IListHelpers
        {
            public void PrintListContents<T>(List<T> list, string separateMethod = ", ")
            {
                string finalStr = "";

                for (int i = 0; i < list.Count; i++)
                {
                    if (i != 0)
                        finalStr = finalStr + separateMethod;
                    finalStr = finalStr + list[i].ToString();
                }
                Console.WriteLine(finalStr);
            }
        }
    }

}
