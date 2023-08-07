using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercisms
{
    public static class ListOps
    {
        public static List<T> Reverse<T>(List<T> list)
        {
            List<T> result = new List<T>();

            for (int i = list.Count - 1; i >= 0; i--)
                result.Add(list[i]);

            return result;
        }
        public static TOut Foldr<TIn, TOut>(List<TIn> list, TOut start, Func<TIn, TOut, TOut> func)
        {
            foreach (var item in Reverse(list))
                start = func(item, start);

            return start;
        }
        public static TOut Foldl<TIn, TOut>(List<TIn> list, TOut start, Func<TOut, TIn, TOut> func)
        {
            foreach (var item in list)
                start = func(start, item);

            return start;
        }
        public static List<TResult> Map<T, TResult>(List<T> list, Func<T, TResult> function)
        {
            List<TResult> resultList = new List<TResult>();

            foreach (var item in list)
            {
                TResult result = function(item);
                resultList.Add(result);
            }

            return resultList;
        }
        public static int Length(List<int> list)
        {
            int length = 0;

            foreach (var t in list)
                length++;

            return length;
        }
        public static List<T> Filter<T>(List<T> list, Func<T, bool> predicate)
        {
            List<T> filter = new List<T>();

            foreach (var item in list)
            {
                if (predicate(item))
                    filter.Add(item);
            }
            return filter;
        }
        public static List<T> Concatenate<T>(params List<T>[] lists)
        {
            List<T> concatenate = new List<T>();

            foreach (var list in lists)
            {
                concatenate = Append(concatenate, list);
            }
            return concatenate;
        }
        public static List<T> Append<T>(List<T> first, List<T> second)
        {
            for (var i = 0; i < second.Count; i++)
                first.Add(second[i]);

            return first;
        }
        public static void Main()
        {
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int> { 4, 5, 6 };
            List<int> list3 = new List<int> { 7, 8, 9 };
            //Append
            List<int> append = Append(list1, list2);
            //Concatenate
            List<int> concatenate = Concatenate(list1, list2, list3);
            //Filter
            List<int> filter = Filter(list1, (numero) => numero % 2 == 0);
            //Length
            var length = Length(list1);

            List<double> nums = new List<double> { 1, 4, 9, 16, 25 };
            //Map
            var map = Map(nums, Math.Sqrt);

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            //Foldr
            int somaFoldr = Foldr(numeros, 0, (num, acumulador) => num + acumulador);
            //Foldl
            int produtoFoldl = Foldl(numeros, 1, (acumulador, num) => acumulador * num);


            Console.WriteLine("Append: " + string.Join(", ", append));
            Console.WriteLine("Concatenate: " + string.Join(", ", concatenate));
            Console.WriteLine("Filter: " + string.Join(", ", filter));
            Console.WriteLine("Length: " + string.Join(", ", length));
            Console.WriteLine("Map: " + string.Join(", ", map));
            //Reverse
            Console.WriteLine("Reverse: " + string.Join(", ", Reverse(new List<int> { 1, 2, 3, 4, 5 })));
            Console.WriteLine("Soma usando Foldr: " + somaFoldr);
            Console.WriteLine("Produto usando Foldl: " + produtoFoldl);
        }
    }
}

