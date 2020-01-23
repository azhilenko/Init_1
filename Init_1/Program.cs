using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Init_1
{
    class Program
    {
        static void Main(string[] args)
        {
            getfromlist();
            State.active.GetHashCode();


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
