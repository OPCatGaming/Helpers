using System.Collections.Generic;

namespace Helpers
{
    public interface IStringHelpers
    {
        bool AdvancedContains(string str, string find, bool noticeAfter, bool noticeBefore, bool ignoreCase);
    }
}
