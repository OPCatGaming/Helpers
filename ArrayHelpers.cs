using System;
using System.Collections.Generic;

namespace Helpers
{
    public class ArrayHelpers : IArrayHelpers
    {
        public T[] AddItemToArray<T>(T[] array, T itemsToAdd, int index = -1)
        {
            T[] newArray = new T[array.Length + 1];

            if ((index < 0 || index > array.Length) && index != -1)
            {
                Console.WriteLine("There is not an index with that value");
                return array;
            }

            if (index >= 0 && index < array.Length + 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == index)
                    {
                        newArray.SetValue("Hi!", i);
                    }
                    else if (array[i] != null)
                        newArray.SetValue(array[i], i);
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                    newArray.SetValue(array[i], i);
                newArray.SetValue(itemsToAdd, array.Length);
            }
            return newArray;
        }

        public T[] AddItemToArray<T>(T[] array, T[] itemsToAdd)
        {
            T[] newArray = new T[array.Length + itemsToAdd.Length];

            for (int i = 0; i < array.Length; i++)
                newArray.SetValue(array[i], i);
            for (int i = 0; i < itemsToAdd.Length; i++)
                newArray.SetValue(itemsToAdd[i], array.Length + i);

            return newArray;
        }

        public T[] AddItemToArray<T>(T[] array, List<T> itemsToAdd)
        {
            T[] newArray = new T[array.Length + itemsToAdd.Count];

            for (int i = 0; i < array.Length; i++)
                newArray.SetValue(array[i], i);
            for (int i = 0; i < itemsToAdd.Count; i++)
                newArray.SetValue(itemsToAdd[i], array.Length + i);

            return newArray;
        }

        public T[] RemoveItemFromArray<T>(T[] array, int index)
        {
            T[] newArray = new T[array.Length - 1];
            int addTo = 0;

            if (index < 0 || index > array.Length)
            {
                Console.WriteLine("There is not an index with that value");
                return array;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (!(i == index))
                    newArray.SetValue(array[i], addTo);
                else
                {
                    index = -1;
                    addTo--;
                }
                addTo++;
            }
            return newArray;
        }

        public List<T> ToList<T>(T[] array)
        {
            List<T> newList = new List<T>();

            foreach (T item in array)
                newList.Add(item);

            return newList;
        }

        public void PrintArrayContents<T>(T[] array, string separateMethod = ", ")
        {
            string finalStr = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                    finalStr = finalStr + separateMethod;
                finalStr = finalStr + array[i].ToString();
            }
            Console.WriteLine(finalStr);
        }

        public bool Contains(Object[] array, Object item)
        {
            foreach (Object i in array)
                if (i == item)
                    return true;
            return false;
        }
    }
}
