using System;
namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {
        }

        public bool HasChangedGears { get; set; }
        double IVehicle.EngineSize { get; set; } = 5.0;
        string IVehicle.Make { get; set; } = "Ford";
        string IVehicle.Model { get; set; } = "Mustang";
        int IVehicle.SeatCount { get; set; } = 4;
        string ICompany.CompanyName { get; set; } = "Ford"; 
        string ICompany.Motto { get; set; } = "Built Ford Tough";

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($" The {GetType().Name} is now parked. . ");
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }

        public void Park()
        {
            Console.WriteLine($" The {GetType().Name} now driving forward. . ");
        }

        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($" The {GetType().Name} now reversing. . ");
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears"); 
            }

        }
    }
