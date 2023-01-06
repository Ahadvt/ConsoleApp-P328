using ConsoleApp1.Enums;
using ConsoleApp1.Models;
using ConsoleApp1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services.Implementations
{
    internal class CinemaService : ICinemaService
    {
        private List<Hall> _halls { get; set;}=new List<Hall>();

        public List<Hall> Halls { get { return _halls; } }

        public string CreateHall(int row, int column, HallCategory category)
        {
            if(row<=0 || column<=0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                return "row or colmn can not be less than 1";
            }

            Hall hall=new Hall(row, column, category);
            Halls.Add(hall);
            return $"{hall.No}  Succesly created";
        }

        public string EditHall(string no, HallCategory category)
        {
            foreach (Hall hall in Halls)
            {
                if (hall.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    hall.Category = category;
                    hall.No = $"{category.ToString().Substring(0, 2)}-{hall.Id}";
                    return $"{no}- Hall updated to {hall.No}";
                }
            }
            return $"Please add valid no";
        }

        public void GetAllHall()
        {
            foreach (Hall hall in Halls)
            {
                Console.WriteLine(hall);
            }
        }

        public void GetAllSeats(string no)
        {
            foreach (Hall hall in Halls)
            {
                if (hall.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    foreach (Seat seat in hall.Seats)
                    {
                        Console.WriteLine(seat);
                    }
                    return;
                }
            }
            Console.WriteLine("Please add valid no");
        }

        public void Reserve(string no, int row, int column)
        {
            foreach (Hall hall in Halls)
            {
                if (hall.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    foreach (Seat seat in hall.Seats)
                    {
                        if (seat.Row == row && seat.Column == column)
                        {
                            //seat.IsFull==true;
                            if (seat.IsFull)
                            {
                                Console.WriteLine("Alrady reserved");
                            }
                            else
                            {
                                seat.IsFull= true;
                                Console.WriteLine("Succesly reserved");
                            }
                            return;
                        }
                    }
                    Console.WriteLine("Please add valid row or column");
                    return;
                }
            }
            Console.WriteLine("Please add valid no");
        }
    }
}
