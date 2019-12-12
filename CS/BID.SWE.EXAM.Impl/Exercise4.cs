using System;
using System.IO;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            string fw = "Frohe Weihnachten";
            int n = 42;
            bool b = false;
            MemoryStream streamReader;
            using (streamReader = new MemoryStream())
            {
                 using (var sw = new StreamWriter(streamReader))
                {
                    sw.Write(fw);
                    sw.Write(n);
                    sw.Write(b);
                    sw.Flush();
                }
            }
            return streamReader;
        }

        public object Method2(object obj)
        {
            throw new NotImplementedException();
        }
    }
}