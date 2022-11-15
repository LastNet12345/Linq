using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    //public delegate void Test(string str);
    internal static class Extensions
    {
        internal static void AddYear(this Person person, int year)
        {
            person.Age += year;
        }

        internal static void AddOwnMethod(this List<Person> people)
        {

        } 
        
        internal static void AddOwnMethod2(this IEnumerable<Person> people)
        {

        }

        internal static IEnumerable<T> Testing<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            foreach (var item in source)
            {
                if (predicate(item)) yield return item;
            }
        }
    }
}
