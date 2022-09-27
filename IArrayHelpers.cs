using System;
using System.Collections.Generic;

namespace Helpers
{
    public interface IArrayHelpers
    {
        T[] AddItemToArray<T>(T[] array, T itemToAdd, int index = -1);
        T[] AddItemToArray<T>(T[] array, T[] itemsToAdd);
        T[] AddItemToArray<T>(T[] array, List<T> itemsToAdd);
        T[] RemoveItemFromArray<T>(T[] array, int index);
        List<T> ToList<T>(T[] array);
        void PrintArrayContents<T>(T[] array, string separateMethod = ", ");
        bool Contains(Object[] array, Object item);

    }
}
