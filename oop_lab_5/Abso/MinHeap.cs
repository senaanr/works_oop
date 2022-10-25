﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abso
{
    public class MinHeap : Heap
    {
        public override int Extract()
        {
            var min = _sortedSet.First();
            _sortedSet.Remove(min);
            return min;
        }
    }
}
