using System;
using System.Collections.Generic;
using System.Text;

namespace BID.SWE.EXAM.Impl
{
    public abstract class Map
    {
        public abstract string GetMapName();
        public abstract float GetMapSize(float amount);
        public abstract int AddNewCells(int count);
    }
}
