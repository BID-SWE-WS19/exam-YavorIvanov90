using System;
using System.Collections.Generic;
using System.Text;
using BID.SWE1.Exam.Interfaces;


namespace BID.SWE.EXAM.Impl
{
    public class MapExam : Map
    {
        public override int AddNewCells(int count)
        {
            return count;
        }

        public override string GetMapName()
        {
            string mapS = "BID-Map";
            return mapS;
        }

        public override float GetMapSize(float amount)
        {
            return amount * amount;
        }
    }
}
