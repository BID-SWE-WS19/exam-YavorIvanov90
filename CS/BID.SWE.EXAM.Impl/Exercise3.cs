﻿using System;
using BID.SWE1.Exam.Interfaces;

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
            throw new NotImplementedException();
        }

    }
}