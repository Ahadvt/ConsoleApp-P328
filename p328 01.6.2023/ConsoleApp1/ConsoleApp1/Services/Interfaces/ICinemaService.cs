using ConsoleApp1.Enums;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services.Interfaces
{
    internal interface ICinemaService
    {
        public List<Hall> Halls { get; }
        public string CreateHall(int row,int column,HallCategory category);
        public string EditHall(string no,HallCategory category);
        public void GetAllHall();
        public void GetAllSeats(string no);
        public void Reserve(string no,int row,int column);
    }
}
