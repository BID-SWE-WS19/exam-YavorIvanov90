using System;
using System.Collections.Generic;
using System.Text;

namespace BID.SWE.EXAM.Impl
{
    public abstract class Bewegung
    {
        protected int xP;
        public string Position()
        {
            return xP.ToString();
        }

        public string Move(int x)
        {
            xP = x;
            return xP.ToString();
        }

    }
}
