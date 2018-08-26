using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace Leetcode
{
    [TestClass]
    public class LRUCacheSolution
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public class LRUCache
    {
        SortedDictionary<int, int> hash;
        int cap;
        int recentKey = -1;

        public LRUCache(int capacity)
        {
            hash = new SortedDictionary<int, int>();
            cap = capacity;
        }
        public int Get(int key)
        {
            if (isExist(key))
            {
                hash.Remove(key);
                return key;
            }
            else
                return -1;
        }
        public void Put(int key, int value)
        {
            recentKey = hash.Keys.FirstOrDefault();
            if (!isExist(key))
            {
                if (hash.Count == 2)
                    hash.Remove(recentKey);
                hash.Add(key, value);
            }
        }
        public bool isExist(int key)
        {
            return hash.ContainsKey(key) ? true : false;
        }

        /**
         * Your LRUCache object will be instantiated and called as such:
         * LRUCache obj = new LRUCache(capacity);
         * int param_1 = obj.Get(key);
         * obj.Put(key,value);
         */
    }
}
