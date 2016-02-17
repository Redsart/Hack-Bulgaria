using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class SortAndSearchExtensions
    {
        public static IList<T> BubleSort<T>(this IList<T> list)
        {
            var comparer = Comparer<T>.Default;
            int i = list.Count - 1;
            while (i > 0)
            {
                int swap = 0;
                for (int j = 0; j < i; j++)
                {
                    if (comparer.Compare(list[j],list[j+1]) > 0)
                    {
                        var tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                        swap = j;
                    }
                }
                i = swap;
            }

            var newList=new List<T>();
            for (int index = 0; index < list.Count; index++)
            {
                newList.Add(list[index]);
            }
            return newList;
        }

        public static IList<T> BubleSort<T>(this IList<T> list, IComparer<T> comparer)
        {
            int i = list.Count - 1;
            while (i > 0)
            {
                int swap = 0;
                for (int j = 0; j < i; j++)
                {

                    if (comparer.Compare(list[j], list[j + 1]) > 0)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        swap = j;
                    }
                }
                i = swap;
            }

            var newList= new List<T>();
            for (int index = 0; index < list.Count; index++)
            {
                newList.Add(list[index]);
            }
            return newList;
        }

        public static IList<T> BubleSort<T>(this IList<T> list, Sorting.PredicateDelegate<T> predicate)
        {
            int i = list.Count - 1;
            while (i > 0)
            {
                int swap = 0;
                for (int j = 0; j < i; j++)
                {

                    if (predicate(list[j], list[j + 1]))
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        swap = j;
                    }
                }
                i = swap;
            }

            var newList = new List<T>();
            for (int index = 0; index < list.Count; index++)
            {
                newList.Add(list[index]);
            }
            return newList;
        }

        public static IList<T> SelectionSort<T>(this IList<T> list)
        {
            int min = 0;
            T tmp;
            var comparer = Comparer<T>.Default;

            for (int i = 0; i < list.Count-1; i++)
            {
                min = i;
                for (int j = i+1; j < list.Count; j++)
                {
                    if (comparer.Compare(list[j],list[min]) < 0)
                    {
                        tmp = list[i];
                        list[i] = list[min];
                        list[min] = tmp;
                    }
                }
            }

            var newList = new List<T>();
            for (int index = 0; index < list.Count; index++)
            {
                newList.Add(list[index]);
            }
            return newList;
        }

        public static IList<T> SelectionSort<T>(this IList<T> list, IComparer<T> compare)
        {
            int min = 0;
            T tmp;

            for (int i = 0; i < list.Count-1; i++)
            {
                min = i;
                for (int j = i+1; j < list.Count; j++)
                {
                    tmp = list[i];
                    list[i] = list[min];
                    list[min] = tmp;
                }
            }

            var newList = new List<T>();
            for (int index = 0; index < list.Count; index++)
            {
                newList.Add(list[index]);
            }
            return newList;
        }


    }
}
