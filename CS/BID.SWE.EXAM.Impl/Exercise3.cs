using System;
using BID.SWE1.Exam.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            return new MapExam();
        }

        public object Method2()
        {
            Bewegung[] bw = new Bewegung[2];
            Laufen l = new Laufen();
            Springen s = new Springen();
            bw[0] = l;
            bw[1] = s;
            return bw;

        }

    }
}