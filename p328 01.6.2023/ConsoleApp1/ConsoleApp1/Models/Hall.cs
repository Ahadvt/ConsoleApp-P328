using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Hall
    {
        static int _id = 1;
        public int Id { get; set; }

        public string No { get; set; }

        public HallCategory Category { get; set; }
        public Seat[,] Seats { get; set; }


        public Hall(int row, int column, HallCategory category)
        {
            No = $"{category.ToString().Substring(0, 2)}-{_id}";
            Category = category;
            Seats = new Seat[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Seat seat = new Seat(i + 1, j + 1);
                    Seats[i, j] = seat;
                }
            }
            Id = _id;
            _id++;
        }

        public override string ToString()
        {
            return $"No:{No} Category:{Category}";
        }
    }
}
