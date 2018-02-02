using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    [TestClass]
    public class RomanTolnt
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new RomanToIntSolution().RomanToInt("MCMXCVI");
        }
    }
    public class RomanToIntSolution
    {

        public int RomanToInt(string s)
        {
            var len = s.Length;
            var num = 0;
            var pos = 0;
            var arrNum = new int[len];

            if (len == 0)
                return num;
            else if(len == 0)
                return RomToInt(char.ToString(s[0]));
            for (int i = 0; i < len; i++)
                arrNum[i] = RomToInt(char.ToString(s[i]));
            while (pos < len)
            {
                var prev = pos < len ? arrNum[pos] : 0;
                var next = ++pos < len ? arrNum[pos] : 0;
                if (prev >= next)
                    continue;
                if (prev < next)
                {
                    next -= prev;
                    prev = 0;
                    arrNum[pos] = next;
                    arrNum[--pos] = prev;
                    ++pos;
                }
            }
            for (int i = 0; i < len; i++)
                num = arrNum[i] < 0 ? num : num + arrNum[i];
            return num;
        }
        public int RomToInt(string rom)
        {
            if (rom == "X")
                return 10;
            if (rom == "L")
                return 50;
            else if (rom == "C")
                return 100;
            else if (rom == "D")
                return 500;
            else if (rom == "M")
                return 1000;
            else
            {
                switch (rom)
                {
                    case "I": return 1;
                    case "II": return 2;
                    case "III": return 3;
                    case "IV": return 4;
                    case "V": return 5;
                    case "VI": return 6;
                    case "VII": return 7;
                    case "VIII": return 8;
                    case "IX": return 9;
                    default: return 0;
                }
            }
        }
    }
}
