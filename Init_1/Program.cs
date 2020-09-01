using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Init_1
{

    class Week
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday","MondOktober" };
        public IEnumerator<string> GetEnumerator() { return new WeekEnumerator(days); }

        class WeekEnumerator : IEnumerator<string>
        {
            string[] days;
            int position = -1;
            public WeekEnumerator(string[] dayx)
            {
                this.days = dayx;
            }
            public string Current
            {
                get
                {
                    if (position == -1 || position >= days.Length)
                        throw new InvalidOperationException();
                    return days[position];
                }
            }
            object IEnumerator.Current => throw new NotImplementedException();
            public bool MoveNext()
            {
                if (position < days.Length - 1) { position++; return true; }
                else
                    return false;
            }
            public void Reset() { position = -1; }
            public void Dispose() { }
        }
    }












    public static class Kata
    {
        public static int GetVowelCount(string str)
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            return str.ToCharArray().Where(c => vowels.Contains(c)).Count();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
            var br = 0;




        //var x =State.active.GetHashCode();
        int[] numbers = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            

        //Week week = new Week();

        //for (int i = 0; i < numbers.Length;i++)
        //{
        //    if(numbers[i]%2==0)
        //    Console.WriteLine(numbers[i]);
        //}
        //foreach(var day in week)
        //{
        //    Console.WriteLine(day);
        //}


        //if (numbers.Length != 0 && numbers != null)
        //foreach (var x in numbers)
        //{
        //    Console.WriteLine(x);
        //}
        //else
        //    throw new InvalidOperationException();

    }

        enum State
        {
            deleted = -1,
            stoped = 0,
            archived = 1,
            ready = 2,
            active = 3
        }
        private static void getfromlist()
        {
            List<int> list = new List<int>();
            list.Add(0);
        }
    }
}
