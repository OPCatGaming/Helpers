using System.Collections.Generic;

namespace Helpers
{
    public interface IListHelpers
    {
        void PrintListContents<T>(List<T> list, string separateMethod = ", ");
    }
}
