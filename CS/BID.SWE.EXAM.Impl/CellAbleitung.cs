using System;
using System.Collections.Generic;
using System.Text;
using BID.SWE1.Exam.Interfaces;


namespace BID.SWE.EXAM.Impl
{
    public class CellAbleitung : Cell
    {
        public override int Grow()
        {
            return base.Grow()*2;
        }
        public bool IsAlive(int neighbours)
        {
            if (neighbours % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
