using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services.Implementations
{
    internal static class MenuService
    {
        private static CinemaService CinemaService = new();

        public static void CreateHallMenu()
        {
            Console.WriteLine("Please add row number");
            int.TryParse(Console.ReadLine(), out int row);
            Console.WriteLine("Please add Column number");
            int.TryParse(Console.ReadLine(), out int Column);

            test:
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("Please Choose Category");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            foreach (var item in Enum.GetValues(typeof(HallCategory)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }

            int CategoryLength = Enum.GetValues(typeof(HallCategory)).Length;


            int.TryParse(Console.ReadLine(),out int CategoryNumber);


            if(CategoryNumber<=0||CategoryNumber>CategoryLength)
            {
                goto test;
            }
              string result= CinemaService.CreateHall(row,Column,(HallCategory)CategoryNumber);

            Console.WriteLine(result);

        }
        public static void EditHallMenu()
        {
            Console.WriteLine("Please add Hall number");
            string no=Console.ReadLine();
          

        test:
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("Please Choose Category");
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            foreach (var item in Enum.GetValues(typeof(HallCategory)))
            {
                Console.WriteLine($"{(int)item}.{item}");
            }

            int CategoryLength = Enum.GetValues(typeof(HallCategory)).Length;


            int.TryParse(Console.ReadLine(), out int CategoryNumber);


            if (CategoryNumber <= 0 || CategoryNumber > CategoryLength)
            {
                goto test;
            }
            string result = CinemaService.EditHall(no,(HallCategory)CategoryNumber);

            Console.WriteLine(result);

        }

        public static void GetAllHallMenu() {

            CinemaService.GetAllHall();
        }

        public static void GetAllSeatsMenu()
        {
            Console.WriteLine("Pleasee addd hall no");
            string no = Console.ReadLine();
            CinemaService.GetAllSeats(no);
        }

        public static void ReserveMenu()
        {
            Console.WriteLine("Pleasee addd hall no");
            string no = Console.ReadLine();
            Console.WriteLine("Please add row number");
            int.TryParse(Console.ReadLine(), out int row);
            Console.WriteLine("Please add Column number");
            int.TryParse(Console.ReadLine(), out int Column);

            CinemaService.Reserve(no,row,Column);
        }
    }
}

