using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ConditionFunctions
    {
        public static bool IsOdd(int x) {  return x % 2 != 0; }
        public static bool IsEven(int x) {  return x % 2 == 0; }
        public static bool DivisableBy4(int x) {  return x % 4 == 0; }
        public static bool DivisableBy8(int x) {  return x % 8 == 0; }
    }
}
