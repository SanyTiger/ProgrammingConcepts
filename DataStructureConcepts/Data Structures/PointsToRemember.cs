using System;

namespace PointsToRemember
{
    public class PointsToRemember
    {
        public PointsToRemember()
        {
            // Reverse a string
            string revStr1 = "len";
            var revStr2 = revStr1.ToCharArray();
            Array.Reverse(revStr2);
            var revStr3 = new string(revStr2);

            // Character to String
            string toString = Char.ToString('a');

            // Get SubString of String
            string mainStr = "len";
            string subStr = mainStr.Substring(1);
        }
    }
}
