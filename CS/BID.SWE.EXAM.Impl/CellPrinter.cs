using System;
using System.Collections.Generic;
using System.Text;
using BID.SWE1.Exam.Impl;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class CellPrinter : ICellPrinter
    {
    public string PrintPostion(int x, int y)
    {
        string position = $"Cell is on Position X:{x} Y:{y}";
        return position;
    }

    public string PrintState(bool alive, DateTime date, string color)
    {
            string aliveS = "";
            if(alive)
            {
                aliveS = "alive";
            } else
            {
                aliveS = "dead";
            }

        string state = $"Cell {color} born on {date.Day}.{date.Month}.{date.Year} is {aliveS}";
        return state;
    }
}
}
