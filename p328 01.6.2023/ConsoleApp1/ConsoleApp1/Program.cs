


using ConsoleApp1.Services.Implementations;
using System.Linq.Expressions;

int selection;
do
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("1.Create Hall");
    Console.WriteLine("2.Edit Hall");
    Console.WriteLine("3.GetAll Hall");
    Console.WriteLine("4.GetAllSeats");
    Console.WriteLine("5.Reserve Seat");
    Console.WriteLine("0.Close");

    int.TryParse(Console.ReadLine(), out selection);

    switch (selection)
    {
        case 1:
            MenuService.CreateHallMenu();
            break;

        case 2:
            MenuService.EditHallMenu();
            break;

        case 3:
            MenuService.GetAllHallMenu();
            break;

        case 4:
            MenuService.GetAllSeatsMenu();
            break;

        case 5:
            MenuService.ReserveMenu();
            break;

        default:
            if (selection != 0)
            {
                Console.WriteLine("Please choose valid number");
            }
            break;
    }


} while (selection!=0);