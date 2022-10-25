﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abso
{
    public class MaxHeap : Heap
    {
        public override int Extract()
        {
           var max = _sortedSet.Last();
            _sortedSet.Remove(max);
            return max;
        }
    }
}