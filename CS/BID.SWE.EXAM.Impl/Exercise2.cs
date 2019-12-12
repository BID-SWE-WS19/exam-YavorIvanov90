using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            return new CellAbleitung();
        }

        public int Method2()
        {
            CellAbleitung cell = new CellAbleitung();
            return cell.Grow();
        }

        public bool Method3(int o1)
        {
            CellAbleitung cell = new CellAbleitung();
            return cell.IsAlive();
        }
    }
}