using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisms
{
    public enum SublistEnum { Equal, Unequal, Sublist, Superlist };
    public static class SubList
    {
        public static SublistEnum Classify<T>(List<T> list1, List<T> list2) where T : IComparable
        {
            if (list1.SequenceEqual(list2))
                return SublistEnum.Equal;

            for (var i = 0; i <= Math.Abs(list1.Count - list2.Count); i++)
            {
                if (list1.Count > list2.Count && list1.GetRange(i, list2.Count).SequenceEqual(list2))
                    return SublistEnum.Superlist;

                if (list1.Count < list2.Count && list2.GetRange(i, list1.Count).SequenceEqual(list1))
                    return SublistEnum.Sublist;
            }
            return SublistEnum.Unequal;
        }

    }
}


