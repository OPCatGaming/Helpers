using System;
using System.Collections.Generic;

namespace Helpers
{
    public interface IArrayHelpers
    {
        T[] addItemToArray<T>(T[] array, T itemToAdd, int index = -1);
        T[] addItemToArray<T>(T[] array, T[] itemsToAdd);
        T[] addItemToArray<T>(T[] array, List<T> itemsToAdd);
        T[] removeItemFromArray<T>(T[] array, int index);
        void printArrayContents<T>(T[] array, string separateMethod = ", ");
        bool Contains(Object[] array, Object item);
    }
}
