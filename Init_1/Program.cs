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
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
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
    class Program
    {
        static void Main(string[] args)
        {
            //var x =State.active.GetHashCode();
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Week week = new Week();
            foreach(var day in week)
            {
                Console.WriteLine(day);
            }
            




            if (numbers.Length != 0 && numbers != null)
            foreach (var x in numbers)
            {
                Console.WriteLine(x);
            }
            else
                throw new InvalidOperationException();
            var br =0;
            Console.ReadLine();
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
