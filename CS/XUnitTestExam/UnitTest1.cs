using System;
using BID.SWE1.Exam.Interfaces;
using Xunit;
using BID.SWE.EXAM.Impl;


namespace BID.SWE.EXAM.Impl
{
    public class UnitTest1
    {
        [Fact]
        public void Exercise1_Method1()
        {
            DateTime dt = new DateTime(2019, 12, 14);
            string check = $"Cell rot born on {dt.Day}.{dt.Month}.{dt.Year} is alive";
            CellPrinter cellPrinter = new CellPrinter();
            Assert.Equal(check, cellPrinter.PrintState(true,dt,"rot"));
        }

        [Fact]
        public void Exercise1_Method2()
        {
            int x = 6;
            int y = 7;
            string check = $"Cell is on Position X:{x} Y:{y}";
            CellPrinter cellPrinter = new CellPrinter();
            Assert.Equal(check, cellPrinter.PrintPostion(x,y));
        }

        [Fact]
        public void Exercise2_Method2()
        {
            CellAbleitung cell = new CellAbleitung();
            Cell cellO = new Cell();
            Assert.Equal(cellO.Grow()*2,cell.Grow());
        }

        [Fact]
        public void Exercise2_Method3_True()
        {
            CellAbleitung cell = new CellAbleitung();
            Assert.True(cell.IsAlive(4));
        }

        [Fact]
        public void Exercise2_Method3_False()
        {
            CellAbleitung cell = new CellAbleitung();
            Assert.False(cell.IsAlive(5));
        }

        [Fact]
        public void Exercise3_Method1()
        {
            MapExam mp = new MapExam();
            Assert.Equal("BID-Map", mp.GetMapName());
        }
        [Fact]
        public void Exercise3_Method1_1()
        {
            MapExam mp = new MapExam();
            int size = 4;
            Assert.Equal(size*size, mp.GetMapSize(4));
        }
        [Fact]
        public void Exercise3_Method1_2()
        {
            int count = 2;
            MapExam mp = new MapExam();
            Assert.Equal(count, mp.AddNewCells(2));
        }

        [Fact]
        public void Exercise3_Method2_1()
        {
            Exercise3 e3 = new Exercise3();
            Bewegung[] bw = (Bewegung[])e3.Method2();
            Assert.IsType<Laufen>(bw[0]);
        }

        [Fact]
        public void Exercise3_Method2_2()
        {
            Exercise3 e3 = new Exercise3();
            Bewegung[] bw = (Bewegung[])e3.Method2();
            Assert.IsType<Springen>(bw[1]);
        }

        [Fact]
        public void Exercise4_Method1()
        {
            Laufen laufen = new Laufen();
            Assert.Equal("4", laufen.Move(4));
        }
    }
}
