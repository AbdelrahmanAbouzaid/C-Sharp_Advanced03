using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SortingCondition
    {
        public static bool IsGreater(int x, int y) { return x > y; }
        public static bool IsLess(int x, int y) { return x < y; }
        public static bool IsLengthGrt(string x, string y) { return x.Length > y.Length; }
        public static bool IsLengthLess(string x, string y) { return x.Length < y.Length; }
        public static bool CheckLengthGrt4(string x) { return x.Length > 4; }
        public static bool CheckLengthLess4(string x) { return x.Length < 4; }
        public static bool CheckLengthEqual4(string x) { return x.Length == 4; }
    }
}
