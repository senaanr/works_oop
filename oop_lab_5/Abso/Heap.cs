using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abso
{
    public class Heap
    {
        public abstract class Heap
        {
            protected SortedSet<int> _sortedSet;

            public Heap()
            {
                _sortedSet = new SortedSet<int>();
            }

            public void Insert(int item)
            {
                _sortedSet.Add(item);
            }
        }
    }
}
