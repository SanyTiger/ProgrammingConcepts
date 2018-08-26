using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LinkedList
{
    [TestClass]
    public class RemoveDuplicates
    {
        [TestMethod]
        public void TestMethod1()
        {
            var hash = new HashSet<int>();
            hash.Add(1);
            hash.Add(2);
            hash.Add(1);
            hash.Add(3);
            hash.Add(4);
            hash.Add(2);
            var head = new LinkedList<int>(hash);
            var sol = new RemoveDuplicatesSolution().Remove(head);
            var result = sol;
        }
    }
    public class RemoveDuplicatesSolution
    {
        public LinkedList<int> Remove(LinkedList<int> listNode)
        {
            var hash = new HashSet<int>();
            var lst = listNode.First;
            while (lst != null)
            {
                if (!hash.Contains(lst.Value))
                    hash.Add(lst.Value);
                lst = lst.Next;
            }
            listNode = new LinkedList<int>(hash);
            return listNode;
        }
    }
}
