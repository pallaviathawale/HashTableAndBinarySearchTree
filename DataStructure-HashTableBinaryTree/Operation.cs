using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_HashTableBinaryTree
{
  class Operation
        {
            Dictionary<string, int> frequency = new Dictionary<string, int>();
            public void Frequency(MyMapNode<int, string> hash)
            {
                for (int key = 0; key < hash.size; key++)
                {
                    frequency.TryAdd(hash.Get(key).ToLower(), 0);
                    frequency[hash.Get(key).ToLower()]++;
                }
                foreach (KeyValuePair<string, int> item in frequency)
                {
                    Console.WriteLine($"frequency of word '{item.Key}' is {item.Value}");
                }
            }
        }
}
