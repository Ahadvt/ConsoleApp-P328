using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Seat
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsFull { get; set; }

        public Seat(int row, int column)
        {
            Row = row;
            Column = column;
            IsFull = false;
        }

        public override string ToString()
        {
            return $"Row: {Row} Column: {Column} IsFull:{IsFull}";
        }
    }
}
