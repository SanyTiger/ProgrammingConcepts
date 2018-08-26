using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructureConcepts.Leetcode
{
    /*
     * Test Cases: 35/42
     */
    [TestClass]
    public class CourseSchedule
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public class CourseScheduleSolution
    {
        public bool CanFinish(int numCourses, int[,] prerequisites)
        {
            var hash = new HashSet<int>();
            var isPos = true;
            var count = 0;

            if (numCourses >= 1 && prerequisites.Length == 0)
                return isPos;
            if (numCourses == 0)
                return false;
            if (prerequisites.Length == 0)
                return false;
            if (numCourses > prerequisites.Length)
                return isPos;
            else
            {
                foreach (var pre in prerequisites)
                {
                    if (count % 2 == 1)
                    {
                        if (hash.Contains(pre))
                        {
                            isPos = false;
                            break;
                        }
                    }
                    else
                        hash.Add(pre);
                    ++count;
                }
            }
            return isPos;
        }
    }
}
